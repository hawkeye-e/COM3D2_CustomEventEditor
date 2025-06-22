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

namespace COM3D2_CustomEventEditor.CustomControl
{
    public partial class PersonalityList : UserControl, ILocalizable
    {
        public PersonalityList()
        {
            InitializeComponent();
        }

        public void Localize()
        {
            Controls.LocalizeCollection();
        }
    }
}
