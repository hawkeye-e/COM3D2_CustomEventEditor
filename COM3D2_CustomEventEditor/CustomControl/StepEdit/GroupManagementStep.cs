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
    public partial class GroupManagementStep : StepEditBase
    {
        List<ADVStep.MakeGroupFormat> _MakeGroupResult = new List<ADVStep.MakeGroupFormat>();
        private bool _isInit = true;

        public GroupManagementStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
           
            rbMakeGroup.Checked = _StepData.Type == Constant.ADVType.MakeGroup;
            rbDismissGroup.Checked = _StepData.Type == Constant.ADVType.DismissGroup;

            if (rbMakeGroup.Checked)
            {
                if (_StepData.GroupFormat == null)
                    return;

                _MakeGroupResult = _StepData.GroupFormat;
                lblMakeGroupCountValue.Text = _StepData.GroupFormat.Count.ToString();
            }
            else
            {
                rbDismissAll.Checked = _StepData.Tag == Constant.GroupFormatType.All;
                rbDismissByGroupIndex.Checked = _StepData.Tag != Constant.GroupFormatType.All;
                _StepData.GroupFormat = null;
                if (rbDismissByGroupIndex.Checked)
                {
                    int.TryParse(_StepData.Tag, out int index);
                    cbListIndex.SelectedIndex = index;
                }
            }

            UpdatePanelVisibility();
            UpdateDismissGroupPanelVisibility();
        }


        internal void LoadData(ADVStep stepData)
        {
            _isInit = true;
            _MakeGroupResult = null;

            rbMakeGroup.Checked = true;
            rbDismissAll.Checked = true;
            lblMakeGroupCountValue.Text = "0";
            cbListIndex.SelectedIndex = 0;
            UpdatePanelVisibility();
            UpdateDismissGroupPanelVisibility();

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

            if (rbMakeGroup.Checked)
            {
                //Make Group
                _StepData.GroupFormat = _MakeGroupResult;
            }
            else
            {
                //Dismiss Group
                if (rbDismissAll.Checked)
                    _StepData.Tag = Constant.GroupFormatType.All;
                else 
                    _StepData.Tag =  cbListIndex.SelectedIndex.ToString();
            }

        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        public void GroupManagementTypeUpdate()
        {
            StepItem.StepType stepType = rbMakeGroup.Checked ? StepItem.StepType.MakeGroup : StepItem.StepType.DismissGroup;
            var stepItem = Global.AllSteps.Where(x => x.StepData == _StepData).First();
            stepItem.SetStepType(stepType);


        }

        private void UpdatePanelVisibility()
        {
            pnlMakeGroup.Visible = rbMakeGroup.Checked;
            pnlDismissGroup.Visible = rbDismissGroup.Checked;
        }

        private void rbMakeGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;

            _StepData.Type = Constant.ADVType.MakeGroup;
            GroupManagementTypeUpdate();
            UpdatePanelVisibility();
        }

        private void rbDismissGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;

            _StepData.Type = Constant.ADVType.DismissGroup;
            GroupManagementTypeUpdate();
            UpdatePanelVisibility();
        }

        private void btnMakeGroup_Click(object sender, EventArgs e)
        {
            MakeGroupForm form = new MakeGroupForm(_StepData);
            form.OnFormCompleted += MakeGroupForm_OnFormCompleted;
            form.ShowDialog();
        }

        private void MakeGroupForm_OnFormCompleted(List<ADVStep.MakeGroupFormat> result)
        {
            _MakeGroupResult = result;
            SaveData();
            lblMakeGroupCountValue.Text = _MakeGroupResult.Count.ToString();
        }

        private void UpdateDismissGroupPanelVisibility()
        {
            pnlByIndex.Visible = rbDismissByGroupIndex.Checked;
        }

        private void rbDismissAll_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDismissGroupPanelVisibility();
        }

        private void rbDismissByGroupIndex_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDismissGroupPanelVisibility();
        }
    }




}
