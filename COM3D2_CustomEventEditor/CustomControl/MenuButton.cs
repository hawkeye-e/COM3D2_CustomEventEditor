using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Resources;

namespace COM3D2_CustomEventEditor
{
    public partial class MenuButton : UserControl, ILocalizable
    {
        private Color _NormalColor = Color.FromArgb(24, 104, 170);
        private Color _HoverColor = Color.FromArgb(33, 150, 243);

        public MenuButton()
        {
            InitializeComponent();
            this.Load += AddStepButton_Load;
        }

        private void AddStepButton_Load(object? sender, EventArgs e) => Localize();

        [Browsable(true)]
        [Category("_CustomProperty")]
        public string? TextResourceKey { get; set; }

        public void Localize()
        {

            ResourceManager rm = new ResourceManager(typeof(Properties.Resources));
            if (!string.IsNullOrWhiteSpace(TextResourceKey))
                lblText.Text = rm.GetString(TextResourceKey, System.Globalization.CultureInfo.CurrentCulture);

            Controls.LocalizeCollection();
        }


        private void AddStepButton_MouseHover(object sender, EventArgs e)
        {
            BackColor = _HoverColor;
        }

        private void AddStepButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = _NormalColor;
        }

        [Category("_CustomProperty")]
        public string ButtonText
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("_CustomProperty")]
        public Image Icon
        {
            get { return pbIcon.BackgroundImage; }
            set { pbIcon.BackgroundImage = value; }
        }

        [Category("_CustomEvent")]
        public event MouseEventHandler ButtonClicked
        {
            add { 
                this.MouseClick += value;
                lblText.MouseClick += value;
                pbIcon.MouseClick += value;
            }
            remove {
                this.MouseClick -= value;
                lblText.MouseClick -= value;
                pbIcon.MouseClick -= value;
            }
        }

    }
}
