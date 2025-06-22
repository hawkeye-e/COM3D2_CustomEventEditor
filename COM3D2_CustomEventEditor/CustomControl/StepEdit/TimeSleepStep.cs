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
    public partial class TimeSleepStep : StepEditBase
    {
        public TimeSleepStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;

            txtSleepValue.Texts = _StepData.Tag;

        }


        internal void LoadData(ADVStep stepData)
        {
            txtSleepValue.Texts = "";

            _StepData = stepData;
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            _StepData.Tag = txtSleepValue.Texts;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }
    }




}
