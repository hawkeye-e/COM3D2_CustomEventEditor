using COM3D2_CustomEventEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM3D2_CustomEventEditor.CustomControl
{
    public partial class Canvas : Panel
    {

        private Point _CurrentDraggingSource;
        private Point _CurrentDraggingTarget;
        private bool _IsConnectionDragging = false;

        private Dictionary<ADVStep.ConnectionPoint, PictureBox> _StepItemConnectionPoint;
        private PictureBox _LineSourceConnectionPoint;
        private PictureBox _LineTargetConnectionPoint;
        private bool _IsChangeBorderPointDraggingSource;

        private bool _IsSelectingLine = false;
        private int _SelectedLineID = -1;
        private List<StepItem> _SelectedLineOrigins = new List<StepItem>();
        private List<ADVStep.ConnectionPoint> _SelectedLineOriginsBorderPoint = new List<ADVStep.ConnectionPoint>();
        

        public Canvas()
        {
            InitializeComponent();
            //DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);
            InitConnectionPoints();
        }

        public Canvas(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            //DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.UserPaint |
                        ControlStyles.AllPaintingInWmPaint, true);

            InitConnectionPoints();
        }

        //Fix the issue of clicking control causing the scroll position to reset
        //ref: https://nickstips.wordpress.com/2010/03/03/c-panel-resets-scroll-position-after-focus-is-lost-and-regained/
        protected override System.Drawing.Point ScrollToControl(System.Windows.Forms.Control activeControl)
        {
            // Returning the current location prevents the panel from
            // scrolling to the active control when the panel loses and regains focus
            return this.DisplayRectangle.Location;
        }

        private void InitConnectionPoints()
        {
            _StepItemConnectionPoint = new Dictionary<ADVStep.ConnectionPoint, PictureBox>();

            foreach (ADVStep.ConnectionPoint pointType in Enum.GetValues(typeof(ADVStep.ConnectionPoint)))
            {
                PictureBox pictureBox = InitConnectionPoint();
                _StepItemConnectionPoint.Add(pointType, pictureBox);
            }

            _LineSourceConnectionPoint = InitLineConnectionPoint();
            _LineTargetConnectionPoint = InitLineConnectionPoint();

        }



        private PictureBox InitLineConnectionPoint()
        {
            PictureBox pb = InitConnectionPoint();

            pb.MouseDown += LineConnectionPoint_MouseDown;
            pb.MouseUp += LineConnectionPoint_MouseUp;
            pb.MouseMove += LineConnectionPoint_MouseMove;

            return pb;
        }

        private void LineConnectionPoint_MouseMove(object? sender, MouseEventArgs e)
        {
            if (_IsConnectionDragging)
            {
                Control ctrl = (Control)sender;
                Point sourcePoint = new Point();
                Point targetPoint = new Point();


                if (_IsChangeBorderPointDraggingSource)
                {
                    sourcePoint.X = ctrl.Location.X + e.Location.X;
                    sourcePoint.Y = ctrl.Location.Y + e.Location.Y;

                    targetPoint.X = _CurrentDraggingTarget.X;
                    targetPoint.Y = _CurrentDraggingTarget.Y;
                }
                else
                {
                    sourcePoint.X = _CurrentDraggingSource.X;
                    sourcePoint.Y = _CurrentDraggingSource.Y;

                    targetPoint.X = ctrl.Location.X + e.Location.X;
                    targetPoint.Y = ctrl.Location.Y + e.Location.Y;
                }

                SetConnectingLine(sourcePoint, targetPoint);
                Redraw();
            }
        }

        private void LineConnectionPoint_MouseUp(object? sender, MouseEventArgs e)
        {
            _IsConnectionDragging = false;
            
            _SelectedLineOrigins[0].SetConnectionVisible(_SelectedLineOrigins[1], true);

            //test if the mouse pointer overlap with any valid border point when dragging finish
            ADVStep.GraphConnection currentLine = _SelectedLineOrigins[0].StepData.ConnectionList.Where(x => x.ID == _SelectedLineID).FirstOrDefault();
            var mouseLocation = PointToClient(Cursor.Position);
            
            if (currentLine != null) {
                
                foreach (var kvp in _StepItemConnectionPoint)
                {
                    if (Util.IsWithinControl(kvp.Value, mouseLocation))
                    {
                        
                        //TODO: branching case for multiple connection connecting same place??
                        //Overlap
                        ADVStep.ConnectionPoint source = currentLine.From;
                        ADVStep.ConnectionPoint target = currentLine.To;
                        if (_IsChangeBorderPointDraggingSource)
                            source = kvp.Key;
                        else
                            target = kvp.Key;
                        
                        _SelectedLineOrigins[0].SetConnection(_SelectedLineOrigins[1], source, target, currentLine.ID);

                        break;
                    }
                }
            }
            

            DeselectLine();
            Redraw();
        }

        private void LineConnectionPoint_MouseDown(object? sender, MouseEventArgs e)
        {
            
            _IsConnectionDragging = true;
            _LineSourceConnectionPoint.Visible = false;
            _LineTargetConnectionPoint.Visible = false;

            _CurrentDraggingSource = _LineSourceConnectionPoint.Location;
            _CurrentDraggingTarget = _LineTargetConnectionPoint.Location;

            if (((PictureBox)sender) == _LineSourceConnectionPoint)
            {
                _IsChangeBorderPointDraggingSource = true;
                ShowConnectorDot(_SelectedLineOrigins[0], _StepItemConnectionPoint);
            }
            else
            {
                _IsChangeBorderPointDraggingSource = false;
                ShowConnectorDot(_SelectedLineOrigins[1], _StepItemConnectionPoint);
            }
            
            _SelectedLineOrigins[0].SetConnectionVisible(_SelectedLineOrigins[1], false);
            Redraw();
            
        }

        private PictureBox InitConnectionPoint()
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(7, 7);
            pb.BackgroundImage = Resources.connector_dot;
            pb.BackgroundImageLayout = ImageLayout.Stretch;
            pb.Visible = false;
            this.Controls.Add(pb);

            return pb;
        }

        public void DrawConnectedLines(Graphics g)
        {
            
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Create two AdjustableArrowCap objects
            AdjustableArrowCap cap1 = new AdjustableArrowCap(1, 1, false);
            AdjustableArrowCap cap2 = new AdjustableArrowCap(2, 1);

            // Set cap properties
            cap1.BaseCap = LineCap.Flat;
            cap1.BaseInset = 10;
            cap1.StrokeJoin = LineJoin.Bevel;
            cap2.WidthScale = 5;
            cap2.BaseCap = LineCap.Square;
            cap2.Height = 1;

            // Create a pen
            Pen blackPen = new Pen(Color.Black, 1);
            Pen redPen = new Pen(Color.Red, 1);

            // Set CustomStartCap and CustomEndCap properties
            blackPen.CustomStartCap = cap1;
            blackPen.CustomEndCap = cap2;
            redPen.CustomStartCap = cap1;
            redPen.CustomEndCap = cap2;


            foreach (var step in Global.AllSteps)
            {
                foreach (var c in step.StepData.ConnectionList)
                {
                    if (!c.IsDraw)
                        continue;

                    var targetStep = Global.AllSteps.Where(x => x.StepData.ID == c.TargetStepID).FirstOrDefault();

                    if (targetStep != null)
                    {
                        Point p1 = step.GetBorderPoint(c.From);
                        Point p2 = targetStep.GetBorderPoint(c.To);

                        if(IsSelectedLine(step, targetStep, c.From, c.To))
                            g.DrawLine(redPen, p1, p2);
                        else
                            g.DrawLine(blackPen, p1, p2);
                    }
                }
            }

            if (_IsConnectionDragging)
            {
                g.DrawLine(redPen, _CurrentDraggingSource, _CurrentDraggingTarget);
            }

            // Dispose of objects
            blackPen.Dispose();
            redPen.Dispose();
        }

        internal void SetSelectedLine(StepItem source,  StepItem target, ADVStep.ConnectionPoint sourceBorderPoint, ADVStep.ConnectionPoint targetBorderPoint)
        {
            //multiple line overlapping?
            var line = source.StepData.ConnectionList.Where(x => x.TargetStepID == target.StepData.ID).First();

            _IsSelectingLine = true;
            _SelectedLineID = line.ID;

            _SelectedLineOrigins.Add(source);
            _SelectedLineOrigins.Add(target);
            _SelectedLineOriginsBorderPoint.Add(sourceBorderPoint);
            _SelectedLineOriginsBorderPoint.Add(targetBorderPoint);

            ShowConnectorDotAtPoint(_LineSourceConnectionPoint, source.GetBorderPoint(sourceBorderPoint));
            ShowConnectorDotAtPoint(_LineTargetConnectionPoint, target.GetBorderPoint(targetBorderPoint));
        }

        internal void DeselectLine()
        {
            _IsSelectingLine = false;
            _SelectedLineID = -1;

            _SelectedLineOrigins.Clear();
            _SelectedLineOriginsBorderPoint.Clear();

            HideConnectorDot(_StepItemConnectionPoint);

            _LineSourceConnectionPoint.Visible= false;
            _LineTargetConnectionPoint.Visible = false;
        }

        private void ShowConnectorDotAtPoint(PictureBox dot, Point point)
        {
            dot.Location = new Point(point.X - dot.Size.Width / 2, point.Y - dot.Size.Height / 2);
            dot.Visible = true;
        }

        private void ShowConnectorDot(StepItem item, Dictionary<ADVStep.ConnectionPoint, PictureBox> dots)
        {
            foreach(var kvp in dots)
            {
                Point basePoint = item.GetBorderPoint(kvp.Key);
                basePoint.Offset(-3, -3);
                
                kvp.Value.Location = basePoint;
                kvp.Value.Visible = true;
                kvp.Value.BringToFront();
            }
        }

        private void HideConnectorDot(Dictionary<ADVStep.ConnectionPoint, PictureBox> dots)
        {
            foreach (var kvp in dots)
                kvp.Value.Visible = false;
        }

        private bool IsSelectedLine(StepItem source, StepItem target, ADVStep.ConnectionPoint sourceBorderPoint, ADVStep.ConnectionPoint targetBorderPoint)
        {
            if (_SelectedLineOrigins.Count == 2 && _SelectedLineOriginsBorderPoint.Count == 2)
                if (source == _SelectedLineOrigins[0] && target == _SelectedLineOrigins[1]
                    && sourceBorderPoint == _SelectedLineOriginsBorderPoint[0] && targetBorderPoint == _SelectedLineOriginsBorderPoint[1])
                    return true;
            return false;
        }

        public bool IsConnectionDragging
        {
            get { return _IsConnectionDragging; }
            set { _IsConnectionDragging = value; }
        }

        public void SetConnectingLine(Point Source, Point Target)
        {
            _IsConnectionDragging = true;
            _CurrentDraggingSource = Source;
            _CurrentDraggingTarget = Target;
            Refresh();
        }

        public void Redraw()
        {
            Refresh();
        }

        public void HandleDeleteKey()
        {
            if (_IsSelectingLine)
            {
                if (_SelectedLineOrigins.Count > 0)
                {
                    //A line is selected
                    
                    _SelectedLineOrigins[0].RemoveConnectionByTarget(_SelectedLineOrigins[1]);
                    DeselectLine();
                    Redraw();
                }
            }
        }

    }
}
