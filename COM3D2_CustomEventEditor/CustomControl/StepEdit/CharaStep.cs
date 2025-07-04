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
using static COM3D2_CustomEventEditor.ADVStep;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    public partial class CharaStep : StepEditBase
    {
        private List<SelectedEffect> _SelectedEffects = new List<SelectedEffect>();

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

        public static readonly List<ComboBoxData> EffectFemaleList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.EffectType.Female.Breath, Util.GetResourcesString("EffectTypeBreath")),
            new ComboBoxData(Constant.EffectType.Female.SexualFluid1, Util.GetResourcesString("EffectTypeSexualFluid1")),
            new ComboBoxData(Constant.EffectType.Female.SexualFluid2, Util.GetResourcesString("EffectTypeSexualFluid2")),
            new ComboBoxData(Constant.EffectType.Female.SexualFluid3, Util.GetResourcesString("EffectTypeSexualFluid3")),
            new ComboBoxData(Constant.EffectType.Female.Urine_Common, Util.GetResourcesString("EffectTypeUrineCommon")),
            new ComboBoxData(Constant.EffectType.Female.Urine_Doggy, Util.GetResourcesString("EffectTypeUrineDoggy")),
            new ComboBoxData(Constant.EffectType.Female.Urine_Drop, Util.GetResourcesString("EffectTypeUrineDrop")),
            new ComboBoxData(Constant.EffectType.Female.Squirting, Util.GetResourcesString("EffectTypeSquirting")),
            new ComboBoxData(Constant.EffectType.Female.EjaculateInside, Util.GetResourcesString("EffectTypeEjaculateInside")),

        };

        public static readonly List<ComboBoxData> EffectMaleList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.EffectType.Male.EjaculateOutside, Util.GetResourcesString("EffectTypeEjaculateOutside")),
        };


        public CharaStep()
        {
            InitializeComponent();

            colRemoveEffect.Text = Util.GetResourcesString("Delete");
            colEffect.HeaderText = Util.GetResourcesString("CharaStepBodyEffectHeader");
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

            UpdateEffectTypeDropDown();
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
            InitEffectData(_StepData.CharaData[0]);
            InitExtraItemData(_StepData.CharaData[0]);
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
                txtClothesSet.Texts = data.ClothesSetID;
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
            txtClothesSet.Texts = "";
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

                rbCustomAnimation.Checked = !string.IsNullOrEmpty(data.MotionInfo.CustomMotionFile);
                if (rbCustomAnimation.Checked)
                {
                    txtMotionCustomAnimation.Texts = data.MotionInfo.CustomMotionFile;
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
            txtMotionCustomAnimation.Texts = "";
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

        private void InitEffectData(ADVStep.ShowChara data)
        {
            if (data.Effect != null)
            {
                chkEffectUpdate.Checked = true;

                if (data.Effect.ActiveEffects != null)
                {
                    foreach (var effect in data.Effect.ActiveEffects)
                    {
                        var effectData = GetEffectData(IsCurrentTargetTypeMan, effect);
                        if (effectData != null)
                        {
                            SelectedEffect item = new SelectedEffect();
                            item.value = effect;
                            item.display_text = effectData.DisplayText;
                            _SelectedEffects.Add(item);
                        }
                    }
                    BindEffectDataGrid();
                }

            }
        }

        private void ResetEffectData()
        {
            chkEffectUpdate.Checked = false;
            _SelectedEffects = new List<SelectedEffect>();
            UpdateEffectTypeDropDown();
            dgEffect.Rows.Clear();
        }

        private void InitExtraItemData(ADVStep.ShowChara data)
        {
            if (data.ExtraObjectInfo != null)
            {
                chkExtraItemUpdate.Checked = true;
                txtItemTarget.Texts = data.ExtraObjectInfo.Target;
                txtItemFileName.Texts = data.ExtraObjectInfo.ItemFile;
            }
        }

        private void ResetExtraItemData()
        {
            chkExtraItemUpdate.Checked = false;
            txtItemTarget.Texts = "";
            txtItemFileName.Texts = "";
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
            ResetEffectData();
            ResetExtraItemData();

            ucBasicStepInfo.LoadData(stepData);
            InitControlData();

            UpdateCoordinatesVisibility();
            UpdateSmoothMovementDurationEnabledStatus();
            UpdateMotionPanelVisibility();
            UpdateEyeSightPanelVisibility();
            UpdateEyeSightCharacterPanelVisibility();
            UpdateFaceBlendTrackerBarEnabledStatus();
            UpdateEffectPanelVisibility();
            UpdateExtraItemPanelVisibility();
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
            SaveEffectData(newData);
            SaveExtraItemData(newData);

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
                if (!string.IsNullOrEmpty(txtClothesSet.Texts))
                    newData.ClothesSetID = txtClothesSet.Texts;
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
                newData.MotionInfo.CustomMotionFile = txtMotionCustomAnimation.Texts;
                newData.MotionInfo.MotionTag = txtMotionCustomAnimation.Texts.ToLower();
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

        private void SaveEffectData(ADVStep.ShowChara newData)
        {
            if (!chkEffectUpdate.Checked)
                return;

            newData.Effect = new EffectDetail();
            newData.Effect.ActiveEffects = new List<string>();

            foreach (var effect in _SelectedEffects)
            {
                //add only if the body part record exists in a texture pattern
                var effectData = GetEffectData(IsCurrentTargetTypeMan, effect.value);
                if (effectData != null)
                {
                    if (!newData.Effect.ActiveEffects.Contains(effect.value))
                        newData.Effect.ActiveEffects.Add(effect.value);
                }
            }
        }

        private void SaveExtraItemData(ADVStep.ShowChara newData)
        {
            if (!chkExtraItemUpdate.Checked)
                return;

            newData.ExtraObjectInfo = new ExtraItemObject();
            newData.ExtraObjectInfo.Target = txtItemTarget.Texts;
            newData.ExtraObjectInfo.ItemFile = txtItemFileName.Texts;
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

            //Update the effect drop down
            UpdateEffectTypeDropDown();
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

        private void chkEffectUpdate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEffectPanelVisibility();
        }

        private void UpdateEffectPanelVisibility()
        {
            pnlEffect.Visible = chkEffectUpdate.Checked;
        }

        private void btnAddEffect_Click(object sender, EventArgs e)
        {
            SelectedEffect newItem = new SelectedEffect();
            ComboBoxData data = (ComboBoxData)cbEffectType.SelectedItem;
            newItem.display_text = data.DisplayText;
            newItem.value = data.DataKey;
            _SelectedEffects.Add(newItem);

            BindEffectDataGrid();
        }

        private void BindEffectDataGrid()
        {
            var list = new BindingList<SelectedEffect>(_SelectedEffects);

            dgEffect.DataSource = list;
        }

        private void dgEffect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == 0)
                {
                    //Remove button
                    try
                    {
                        dgEffect.Rows.RemoveAt(e.RowIndex);
                    }
                    catch { }
                }
            }
        }

        private void UpdateEffectTypeDropDown()
        {
            if (IsCurrentTargetTypeMan)
            {
                cbEffectType.DataSource = EffectMaleList;
                cbEffectType.SelectedIndex = 0;
            }
            else
            {
                cbEffectType.DataSource = EffectFemaleList;
                cbEffectType.SelectedIndex = 0;
            }
        }

        private ComboBoxData GetEffectData(bool isMan, string value)
        {
            if (isMan)
            {
                return EffectMaleList.Where(x => x.DataKey == value).FirstOrDefault();
            }
            else
            {
                return EffectFemaleList.Where(x => x.DataKey == value).FirstOrDefault();
            }
        }

        private void chkExtraItemUpdate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateExtraItemPanelVisibility();
        }

        private void UpdateExtraItemPanelVisibility()
        {
            pnlExtraItem.Visible = chkExtraItemUpdate.Checked;
        }




        private bool IsCurrentTargetTypeMan
        {
            get
            {
                return ManTargetType.Contains(cbTargetType.SelectedValue);
            }
        }

        private class SelectedEffect
        {
            public string display_text { get; set; }
            public string value { get; set; }
        }

    }




}
