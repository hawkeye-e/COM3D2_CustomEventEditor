using COM3D2_CustomEventEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace COM3D2_CustomEventEditor
{
    public partial class StepItem : UserControl
    {
        private State _State = State.Normal;
        private bool _IsDragging = false;
        private StepType _StepType;

        internal ADVStep StepData;

        public delegate void MyEventHandler(object sender, StepType stepType);
        public event MyEventHandler StepSelected;
        public event EventHandler ConnectStepFinished;

        internal class StepItemColor
        {
            internal static readonly Color Common = Color.FromArgb(130, 199, 255);
            internal static readonly Color CommonSelected = Color.FromArgb(189, 227, 255);

            internal static readonly Color CharaInit = Color.FromArgb(242, 71, 33);
            internal static readonly Color CharaInitSelected = Color.FromArgb(252, 194, 152);

            internal static readonly Color ADVEnd = Color.FromArgb(242, 71, 33);
            internal static readonly Color ADVEndSelected = Color.FromArgb(252, 194, 152);
        }
        
        private Color _SpecialColor = Color.FromArgb(173, 73, 123);

        public StepItem(StepType stepType)
        {
            InitializeComponent();

            this.Draggable(true, OnDragFinish);
            lblStepName.Draggable(this, true, OnDragFinish);

            SetStepType(stepType);

            UpdateStateColor();

            this.MouseDown += StepItem_MouseDown;
            this.MouseUp += StepItem_MouseUp;
            lblStepName.MouseDown += StepItem_MouseDown;
            lblStepName.MouseUp += StepItem_MouseUp;
            pbTypeIcon.MouseDown += StepItem_MouseDown;
            pbTypeIcon.MouseUp += StepItem_MouseUp;

            StepData = new ADVStep();
            StepData.Type = Util.GetADVStepType(stepType);
            //Assign default waiting type
            StepData.WaitingType = Util.GetDefaultStepWaitingType(stepType);

            if (stepType == StepType.ADVEnd || stepType == StepType.Branch)
            {
                rbStepLink.Visible = false;
            }

            rbStepLink.DragAndDraw(true, OnConnectFinish);
        }


        [Category("_CustomProperty")]
        public string StepText
        {
            get { return lblStepName.Text; }
            set { lblStepName.Text = value; }
        }

        public void UpdateStepText()
        {
            if (!string.IsNullOrEmpty(StepData.Name))
                StepText = StepData.Name;
            else
                StepText = StepData.ID;
        }


        private void StepItem_MouseUp(object? sender, MouseEventArgs e)
        {
            _IsDragging = false;
        }

        private void StepItem_MouseDown(object? sender, EventArgs e)
        {
            _State = State.Selected;
            StepSelected.Invoke(this, Type);
            UpdateStateColor();
        }

        public void SetState(State value)
        {
            _State = value;
            UpdateStateColor();
        }

        public StepType Type
        {
            get { return _StepType; }
            set {  _StepType = value; UpdateStateColor();}
        }

        private void UpdateStateColor()
        {
            if (_StepType == StepType.CharaInit)
            {
                if (_State == State.Normal)
                    BackColor = StepItemColor.CharaInit;
                else if (_State == State.Selected)
                    BackColor = StepItemColor.CharaInitSelected;
            }
            else if (_StepType == StepType.ADVEnd)
            {
                if (_State == State.Normal)
                    BackColor = StepItemColor.ADVEnd; 
                else if (_State == State.Selected)
                    BackColor = StepItemColor.ADVEndSelected;
            }
            else
            {
                if (_State == State.Normal)
                    BackColor = StepItemColor.Common;
                else if (_State == State.Selected)
                    BackColor = StepItemColor.CommonSelected;
            }
        }


        public void SetStepType(StepType type)
        {
            _StepType = type;
            switch (type)
            {
                case StepType.Chara:
                    pbTypeIcon.BackgroundImage = Resources.person_black; break;
                case StepType.Talk:
                    pbTypeIcon.BackgroundImage = Resources.talk_black; break;
                case StepType.CharaInit:
                    pbTypeIcon.BackgroundImage = Resources.start_black; break;
                case StepType.Background:
                    pbTypeIcon.BackgroundImage = Resources.background_black; break;
                case StepType.BGM:
                    pbTypeIcon.BackgroundImage = Resources.bgm_black; break;
                case StepType.SE:
                    pbTypeIcon.BackgroundImage = Resources.se_black; break;
                case StepType.Camera:
                    pbTypeIcon.BackgroundImage = Resources.camera_black; break;
                case StepType.FadeOut:
                    pbTypeIcon.BackgroundImage = Resources.curtain_close_black; break;
                case StepType.FadeIn:
                    pbTypeIcon.BackgroundImage = Resources.curtain_open_black; break;
                case StepType.MakeGroup:
                    pbTypeIcon.BackgroundImage = Resources.group_add_black; break;
                case StepType.DismissGroup:
                    pbTypeIcon.BackgroundImage = Resources.group_remove_black; break;
                case StepType.GroupMotion:
                    pbTypeIcon.BackgroundImage = Resources.group_action_black; break;
                case StepType.AddObject:
                    pbTypeIcon.BackgroundImage = Resources.object_add_black; break;
                case StepType.RemoveObject:
                    pbTypeIcon.BackgroundImage = Resources.object_remove_black; break;
                case StepType.AddTexture:
                    pbTypeIcon.BackgroundImage = Resources.texture_add_black; break;
                case StepType.RemoveTexture:
                    pbTypeIcon.BackgroundImage = Resources.texture_remove_black; break;
                case StepType.TimeSleep:
                    pbTypeIcon.BackgroundImage = Resources.time_wait_black; break;
                case StepType.ShowOption:
                    pbTypeIcon.BackgroundImage = Resources.question_black; break;
                case StepType.Evaluate:
                    pbTypeIcon.BackgroundImage = Resources.eval_black; break;
                case StepType.Branch:
                    pbTypeIcon.BackgroundImage = Resources.branching_black; break;
                case StepType.ADVEnd:
                    pbTypeIcon.BackgroundImage = Resources.stop_black; break;
            }
        }


        private void OnDragFinish()
        {
            //Prevent the item move outside boundary
            int x = Math.Max(0, this.Location.X);
            int y = Math.Max(0, this.Location.Y);
            this.Location = new Point(x, y);
        }

        private void OnConnectFinish()
        {
            ConnectStepFinished.Invoke(this, new EventArgs());

        }

        public void SetDragStatus(bool value)
        {
            _IsDragging = value;
        }

        private void rbStepLink_MouseUp(object sender, MouseEventArgs e)
        {
            Debug.WriteLine(e.Location.ToString());
            rbStepLink.Checked = IsStepLinked();
        }

        private bool IsStepLinked()
        {
            return StepData.ConnectionList.Count > 0;
        }

        internal Point GetBorderPoint(ADVStep.ConnectionPoint pointType)
        {
            Point result = this.Location;
            switch (pointType)
            {
                case ADVStep.ConnectionPoint.TopMiddle:
                    result.X += this.Width / 2;
                    break;
                case ADVStep.ConnectionPoint.TopRight:
                    result.X += this.Width;
                    break;
                case ADVStep.ConnectionPoint.MiddleLeft:
                    result.Y += this.Height / 2;
                    break;
                case ADVStep.ConnectionPoint.MiddleRight:
                    result.X += this.Width;
                    result.Y += this.Height / 2;
                    break;
                case ADVStep.ConnectionPoint.BottomLeft:
                    result.Y += this.Height;
                    break;
                case ADVStep.ConnectionPoint.BottomMiddle:
                    result.X += this.Width / 2;
                    result.Y += this.Height;
                    break;
                case ADVStep.ConnectionPoint.BottomRight:
                    result.X += this.Width;
                    result.Y += this.Height;
                    break;
                default:
                    break;
            }

            return result;
        }

        public void SetConnectionVisible(StepItem target, bool isVisible)
        {
            //TODO: would have problem if it is branching case?
            foreach (var c in StepData.ConnectionList)
            {
                if (c.TargetStepID == target.StepData.ID)
                {
                    c.IsDraw = isVisible;
                }
            }
        }

        public void RemoveConnectionByTarget(StepItem target)
        {
            //TODO: would have problem if it is branching case?
            var toRemove = StepData.ConnectionList.Where(x => x.TargetStepID == target.StepData.ID).ToList();
            foreach(var c in toRemove)
                StepData.ConnectionList.Remove(c);

            UpdateConnectionDotStatus();
        }

        public void RemoveConnectionByID(int ConnectionID)
        {
            //TODO: would have problem if it is branching case?
            var toRemove = StepData.ConnectionList.Where(x => x.ID == ConnectionID).ToList();
            foreach (var c in toRemove)
                StepData.ConnectionList.Remove(c);

            UpdateConnectionDotStatus();
        }

        internal void SetConnection(StepItem target)
        {
            ADVStep.ConnectionPoint[] shortestBorderPoints = Util.GetShortestConnectionPoint(this, target);

            SetConnection(target, shortestBorderPoints[0], shortestBorderPoints[1]);            
        }

        internal void SetConnection(StepItem target, ADVStep.ConnectionPoint fromPoint, ADVStep.ConnectionPoint toPoint, int selectedLineID = -1)
        {
            if (Type != StepType.Branch)
            {
                StepData.ConnectionList.Clear();

                

                ADVStep.GraphConnection connection = new ADVStep.GraphConnection();
                connection.ID = GetNewConectionID();
                connection.TargetStepID = target.StepData.ID;
                connection.From = fromPoint;
                connection.To = toPoint;
                StepData.ConnectionList.Add(connection);
                StepData.NextStepID = target.StepData.ID;
                UpdateConnectionDotStatus();
            }
            else
            {
                if (selectedLineID > 0)
                {
                    var oldConnection = StepData.ConnectionList.Where(x => x.ID == selectedLineID).First();
                    StepData.ConnectionList.Remove(oldConnection);
                }

                ADVStep.GraphConnection connection = new ADVStep.GraphConnection();
                connection.ID = GetNewConectionID();
                connection.TargetStepID = target.StepData.ID;
                connection.From = fromPoint;
                connection.To = toPoint;
                StepData.ConnectionList.Add(connection);
                UpdateConnectionDotStatus();
            }
        }

        public void UpdateConnectionDotStatus()
        {
            rbStepLink.Checked = IsStepLinked();
        }

        public int GetNewConectionID()
        {
            int id = 1;

            if (StepData.ConnectionList.Count > 0)
                id = StepData.ConnectionList.Max(x => x.ID) + 1;

            return id;
        }

        private void StepItem_Load(object sender, EventArgs e)
        {

        }



        public enum State
        {
            Normal,
            Selected
        }

        public enum StepType
        {
            CharaInit,
            Chara,
            Talk,
            Background,
            BGM,
            SE,
            Camera,
            FadeOut,
            FadeIn,
            MakeGroup,
            DismissGroup,
            GroupMotion,
            AddObject,
            RemoveObject,
            AddTexture,
            RemoveTexture,
            TimeSleep,
            Branch,
            ShowOption,
            Evaluate,

            ADVEnd,
        }

        

    }
}
