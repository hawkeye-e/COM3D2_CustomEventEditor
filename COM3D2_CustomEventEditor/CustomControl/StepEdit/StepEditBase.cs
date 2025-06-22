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
using System.Xml;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<StepEditBase, UserControl>))]
    public abstract partial class StepEditBase : UserControl, ILocalizable
    {
        internal ADVStep _StepData;
        protected ToolTip _ErrorToolTip;

        public StepEditBase()
        {
            InitializeComponent();
            this.Load += StepEditBase_Load;
        }

        private void StepEditBase_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            Controls.LocalizeCollection();
        }

        public void SetTextBoxDefaultBackColor()
        {
            foreach (Control c in Controls)
            {
                c.BackColor = BackColor;
            }
        }

        public void RecurSetTextBoxDefaultBackColor(Control c)
        {
            foreach (Control child in c.Controls)
            {
                c.BackColor = BackColor;
                RecurSetTextBoxDefaultBackColor(child);
            }
        }

        public abstract void SaveData();
        public abstract void ReloadData();

        private void StepEditBase_VisibleChanged(object sender, EventArgs e)
        {
            //If the control turns invisible, it should save its data
            if (!Visible)
                SaveData();
        }

        public void RemoveToolTip()
        {
            if (_ErrorToolTip != null)
                _ErrorToolTip.Dispose();
        }

    }
}
