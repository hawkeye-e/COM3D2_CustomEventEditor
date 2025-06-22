using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl
{
    public partial class ExtendedGroupBox : GroupBox, ILocalizable
    {
        private static readonly Color _CustomBorderColor = Color.FromArgb(105, 105, 105);

        public ExtendedGroupBox()
        {
            InitializeComponent();
            this.Paint += ExtendedGroupBox_Paint;
        }

        [Browsable(true)]
        [Category("_CustomProperty")]
        public string? TextResourceKey { get; set; }

        public void Localize()
        {
            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));
            if (!string.IsNullOrWhiteSpace(TextResourceKey))
                Text = rm.GetString(TextResourceKey, System.Globalization.CultureInfo.CurrentCulture);
        }


        //To draw the border color with defined color
        private void ExtendedGroupBox_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.DimGray, _CustomBorderColor);
        }
        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }
    }
}
