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
    public partial class ShowOptionStep : StepEditBase
    {
        private List<ADVStep.Choice.ChoiceOption> _ChoiceList = new List<ADVStep.Choice.ChoiceOption>();

        public ShowOptionStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.ChoiceData == null)
                return;

            txtVariableName.Texts = _StepData.ChoiceData.Variable;
            _ChoiceList = _StepData.ChoiceData.Options;

            UpdateChoiceNumber();

        }


        internal void LoadData(ADVStep stepData)
        {
            txtVariableName.Texts = "";
            lblOptionCountValue.Text = "0";

            _StepData = stepData;
            _ChoiceList = new List<ADVStep.Choice.ChoiceOption>();

            ucBasicStepInfo.LoadData(stepData);
            InitControlData();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.Choice newData = new ADVStep.Choice();
            newData.Variable = txtVariableName.Texts;
            newData.Options = _ChoiceList;

            _StepData.ChoiceData = newData;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        private void btnEditOption_Click(object sender, EventArgs e)
        {
            OptionForm form = new OptionForm(_StepData);
            form.OnFormCompleted += OptionForm_OnFormCompleted;
            form.ShowDialog();
        }

        private void OptionForm_OnFormCompleted(List<ADVStep.Choice.ChoiceOption> result)
        {
            _ChoiceList = result;
            SaveData();
            UpdateChoiceNumber();
        }

        private void UpdateChoiceNumber()
        {
            lblOptionCountValue.Text = _ChoiceList.Count.ToString();
        }
    }




}
