using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    public partial class CharaStep : StepEditBase
    {
        public static readonly List<ComboBoxData> TargetTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.TargetType.ClubOwner, Util.GetResourcesString("TargetTypeOwner")),
            new ComboBoxData(Constant.TargetType.SingleMaid, Util.GetResourcesString("TargetTypeMaid")),
            new ComboBoxData(Constant.TargetType.SingleMan,Util.GetResourcesString("TargetTypeMan")),
            new ComboBoxData(Constant.TargetType.NPCFemale,Util.GetResourcesString("TargetTypeNPCFemale")),
            new ComboBoxData(Constant.TargetType.NPCMale,Util.GetResourcesString("TargetTypeNPCMale")),

            new ComboBoxData(Constant.TargetType.AllMaids, Util.GetResourcesString("TargetTypeAllMaid")),
            new ComboBoxData(Constant.TargetType.AllMen,Util.GetResourcesString("TargetTypeAllMan")),
            new ComboBoxData(Constant.TargetType.AllNPCFemale,Util.GetResourcesString("TargetTypeAllNPCFemale")),
            new ComboBoxData(Constant.TargetType.AllNPCMale,Util.GetResourcesString("TargetTypeAllNPCMale")),
        };

        private static readonly List<string> ManTargetType = new List<string>()
        {
            Constant.TargetType.ClubOwner,
            Constant.TargetType.SingleMan,
            Constant.TargetType.NPCMale,
            Constant.TargetType.AllMen,
            Constant.TargetType.AllNPCMale,
        };

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


        public CharaStep()
        {
            InitializeComponent();
        }

        private void InitDropDown()
        {
            cbTargetType.DataSource = TargetTypeList;
            cbTargetType.SelectedIndex = 0;

            cbEyeSightCameraType.DataSource = EyeSightCameraType;
            cbEyeSightCameraType.SelectedValue = Enum.GetName(EyeSightSetting.EyeToCameraMoveType.FaceAndEye);

            cbEyeSightCharacterType.DataSource = EyeSightTargetTypeList;
            cbEyeSightCharacterType.SelectedIndex = 0;

            Util.SetupIndexPositionComboBox(cbGroupIndex, 20);
            cbGroupIndex.SelectedIndex = 0;

            cbGroupTarget.DataSource = GroupMemberTargetTypeList;
            cbGroupTarget.SelectedIndex = 0;
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.CharaData == null)
                return;
            if (_StepData.CharaData.Length == 0)
                return;

            InitTargetData(_StepData.CharaData[0]);
            InitStatusData(_StepData.CharaData[0]);
            InitCoordinatesData(_StepData.CharaData[0]);
            InitMotionData(_StepData.CharaData[0]);
            InitEyeSightData(_StepData.CharaData[0]);
        }

        private void InitTargetData(ADVStep.ShowChara data)
        {
            if (data.IsMaster)
                cbTargetType.SelectedValue = Constant.TargetType.ClubOwner;
            else
                cbTargetType.SelectedValue = data.Type;

            if (cbTargetType.SelectedValue.ToString() == Constant.TargetType.SingleMaid
                || cbTargetType.SelectedValue.ToString() == Constant.TargetType.SingleMan
                || cbTargetType.SelectedValue.ToString() == Constant.TargetType.NPCFemale
                || cbTargetType.SelectedValue.ToString() == Constant.TargetType.NPCMale
                )
            {
                chkUseBranchIndex.Checked = data.UseBranchIndex;

                if (!data.UseBranchIndex)
                    cbListIndex.SelectedIndex = data.ArrayPosition;
            }
        }

        private void ResetTargetData()
        {
            cbTargetType.SelectedValue = Constant.TargetType.ClubOwner;
            chkUseBranchIndex.Checked = false;
            cbListIndex.SelectedIndex = -1;
        }


        private void InitStatusData(ADVStep.ShowChara data)
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


        private void InitCoordinatesData(ADVStep.ShowChara data)
        {
            if (data.PosRot != null)
            {
                chkCoordinateChange.Checked = true;
                txtCoordinatesPos.Texts = data.PosRot.PosString;
                txtCoordinatesRot.Texts = data.PosRot.RotString;

                if (data.SmoothMovement != null)
                {
                    chkSmoothMovement.Checked = true;
                    txtSmoothMovementDuration.Texts = data.SmoothMovement.Time.ToString();
                }
            }
        }

        private void ResetCoordinatesData()
        {
            chkCoordinateChange.Checked = false;
            txtCoordinatesPos.Texts = "";
            txtCoordinatesRot.Texts = "";
            chkSmoothMovement.Checked = false;
            txtSmoothMovementDuration.Texts = "";
        }


        private void InitMotionData(ADVStep.ShowChara data)
        {
            if (data.MotionInfo != null)
            {
                chkMotionUpdate.Checked = true;
                rbMotionScript.Checked = !string.IsNullOrEmpty(data.MotionInfo.ScriptFile) || !string.IsNullOrEmpty(data.MotionInfo.ScriptLabel);
                if (rbMotionScript.Checked)
                {
                    txtScriptFile.Texts = data.MotionInfo.ScriptFile;
                    txtScriptLabel.Texts = data.MotionInfo.ScriptLabel;
                }

                rbAnimationFile.Checked = !string.IsNullOrEmpty(data.MotionInfo.MotionFile);
                if (rbAnimationFile.Checked)
                {
                    txtAnimationFile.Texts = data.MotionInfo.MotionFile;
                }

                chkLoopMotion.Checked = data.MotionInfo.IsLoopMotion;
                chkSmoothMotionTransition.Checked = data.MotionInfo.IsBlend;
            }
        }

        private void ResetMotionData()
        {
            chkMotionUpdate.Checked = false;
            txtScriptFile.Texts = "";
            txtScriptLabel.Texts = "";
            txtAnimationFile.Texts = "";
            chkLoopMotion.Checked = false;
            chkSmoothMotionTransition.Checked = false;
            rbMotionScript.Checked = true;
        }
        

        private void InitEyeSightData(ADVStep.ShowChara data)
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


        internal void LoadData(ADVStep stepData)
        {
            _StepData = stepData;
            InitDropDown();


            ResetTargetData();
            ResetStatusData();
            ResetCoordinatesData();
            ResetMotionData();
            ResetEyeSightData();

            
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();

            UpdateCoordinatesVisibility();
            UpdateSmoothMovementDurationEnabledStatus();
            UpdateMotionPanelVisibility();
            UpdateEyeSightPanelVisibility();
            UpdateEyeSightCharacterPanelVisibility();
            UpdateFaceBlendTrackerBarEnabledStatus();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.ShowChara[] newDataArray = new ADVStep.ShowChara[1];
            ADVStep.ShowChara newData = new ADVStep.ShowChara();
            newDataArray[0] = newData;

            //Split into different functions to make it more readible
            SaveTargetData(newData);
            SaveStatusData(newData);
            SaveCoordinatesData(newData);
            SaveMotionData(newData);
            SaveEyeSightData(newData);

            _StepData.CharaData = newDataArray;
        }

        private void SaveTargetData(ADVStep.ShowChara newData)
        {
            newData.Type = cbTargetType.SelectedValue.ToString();
            if (newData.Type == Constant.TargetType.ClubOwner)
            {
                newData.Type = Constant.TargetType.SingleMan;
                newData.IsMaster = true;
            }
            else if (newData.Type == Constant.TargetType.SingleMaid
                || newData.Type == Constant.TargetType.SingleMan
                || newData.Type == Constant.TargetType.NPCFemale
                || newData.Type == Constant.TargetType.NPCMale
                )
            {
                if (chkUseBranchIndex.Checked)
                    newData.UseBranchIndex = true;
                else
                    newData.ArrayPosition = cbListIndex.SelectedIndex;
            }
        }

        private void SaveStatusData(ADVStep.ShowChara newData)
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

        private void SaveCoordinatesData(ADVStep.ShowChara newData)
        {
            if (!chkCoordinateChange.Checked)
                return;

            newData.PosRot = new PosRot();
            newData.PosRot.PosString = txtCoordinatesPos.Texts;
            newData.PosRot.RotString = txtCoordinatesRot.Texts;
            if (chkSmoothMovement.Checked)
            {
                newData.SmoothMovement = new ADVStep.ShowChara.SmoothMovementSetup();
                float.TryParse(txtSmoothMovementDuration.Texts, System.Globalization.CultureInfo.InvariantCulture, out newData.SmoothMovement.Time);
            }
        }

        private void SaveMotionData(ADVStep.ShowChara newData)
        {
            if (!chkMotionUpdate.Checked)
                return;

            newData.MotionInfo = new MotionInfo();
            if (rbMotionScript.Checked)
            {
                newData.MotionInfo.ScriptFile = txtScriptFile.Texts;
                newData.MotionInfo.ScriptLabel = txtScriptLabel.Texts;
            }
            else if (rbAnimationFile.Checked)
            {
                newData.MotionInfo.MotionFile = txtAnimationFile.Texts;
                newData.MotionInfo.MotionTag = txtAnimationFile.Texts.ToLower();
            }
            else
            {
                //TODO: custom animation file
            }

            newData.MotionInfo.IsLoopMotion = chkLoopMotion.Checked;
            newData.MotionInfo.IsBlend = chkSmoothMotionTransition.Checked;
        }

        private void SaveEyeSightData(ADVStep.ShowChara newData)
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

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        private void cbTargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbTargetType = sender as ComboBox;
            if (cbTargetType.SelectedValue == Constant.TargetType.ClubOwner
                || cbTargetType.SelectedValue == Constant.TargetType.AllMaids
                || cbTargetType.SelectedValue == Constant.TargetType.AllMen
                || cbTargetType.SelectedValue == Constant.TargetType.AllNPCFemale
                || cbTargetType.SelectedValue == Constant.TargetType.AllNPCMale
                )
            {
                pnlPosition.Visible = false;
            }
            else
            {
                pnlPosition.Visible = true;
            }

            //Update the Index Position List
            //Locate the CharaInit Step

            int listItemCount = 0;
            if (cbTargetType.SelectedValue == Constant.TargetType.SingleMaid)
            {
                if (Global.ScenarioDefinition.MaidRequirement != null)
                    listItemCount = Global.ScenarioDefinition.MaidRequirement.Count;
            }
            else
            {
                ADVStep charaInitStepData = Global.AllSteps.Where(x => x.Type == StepItem.StepType.CharaInit).First().StepData;
                if (charaInitStepData != null && charaInitStepData.CharaInitData != null)
                {
                    if (cbTargetType.SelectedValue == Constant.TargetType.SingleMan)
                        listItemCount = charaInitStepData.CharaInitData.ManRequired;
                    else if (cbTargetType.SelectedValue == Constant.TargetType.NPCFemale)
                    {
                        if (charaInitStepData.CharaInitData.NPCFemale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCFemale.Count;
                    }
                    else if (cbTargetType.SelectedValue == Constant.TargetType.NPCMale)
                    {
                        if (charaInitStepData.CharaInitData.NPCMale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCMale.Count;
                    }
                }
            }
            Util.SetupIndexPositionComboBox(cbListIndex, listItemCount);


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

        private void chkSmoothMovement_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSmoothMovementDurationEnabledStatus();
        }

        private void UpdateSmoothMovementDurationEnabledStatus()
        {
            txtSmoothMovementDuration.Enabled = chkSmoothMovement.Checked;
        }

        private void UpdateMotionPanelVisibility()
        {
            pnlMotionScript.Visible = rbMotionScript.Checked;
            pnlMotionAnimation.Visible = rbAnimationFile.Checked;
            pnlCustomAnimination.Visible = rbCustomAnimation.Checked;
        }

        private void rbMotionScript_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMotionPanelVisibility();
        }

        private void rbAnimationFile_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMotionPanelVisibility();
        }

        private void rbCustomAnimation_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMotionPanelVisibility();
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


        private void chkFaceBlend_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFaceBlendTrackerBarEnabledStatus();
        }

        private void UpdateFaceBlendTrackerBarEnabledStatus()
        {
            tbBlushing.Enabled = chkFaceBlend.Checked;
            tbTearLevel.Enabled = chkFaceBlend.Checked;
        }

        private void chkMotionUpdate_CheckedChanged(object sender, EventArgs e)
        {
            pnlMotionUpdate.Visible = chkMotionUpdate.Checked;
        }

        private void chkEyeSightUpdate_CheckedChanged(object sender, EventArgs e)
        {
            pnlEyeSightUpdate.Visible = chkEyeSightUpdate.Checked;
        }

        private void tbBlushing_ValueChanged(object sender, EventArgs e)
        {
            lblBlushingLevelValue.Text = tbBlushing.Value.ToString();
        }

        private void tbTearLevel_ValueChanged(object sender, EventArgs e)
        {
            lblTearLevelValue.Text = tbTearLevel.Value.ToString();
        }

        private bool IsCurrentTargetTypeMan
        {
            get
            {
                return ManTargetType.Contains(cbTargetType.SelectedValue);
            }
        }
    }




}
