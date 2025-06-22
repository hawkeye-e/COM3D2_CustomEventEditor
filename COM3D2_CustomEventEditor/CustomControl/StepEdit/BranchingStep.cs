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
    public partial class BranchingStep : StepEditBase
    {
        public BranchingStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.BranchData == null)
                return;

            UpdateBranchNumber();
        }


        internal void LoadData(ADVStep stepData)
        {
            lblBranchCountValue.Text = "0";

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

        private void btnEditBranch_Click(object sender, EventArgs e)
        {
            BranchingForm form = new BranchingForm(_StepData);
            form.OnFormCompleted += BranchingForm_OnFormCompleted;
            form.ShowDialog();
        }


        private void BranchingForm_OnFormCompleted(ADVStep.Branch result)
        {
            _StepData.BranchData = result;
            SaveData();
            UpdateBranchNumber();

            //Update the connection list
            _StepData.ConnectionList = new List<ADVStep.GraphConnection>();
            var thisStepItem = Global.AllSteps.Where(x => x.StepData.ID == this._StepData.ID).First();
            foreach (var branch in result.BranchList)
            {
                //search the step id
                var targetStepItem = Global.AllSteps.Where(x => x.StepData.ID == branch.NextStepID).FirstOrDefault();
                if (targetStepItem != null)
                {
                    thisStepItem.SetConnection(targetStepItem);
                }
            }
            //clear the next step id as branch step doesnt use it
            Global.Canvas.Redraw();
        }

        private void UpdateBranchNumber()
        {
            lblBranchCountValue.Text = _StepData.BranchData?.BranchList?.Count.ToString();
        }
    }




}
