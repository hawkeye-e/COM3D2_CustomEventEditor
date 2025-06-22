using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    public partial class GroupMotionStep : StepEditBase
    {
        private ADVStep.ShowGroupMotion.DetailSetup _Maid1Detail;
        private ADVStep.ShowGroupMotion.DetailSetup _Maid2Detail;
        private ADVStep.ShowGroupMotion.DetailSetup _Man1Detail;
        private ADVStep.ShowGroupMotion.DetailSetup _Man2Detail;
        private ADVStep.ShowGroupMotion.DetailSetup _Man3Detail;

        public GroupMotionStep()
        {
            InitializeComponent();
        }

        private void InitDropDown()
        {
            Util.SetupIndexPositionComboBox(cbGroupIndex, 20);
            cbGroupIndex.SelectedIndex = 0;

        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.GroupData == null)
                return;
            if (_StepData.GroupData.Length == 0)
                return;

            cbGroupIndex.SelectedIndex = _StepData.GroupData[0].ArrayPosition;

            InitCoordinatesData(_StepData.GroupData[0]);
            InitMotionData(_StepData.GroupData[0]);
            initIndividualSetupData(_StepData.GroupData[0]);
        }



        private void InitCoordinatesData(ADVStep.ShowGroupMotion data)
        {
            if (data.PosRot != null)
            {
                chkCoordinateChange.Checked = true;
                txtCoordinatesPos.Texts = data.PosRot.PosString;
                txtCoordinatesRot.Texts = data.PosRot.RotString;
            }
        }

        private void ResetCoordinatesData()
        {
            chkCoordinateChange.Checked = false;
            txtCoordinatesPos.Texts = "";
            txtCoordinatesRot.Texts = "";
        }


        private void InitMotionData(ADVStep.ShowGroupMotion data)
        {
            txtScriptFile.Texts = data.ScriptFile;
            txtScriptLabel.Texts = data.ScriptLabel;
            chkBlockClick.Checked = data.BlockInputUntilMotionChange;
        }

        private void ResetMotionData()
        {
            txtScriptFile.Texts = "";
            txtScriptLabel.Texts = "";
            chkBlockClick.Checked = false;
        }

        private void initIndividualSetupData(ADVStep.ShowGroupMotion data)
        {
            chkMaid1Detail.Checked = data.Maid1 != null;
            chkMaid2Detail.Checked = data.Maid2 != null;
            chkMan1Detail.Checked = data.Man1 != null;
            chkMan2Detail.Checked = data.Man2 != null;
            chkMan3Detail.Checked = data.Man3 != null;

            _Maid1Detail = data.Maid1;
            _Maid2Detail = data.Maid2;
            _Man1Detail = data.Man1;
            _Man2Detail = data.Man2;
            _Man3Detail = data.Man3;
        }

        private void ResetIndividualSetupData()
        {
            chkMaid1Detail.Checked = false;
            chkMaid2Detail.Checked = false;
            chkMan1Detail.Checked = false;
            chkMan2Detail.Checked = false;
            chkMan3Detail.Checked = false;
        }



        internal void LoadData(ADVStep stepData)
        {
            _Maid1Detail = null;
            _Maid2Detail = null;
            _Man1Detail = null;
            _Man2Detail = null;
            _Man3Detail = null;

            _StepData = stepData;

            InitDropDown();

            ResetCoordinatesData();
            ResetMotionData();
            ResetIndividualSetupData();

            ucBasicStepInfo.LoadData(stepData);
            InitControlData();

            UpdateCoordinatesVisibility();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.ShowGroupMotion[] newDataArray = new ADVStep.ShowGroupMotion[1];
            ADVStep.ShowGroupMotion newData = new ADVStep.ShowGroupMotion();
            newDataArray[0] = newData;

            newData.ArrayPosition = cbGroupIndex.SelectedIndex;

            //Split into different functions to make it more readible
            SaveCoordinatesData(newData);
            SaveMotionData(newData);

            if (chkMaid1Detail.Checked)
                newData.Maid1 = _Maid1Detail;
            if (chkMaid2Detail.Checked)
                newData.Maid2 = _Maid2Detail;
            if (chkMan1Detail.Checked)
                newData.Man1 = _Man1Detail;
            if (chkMan2Detail.Checked)
                newData.Man2 = _Man2Detail;
            if (chkMan3Detail.Checked)
                newData.Man3 = _Man3Detail;

            _StepData.GroupData = newDataArray;
        }


        private void SaveCoordinatesData(ADVStep.ShowGroupMotion newData)
        {
            if (!chkCoordinateChange.Checked)
                return;

            newData.PosRot = new PosRot();
            newData.PosRot.PosString = txtCoordinatesPos.Texts;
            newData.PosRot.RotString = txtCoordinatesRot.Texts;

        }

        private void SaveMotionData(ADVStep.ShowGroupMotion newData)
        {
            newData.ScriptFile = txtScriptFile.Texts;
            newData.ScriptLabel = txtScriptLabel.Texts;
            newData.BlockInputUntilMotionChange = chkBlockClick.Checked;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }


        private void chkCoordinateChange_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCoordinatesVisibility();
        }

        private void UpdateCoordinatesVisibility()
        {
            pnlCoordinates.Visible = chkCoordinateChange.Checked;
        }

        private void OpenIndividualForm(Constant.GroupMemberType type, bool isMan)
        {
            GroupMotionIndividualForm form = new GroupMotionIndividualForm(GetIndividualSetupData(type), type, isMan);
            form.OnFormCompleted += IndividualForm_OnFormCompleted;
            form.ShowDialog();
        }

        private void IndividualForm_OnFormCompleted(Constant.GroupMemberType type, ADVStep.ShowGroupMotion.DetailSetup result)
        {
            switch (type)
            {
                case Constant.GroupMemberType.Maid1:
                    _Maid1Detail = result;
                    chkMaid1Detail.Checked = true;
                    break;
                case Constant.GroupMemberType.Maid2:
                    _Maid2Detail = result;
                    chkMaid2Detail.Checked = true;
                    break;
                case Constant.GroupMemberType.Man1:
                    _Man1Detail = result;
                    chkMan1Detail.Checked = true;
                    break;
                case Constant.GroupMemberType.Man2:
                    _Man2Detail = result;
                    chkMan2Detail.Checked = true;
                    break;
                case Constant.GroupMemberType.Man3:
                    _Man3Detail = result;
                    chkMan3Detail.Checked = true;
                    break;
            }
        }

        private void btnMaid1Edit_Click(object sender, EventArgs e)
        {
            OpenIndividualForm(Constant.GroupMemberType.Maid1, false);
        }

        private void btnMaid2Edit_Click(object sender, EventArgs e)
        {
            OpenIndividualForm(Constant.GroupMemberType.Maid2, false);
        }

        private void btnMan1Edit_Click(object sender, EventArgs e)
        {
            OpenIndividualForm(Constant.GroupMemberType.Man1, true);
        }

        private void btnMan2Edit_Click(object sender, EventArgs e)
        {
            OpenIndividualForm(Constant.GroupMemberType.Man2, true);
        }

        private void btnMan3Edit_Click(object sender, EventArgs e)
        {
            OpenIndividualForm(Constant.GroupMemberType.Man3, true);
        }

        private ADVStep.ShowGroupMotion.DetailSetup GetIndividualSetupData(Constant.GroupMemberType type)
        {
            if (_StepData == null)
                return null;
            if (_StepData.GroupData == null)
                return null;
            if (_StepData.GroupData.Length == 0)
                return null;

            switch (type)
            {
                case Constant.GroupMemberType.Maid1:
                    return _StepData.GroupData[0].Maid1;
                case Constant.GroupMemberType.Maid2:
                    return _StepData.GroupData[0].Maid2;
                case Constant.GroupMemberType.Man1:
                    return _StepData.GroupData[0].Man1;
                case Constant.GroupMemberType.Man2:
                    return _StepData.GroupData[0].Man2;
                case Constant.GroupMemberType.Man3:
                    return _StepData.GroupData[0].Man3;
                default:
                    return null;
            }

        }

        
    }




}
