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
    public partial class FadingStep : StepEditBase
    {

        private bool _isInit = true;
        public FadingStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.FadeData == null)
                return;

            rbFadeOut.Checked = _StepData.FadeData.IsFadeOut;
            rbFadeIn.Checked = _StepData.FadeData.IsFadeIn;
            txtFadeDuration.Texts = _StepData.FadeData.Time.ToString();
            if (!string.IsNullOrEmpty(_StepData.FadeData.ColorString))
                txtFadeColor.Texts = "#" + _StepData.FadeData.ColorString;
        }


        internal void LoadData(ADVStep stepData)
        {
            _isInit = true;
            rbFadeOut.Checked = true;
            txtFadeDuration.Texts = Constant.DefaultFadeTime.ToString();
            txtFadeColor.Texts = "";

            _StepData = stepData;
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();

            _isInit = false;
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.Fade newData = new ADVStep.Fade();
            newData.IsFadeOut = rbFadeOut.Checked;
            newData.IsFadeIn = rbFadeIn.Checked;
            float.TryParse(txtFadeDuration.Texts, System.Globalization.CultureInfo.InvariantCulture, out newData.Time);
            newData.ColorString = txtFadeColor.Texts.Trim('#');
            
            _StepData.FadeData = newData;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        public void FadeTypeUpdate()
        {
            StepItem.StepType stepType = rbFadeOut.Checked ? StepItem.StepType.FadeOut : StepItem.StepType.FadeIn;
            var stepItem = Global.AllSteps.Where(x => x.StepData == _StepData).First();
            stepItem.SetStepType(stepType);
        }

        private void rbFadeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;
            _StepData.Type = Constant.ADVType.FadeOut;
            ucBasicStepInfo.WaitingType = Constant.WaitingType.FadeOut;
            FadeTypeUpdate();
        }

        private void rbFadeIn_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;
            _StepData.Type = Constant.ADVType.FadeIn;
            ucBasicStepInfo.WaitingType = Constant.WaitingType.Auto;
            FadeTypeUpdate();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFadeColor.Texts = "#"
                    + colorDialog1.Color.A.ToString("X2")
                    + colorDialog1.Color.R.ToString("X2")
                    + colorDialog1.Color.G.ToString("X2")
                    + colorDialog1.Color.B.ToString("X2");
            }
        }
    }




}
