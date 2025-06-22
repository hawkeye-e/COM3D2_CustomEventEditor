using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    public partial class ADVEndStep : StepEditBase
    {
        public ADVEndStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {
            if (_StepData == null)
                return;
        }


        internal void LoadData(ADVStep stepData)
        {
           _StepData = stepData;
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }
    }




}
