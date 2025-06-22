using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor
{
    public partial class GroupMotionIndividualForm : Form, ILocalizable
    {

        internal delegate void FormUpdateCompleteEventHandler(Constant.GroupMemberType type, ADVStep.ShowGroupMotion.DetailSetup result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;

        private bool IsCurrentTargetTypeMan;
        private Constant.GroupMemberType CurrentMemberType;

        private static readonly List<ComboBoxData> EyeSightCameraType = new List<ComboBoxData>()
        {
            new ComboBoxData( Enum.GetName(EyeSightSetting.EyeToCameraMoveType.Ignore), Util.GetResourcesString("EyeSightCameraType_Ignore")),
            new ComboBoxData( Enum.GetName(EyeSightSetting.EyeToCameraMoveType.LookAt), Util.GetResourcesString("EyeSightCameraType_MoveFaceOnly")),
            new ComboBoxData( Enum.GetName(EyeSightSetting.EyeToCameraMoveType.MoveFaceOnly), Util.GetResourcesString("EyeSightCameraType_FaceTowardsOnly")),
            new ComboBoxData( Enum.GetName(EyeSightSetting.EyeToCameraMoveType.AvoidFace), Util.GetResourcesString("EyeSightCameraType_TurnAway")),
            new ComboBoxData( Enum.GetName(EyeSightSetting.EyeToCameraMoveType.FaceAndEye), Util.GetResourcesString("EyeSightCameraType_LookAtCamera")),
            new ComboBoxData( Enum.GetName(EyeSightSetting.EyeToCameraMoveType.EyeOnly), Util.GetResourcesString("EyeSightCameraType_MoveEyeballOnly")),
            new ComboBoxData( Enum.GetName(EyeSightSetting.EyeToCameraMoveType.AvoidEye), Util.GetResourcesString("EyeSightCameraType_EyeballAvoidEyeContact")),
        };

        public static readonly List<ComboBoxData> EyeSightTargetTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.ClubOwner), Util.GetResourcesString("TargetTypeOwner")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.Maid), Util.GetResourcesString("TargetTypeMaid")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.Man), Util.GetResourcesString("TargetTypeMan")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCFemale), Util.GetResourcesString("TargetTypeNPCFemale")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCMale), Util.GetResourcesString("TargetTypeNPCMale")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.GroupMember), Util.GetResourcesString("TargetTypeGroupMember")),
        };

        public static readonly List<ComboBoxData> GroupMemberTargetTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Enum.GetName(EyeSightSetting.GroupMemberType.Maid1), Util.GetResourcesString("GroupMemberTypeMaid1")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.GroupMemberType.Maid2), Util.GetResourcesString("GroupMemberTypeMaid2")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.GroupMemberType.Man1), Util.GetResourcesString("GroupMemberTypeMan1")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.GroupMemberType.Man2), Util.GetResourcesString("GroupMemberTypeMan2")),
            new ComboBoxData(Enum.GetName(EyeSightSetting.GroupMemberType.Man3), Util.GetResourcesString("GroupMemberTypeMan3")),
        };

        internal GroupMotionIndividualForm(ADVStep.ShowGroupMotion.DetailSetup data, Constant.GroupMemberType type, bool isMan)
        {
            InitializeComponent();
            this.Load += GroupMotionIndividualForm_Load;
            switch (type)
            {
                case Constant.GroupMemberType.Maid1:
                    lblIndividualType.Text = Util.GetResourcesString("GroupMemberTypeMaid1"); break;
                case Constant.GroupMemberType.Maid2:
                    lblIndividualType.Text = Util.GetResourcesString("GroupMemberTypeMaid2"); break;
                case Constant.GroupMemberType.Man1:
                    lblIndividualType.Text = Util.GetResourcesString("GroupMemberTypeMan1"); break;
                case Constant.GroupMemberType.Man2:
                    lblIndividualType.Text = Util.GetResourcesString("GroupMemberTypeMan2"); break;
                case Constant.GroupMemberType.Man3:
                    lblIndividualType.Text = Util.GetResourcesString("GroupMemberTypeMan3"); break;
            }

            InitDropDown();

            IsCurrentTargetTypeMan = isMan;
            CurrentMemberType = type;

            ResetStatusData();
            ResetCoordinatesData();
            ResetEyeSightData();


            InitControl(data);

            UpdateStatusItemVisibility();
            UpdateCoordinatesVisibility();
            UpdateEyeSightPanelVisibility();
            UpdateEyeSightCharacterPanelVisibility();
            UpdateFaceBlendTrackerBarEnabledStatus();
        }

        private void InitDropDown()
        {
            cbEyeSightCameraType.DataSource = EyeSightCameraType;
            cbEyeSightCameraType.SelectedValue = Enum.GetName(EyeSightSetting.EyeToCameraMoveType.FaceAndEye);

            cbEyeSightCharacterType.DataSource = EyeSightTargetTypeList;
            cbEyeSightCharacterType.SelectedIndex = 0;

            Util.SetupIndexPositionComboBox(cbGroupIndex, 20);
            cbGroupIndex.SelectedIndex = 0;

            cbGroupTarget.DataSource = GroupMemberTargetTypeList;
            cbGroupTarget.SelectedIndex = 0;
        }

        private void InitControl(ADVStep.ShowGroupMotion.DetailSetup data)
        {
            if (data == null)
                return;

            InitStatusData(data);
            InitCoordinatesData(data);
            InitEyeSightData(data);
        }

        private void InitStatusData(ADVStep.ShowGroupMotion.DetailSetup data)
        {
            chkVisible.Checked = data.Visible;
            if (IsCurrentTargetTypeMan)
            {
                chkManNude.Checked = data.IsManNude;
            }
            else
            {
                chkOpenMouth.Checked = data.OpenMouth;
                txtFaceAnim.Texts = data.FaceAnime;
                if (!string.IsNullOrEmpty(data.FaceBlend))
                {
                    var match = Regex.Match(data.FaceBlend, Constant.FaceBlendStringFormat);
                    if (match.Success)
                    {
                        chkFaceBlend.Checked = true;
                        tbBlushing.Value = Util.ConvertFullTypeStringToNumber(match.Groups[1].Value);
                        tbTearLevel.Value = Util.ConvertFullTypeStringToNumber(match.Groups[2].Value);
                    }
                }
                else
                {
                    chkFaceBlend.Checked = false;
                    tbBlushing.Value = 0;
                    tbTearLevel.Value = 0;
                }
            }
        }

        private void ResetStatusData()
        {
            chkVisible.Checked = true;
            chkManNude.Checked = false;
            chkOpenMouth.Checked = false;
            txtFaceAnim.Texts = "";
            chkFaceBlend.Checked = false;
            tbBlushing.Value = 0;
            tbTearLevel.Value = 0;
        }

        private void InitCoordinatesData(ADVStep.ShowGroupMotion.DetailSetup data)
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

        private void InitEyeSightData(ADVStep.ShowGroupMotion.DetailSetup data)
        {


            if (data.EyeSight != null)
            {
                chkEyeSightUpdate.Checked = true;
                if (data.EyeSight.EyeToCameraSetting != null)
                {
                    rbEyeSightCamera.Checked = true;
                    cbEyeSightCameraType.SelectedValue = data.EyeSight.EyeToCameraSetting.MoveType.ToString();
                }

                if (data.EyeSight.EyeToCharaSetting != null)
                {
                    rbEyeSightCharacter.Checked = true;
                    cbEyeSightCharacterType.SelectedValue = data.EyeSight.EyeToCharaSetting.Type.ToString();
                    if (data.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.Maid
                       || data.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.Man
                       || data.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCFemale
                       || data.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCMale
                       )
                    {
                        cbEyeSightCharaPosition.SelectedIndex = data.EyeSight.EyeToCharaSetting.ArrayPosition;
                    }
                    else if (data.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.GroupMember)
                    {
                        cbGroupIndex.SelectedIndex = data.EyeSight.EyeToCharaSetting.ArrayPosition;
                        cbGroupTarget.SelectedValue = Enum.GetName(data.EyeSight.EyeToCharaSetting.TargetGroupMember);
                    }
                }
            }
        }

        private void ResetEyeSightData()
        {
            chkEyeSightUpdate.Checked = false;
            rbEyeSightCamera.Checked = true;
            cbEyeSightCameraType.SelectedIndex = 0;
            cbEyeSightCharacterType.SelectedIndex = 0;
            cbEyeSightCharaPosition.SelectedIndex = -1;
            cbGroupIndex.SelectedIndex = 0;
            cbGroupTarget.SelectedIndex = 0;
        }



        private void GroupMotionIndividualForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("GroupMotionIndvFormWindowName");
            
            Controls.LocalizeCollection();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var result = GetResultObject();

            //signal the main form to update
            if (OnFormCompleted != null)
                OnFormCompleted.Invoke(CurrentMemberType, result);

            this.Close();
        }

        internal ADVStep.ShowGroupMotion.DetailSetup GetResultObject()
        {
            ADVStep.ShowGroupMotion.DetailSetup result = new ADVStep.ShowGroupMotion.DetailSetup();

            SaveStatusData(result);
            SaveCoordinatesData(result);
            SaveEyeSightData(result);

            return result;
        }

        private void SaveStatusData(ADVStep.ShowGroupMotion.DetailSetup newData)
        {
            newData.Visible = chkVisible.Checked;
            if (IsCurrentTargetTypeMan)
            {
                newData.IsManNude = chkManNude.Checked;
            }
            else
            {
                newData.OpenMouth = chkOpenMouth.Checked;
                if (!string.IsNullOrEmpty(txtFaceAnim.Texts))
                    newData.FaceAnime = txtFaceAnim.Texts;
                if (chkFaceBlend.Checked)
                {
                    newData.FaceBlend = Constant.BlushingWord + Util.ConvertNumberToFullTypeString(tbBlushing.Value)
                        + Constant.TearWord + Util.ConvertNumberToFullTypeString(tbTearLevel.Value);
                }
            }
        }

        private void SaveCoordinatesData(ADVStep.ShowGroupMotion.DetailSetup newData)
        {
            if (!chkCoordinateChange.Checked)
                return;

            newData.PosRot = new PosRot();
            newData.PosRot.PosString = txtCoordinatesPos.Texts;
            newData.PosRot.RotString = txtCoordinatesRot.Texts;
        }

        private void SaveEyeSightData(ADVStep.ShowGroupMotion.DetailSetup newData)
        {
            if (!chkEyeSightUpdate.Checked)
                return;

            newData.EyeSight = new EyeSightSetting();
            if (rbEyeSightCamera.Checked)
            {
                newData.EyeSight.Type = EyeSightSetting.EyeSightType.ToCamera;
                newData.EyeSight.EyeToCameraSetting = new EyeSightSetting.EyeToCameraSettingDetail();
                Enum.TryParse(cbEyeSightCameraType.SelectedValue.ToString(), out newData.EyeSight.EyeToCameraSetting.MoveType);
            }
            else if (rbEyeSightCharacter.Checked)
            {
                newData.EyeSight.Type = EyeSightSetting.EyeSightType.ToChara;
                newData.EyeSight.EyeToCharaSetting = new EyeSightSetting.EyeToCharaSettingDetail();
                Enum.TryParse(cbEyeSightCharacterType.SelectedValue.ToString(), out newData.EyeSight.EyeToCharaSetting.Type);

                if (newData.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.Maid
                    || newData.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.Man
                    || newData.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCFemale
                    || newData.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCMale
                    )
                {
                    newData.EyeSight.EyeToCharaSetting.ArrayPosition = cbEyeSightCharaPosition.SelectedIndex;
                }
                else if (newData.EyeSight.EyeToCharaSetting.Type == EyeSightSetting.EyeToCharaSettingDetail.TargetType.GroupMember)
                {
                    newData.EyeSight.EyeToCharaSetting.ArrayPosition = cbGroupIndex.SelectedIndex;
                    Enum.TryParse(cbGroupTarget.SelectedValue.ToString(), out newData.EyeSight.EyeToCharaSetting.TargetGroupMember);
                }
            }
        }

        private void UpdateStatusItemVisibility()
        {
            //Checkbox visibility
            chkManNude.Visible = IsCurrentTargetTypeMan;
            chkOpenMouth.Visible = !IsCurrentTargetTypeMan;
            //panel visibility
            pnlFemaleFaceStatus.Visible = !IsCurrentTargetTypeMan;
        }


        private void chkCoordinateChange_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCoordinatesVisibility();
        }

        private void UpdateCoordinatesVisibility()
        {
            pnlCoordinates.Visible = chkCoordinateChange.Checked;
        }

        private void chkEyeSightUpdate_CheckedChanged(object sender, EventArgs e)
        {
            pnlEyeSightUpdate.Visible = chkEyeSightUpdate.Checked;
        }

        private void UpdateEyeSightPanelVisibility()
        {
            pnlEyeSightCamera.Visible = rbEyeSightCamera.Checked;
            pnlEyeSightCharacter.Visible = rbEyeSightCharacter.Checked;
        }

        private void rbEyeSightCamera_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEyeSightPanelVisibility();
        }

        private void rbEyeSightCharacter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEyeSightPanelVisibility();
        }

        private void cbEyeSightCharacterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEyeSightCharacterPanelVisibility();

            int listItemCount = 0;
            if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.ClubOwner))
            {
                //do nothing
            }
            else if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.GroupMember))
            {
                //no way to keep track how many groups in this step, no need to alter the combo box
            }
            else if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.Maid))
            {
                if (Global.ScenarioDefinition.MaidRequirement != null)
                    listItemCount = Global.ScenarioDefinition.MaidRequirement.Count;
            }
            else
            {
                ADVStep charaInitStepData = Global.AllSteps.Where(x => x.Type == StepItem.StepType.CharaInit).First().StepData;
                if (charaInitStepData != null && charaInitStepData.CharaInitData != null)
                {
                    if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.Man))
                        listItemCount = charaInitStepData.CharaInitData.ManRequired;
                    else if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCFemale))
                    {
                        if (charaInitStepData.CharaInitData.NPCFemale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCFemale.Count;
                    }
                    else if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.NPCMale))
                    {
                        if (charaInitStepData.CharaInitData.NPCMale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCMale.Count;
                    }

                }

            }
            Util.SetupIndexPositionComboBox(cbEyeSightCharaPosition, listItemCount);
        }

        private void UpdateEyeSightCharacterPanelVisibility()
        {
            if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.ClubOwner))
            {
                pnlEyeSightCharaPosition.Visible = false;
                pnlEyeSightGroupMember.Visible = false;
            }
            else if (cbEyeSightCharacterType.SelectedValue.ToString() == Enum.GetName(EyeSightSetting.EyeToCharaSettingDetail.TargetType.GroupMember))
            {
                pnlEyeSightCharaPosition.Visible = false;
                pnlEyeSightGroupMember.Visible = true;
            }
            else
            {
                pnlEyeSightCharaPosition.Visible = true;
                pnlEyeSightGroupMember.Visible = false;
            }
        }

        private void chkFaceBlend_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFaceBlendTrackerBarEnabledStatus();
        }

        private void UpdateFaceBlendTrackerBarEnabledStatus()
        {
            tbBlushing.Enabled = chkFaceBlend.Checked;
            tbTearLevel.Enabled = chkFaceBlend.Checked;
        }

        private void tbBlushing_ValueChanged(object sender, EventArgs e)
        {
            lblBlushingLevelValue.Text = tbBlushing.Value.ToString();
        }

        private void tbTearLevel_ValueChanged(object sender, EventArgs e)
        {
            lblTearLevelValue.Text = tbTearLevel.Value.ToString();
        }
    }
}

