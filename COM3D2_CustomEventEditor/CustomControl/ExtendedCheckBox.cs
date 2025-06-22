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
    public partial class ExtendedCheckBox : CheckBox, ILocalizable
    {
        public ExtendedCheckBox()
        {
            InitializeComponent();
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
    }
}
