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
    public partial class SEStep : StepEditBase
    {
        public SEStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.SEData == null)
                return;

            txtFileName.Texts = _StepData.SEData.FileName;
            chkLoop.Checked = _StepData.SEData.IsLoop;
            chkStopSE.Checked = _StepData.SEData.Stop;
            
        }


        internal void LoadData(ADVStep stepData)
        {
            txtFileName.Texts = "";
            chkStopSE.Checked = false;
            chkLoop.Checked = false;

           _StepData = stepData;
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.SE newData = new ADVStep.SE();

            newData.FileName = txtFileName.Texts;
            newData.IsLoop = chkLoop.Checked;
            newData.Stop = chkStopSE.Checked;

            _StepData.SEData = newData;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }
    }




}
