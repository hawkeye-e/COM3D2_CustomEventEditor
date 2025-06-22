using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM3D2_CustomEventEditor
{
    public class ComboBoxData
    {
        public string DataKey { get; set; }
        public string DisplayText { get; set; }

        public ComboBoxData(string code, string text)
        {
            this.DataKey = code;
            this.DisplayText = text;
        }
    }
}
