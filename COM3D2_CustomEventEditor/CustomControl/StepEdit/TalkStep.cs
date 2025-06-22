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
    public partial class TalkStep : StepEditBase
    {
        private Dictionary<string, ADVStep.Talk.Voice> _StoredMultipleVoiceData;

        public static readonly List<ComboBoxData> SpeakerTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.ADVTalkSpeakerType.Owner, Util.GetResourcesString("SpeakerOwner")),
            new ComboBoxData(Constant.ADVTalkSpeakerType.Maid, Util.GetResourcesString("SpeakerMaid")),
            new ComboBoxData(Constant.ADVTalkSpeakerType.NPCFemale,Util.GetResourcesString("SpeakerNPCFemale")),
            new ComboBoxData(Constant.ADVTalkSpeakerType.NPCMale,Util.GetResourcesString("SpeakerNPCMale")),
            new ComboBoxData(Constant.ADVTalkSpeakerType.Other,Util.GetResourcesString("SpeakerOther")),
            new ComboBoxData(Constant.ADVTalkSpeakerType.Narrative,Util.GetResourcesString("SpeakerNarrative")),
            new ComboBoxData(Constant.ADVTalkSpeakerType.All,Util.GetResourcesString("SpeakerAll")),

        };

        public static readonly List<ComboBoxData> PersonalityList = new List<ComboBoxData>()
        {
            new ComboBoxData(OPTION_VALUE_NONE, Util.GetResourcesString("OptionNone")),
            new ComboBoxData(nameof(Constant.PersonalityType.Pure), Util.GetResourcesString("PersonalityPure")),
            new ComboBoxData(nameof(Constant.PersonalityType.Pride), Util.GetResourcesString("PersonalityPride")),
            new ComboBoxData(nameof(Constant.PersonalityType.Cool), Util.GetResourcesString("PersonalityCool")),
            new ComboBoxData(nameof(Constant.PersonalityType.Yandere), Util.GetResourcesString("PersonalityYandere")),
            new ComboBoxData(nameof(Constant.PersonalityType.Anesan), Util.GetResourcesString("PersonalityAnesan")),
            new ComboBoxData(nameof(Constant.PersonalityType.Genki), Util.GetResourcesString("PersonalityGenki")),
            new ComboBoxData(nameof(Constant.PersonalityType.Sadist), Util.GetResourcesString("PersonalitySadist")),
            new ComboBoxData(nameof(Constant.PersonalityType.Muku), Util.GetResourcesString("PersonalityMuku")),
            new ComboBoxData(nameof(Constant.PersonalityType.Majime), Util.GetResourcesString("PersonalityMajime")),
            new ComboBoxData(nameof(Constant.PersonalityType.Rindere), Util.GetResourcesString("PersonalityRindere")),
            new ComboBoxData(nameof(Constant.PersonalityType.Silent), Util.GetResourcesString("PersonalitySilent")),
            new ComboBoxData(nameof(Constant.PersonalityType.Devilish), Util.GetResourcesString("PersonalityDevilish")),
            new ComboBoxData(nameof(Constant.PersonalityType.Ladylike), Util.GetResourcesString("PersonalityLadylike")),
            new ComboBoxData(nameof(Constant.PersonalityType.Secretary), Util.GetResourcesString("PersonalitySecretary")),
            new ComboBoxData(nameof(Constant.PersonalityType.Sister), Util.GetResourcesString("PersonalitySister")),
            new ComboBoxData(nameof(Constant.PersonalityType.Curtness), Util.GetResourcesString("PersonalityCurtness")),
            new ComboBoxData(nameof(Constant.PersonalityType.Missy), Util.GetResourcesString("PersonalityMissy")),
            new ComboBoxData(nameof(Constant.PersonalityType.Childhood), Util.GetResourcesString("PersonalityChildhood")),
            new ComboBoxData(nameof(Constant.PersonalityType.Masochist), Util.GetResourcesString("PersonalityMasochist")),
            new ComboBoxData(nameof(Constant.PersonalityType.Cunning), Util.GetResourcesString("PersonalityCunning")),
            new ComboBoxData(nameof(Constant.PersonalityType.Friendly), Util.GetResourcesString("PersonalityFriendly")),
            new ComboBoxData(nameof(Constant.PersonalityType.Dame), Util.GetResourcesString("PersonalityDame")),
            new ComboBoxData(nameof(Constant.PersonalityType.Gyaru), Util.GetResourcesString("PersonalityGyaru")),
            new ComboBoxData(OPTION_VALUE_NPC,Util.GetResourcesString("OptionNPC")),

        };

        private const string OPTION_VALUE_NONE = "None";
        private const string OPTION_VALUE_NPC = "NPC";


        public TalkStep()
        {
            InitializeComponent();
        }

        private void InitDropDown()
        {
            cbSpeakerType.DataSource = SpeakerTypeList;
            cbSpeakerType.SelectedIndex = 0;

            cbPersonality.DataSource = PersonalityList;
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.TalkData == null)
                return;

            cbSpeakerType.SelectedValue = _StepData.TalkData.SpecificSpeaker;
            txtSpeakerName.Texts = _StepData.TalkData.SpeakerName;
            chkUseBranchIndex.Checked = _StepData.TalkData.UseBranchIndex;
            cbListIndex.Enabled = !chkUseBranchIndex.Checked && cbListIndex.Items.Count > 0;

            cbListIndex.SelectedValue = _StepData.TalkData.Index;
            txtTalkText.Texts = _StepData.TalkData.Text;

            if (_StepData.TalkData.SpecificSpeaker == Constant.ADVTalkSpeakerType.All)
                _StoredMultipleVoiceData = _StepData.TalkData.VoiceData;
            else
            {
                if (_StepData.TalkData.VoiceData?.Count > 0)
                {
                    var voiceData = _StepData.TalkData.VoiceData.First().Value;
                    cbPersonality.SelectedValue = _StepData.TalkData.VoiceData.First().Key;
                    txtVoiceFile.Texts = voiceData.VoiceFile;
                    txtAudioStart.Texts = voiceData.StartTime.ToString();
                    txtAudioEnd.Texts = voiceData.EndTime.ToString();
                    tbVolume.Value = (int)(voiceData.Volume * 100);
                }
                else
                {
                    cbPersonality.SelectedIndex = 0;
                    txtVoiceFile.Texts = "";
                    txtAudioStart.Texts = "";
                    txtAudioEnd.Texts = "";
                    tbVolume.Value = 100;
                }
                tbVolume.Invalidate();
            }

        }

        private void ResetControl()
        {
            txtTalkText.Texts = "";
            txtSpeakerName.Texts = "";
            txtVoiceFile.Texts = "";
            txtAudioEnd.Texts = "";
            txtAudioStart.Texts = "";
            tbVolume.Value = 100;
        }

        internal void LoadData(ADVStep stepData)
        {
            ResetControl();
            _StepData = stepData;
            InitDropDown();
            ucBasicStepInfo.LoadData(stepData);
            InitControlData();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.Talk newData = new ADVStep.Talk();
            newData.SpecificSpeaker = cbSpeakerType.SelectedValue.ToString();

            if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Other)
                newData.SpeakerName = txtSpeakerName.Texts;
            else if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Narrative || cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Owner)
                newData.SpeakerName = string.Empty;
            else
            {
                newData.UseBranchIndex = chkUseBranchIndex.Checked;
                if (!chkUseBranchIndex.Checked)
                    newData.Index = cbListIndex.SelectedIndex;
            }

            newData.Text = txtTalkText.Texts;


            if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.All)
            {
                //TODO: multiple voice case
                newData.VoiceData = _StoredMultipleVoiceData;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtVoiceFile.Texts) && cbPersonality.SelectedValue != OPTION_VALUE_NONE)
                {
                    //the voice file info is provided, create the instance
                    newData.VoiceData = new Dictionary<string, ADVStep.Talk.Voice>();
                    string key = cbPersonality.SelectedValue.ToString();
                    ADVStep.Talk.Voice newVoice = new ADVStep.Talk.Voice();
                    newVoice.VoiceFile = txtVoiceFile.Texts;
                    if (!string.IsNullOrEmpty(txtAudioStart.Texts))
                    {
                        newVoice.StartTime = float.Parse(txtAudioStart.Texts, System.Globalization.CultureInfo.InvariantCulture);
                        newVoice.IsChoppingAudio = true;
                    }        
                    if (!string.IsNullOrEmpty(txtAudioEnd.Texts))
                    {
                        newVoice.EndTime = float.Parse(txtAudioEnd.Texts, System.Globalization.CultureInfo.InvariantCulture);
                        newVoice.IsChoppingAudio = true;
                    }

                    newData.VoiceData.Add(key, newVoice);
                    
                }
            }

            _StepData.TalkData = newData;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

       

        private void cbSpeakerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSpeakerType = sender as ComboBox;
            if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Other)
            {
                pnlPosition.Visible = false;
                pnlInputName.Visible = true;
            }
            else if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Narrative 
                || cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Owner 
                || cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.All)
            {
                pnlPosition.Visible = false;
                pnlInputName.Visible = false;
            }
            else
            {
                pnlPosition.Visible = true;
                pnlInputName.Visible = false;
            }

            if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.All)
            {
                pnlIndividualVoice.Visible = false;
                pnlAllVoice.Visible = true;
            }
            else
            {

                pnlIndividualVoice.Visible = true;
                pnlAllVoice.Visible = false;
            }

            gbVoice.Visible = (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Maid || cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.NPCFemale);

            int listItemCount = 0;
            if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.Maid)
            {
                if (Global.ScenarioDefinition.MaidRequirement != null)
                    listItemCount = Global.ScenarioDefinition.MaidRequirement.Count;
            }
            else
            {
                ADVStep charaInitStepData = Global.AllSteps.Where(x => x.Type == StepItem.StepType.CharaInit).First().StepData;
                if (charaInitStepData != null && charaInitStepData.CharaInitData != null)
                {
                    if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.NPCFemale)
                    {
                        if (charaInitStepData.CharaInitData.NPCFemale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCFemale.Count;
                    }
                    else if (cbSpeakerType.SelectedValue == Constant.ADVTalkSpeakerType.NPCMale)
                    {
                        if (charaInitStepData.CharaInitData.NPCMale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCMale.Count;
                    }
                }
            }
            Util.SetupIndexPositionComboBox(cbListIndex, listItemCount);
        }

        private void tbVolume_Scroll(object sender, EventArgs e)
        {
            lblVolumeValue.Text = tbVolume.Value.ToString();
        }

        private void txtAudioStart_Validating(object sender, CancelEventArgs e)
        {
            
            RemoveToolTip();
            e.Cancel = !ValidateAudioTime(txtAudioStart.Texts, true, out string errTitle, out string errMsg);
            if (e.Cancel)
            {
                _ErrorToolTip = Util.ShowErrorMessage(txtAudioStart, errTitle, errMsg);
            }
        }

        private void txtAudioEnd_Validating(object sender, CancelEventArgs e)
        {
            
            RemoveToolTip();
            e.Cancel = !ValidateAudioTime(txtAudioEnd.Texts, false, out string errTitle, out string errMsg);
            if (e.Cancel)
            {
                _ErrorToolTip = Util.ShowErrorMessage(txtAudioEnd, errTitle, errMsg);
            }
        }



        private bool ValidateAudioTime(string valueInString, bool isStart, out string errorTitle, out string errorMessage)
        {
            errorTitle = "";
            errorMessage = "";

            //If the input is empty, it is a valid input
            if (string.IsNullOrEmpty(valueInString))
                return true;

            //Check if it is not a valid floating number
            bool isOK = float.TryParse(valueInString, System.Globalization.CultureInfo.InvariantCulture, out float value);
            if (!isOK)
            {
                errorTitle = Util.GetResourcesString("InvalidInput");
                errorMessage = Util.GetResourcesString("InvalidFormatFloatingPointNumber");
                return false;
            }

            if (isStart)
            {
                //Checking pass if the other half is empty
                if (string.IsNullOrEmpty(txtAudioEnd.Texts))
                    return true;

                //The end time must be later than start time
                float.TryParse(txtAudioEnd.Texts, System.Globalization.CultureInfo.InvariantCulture, out float endTime);
                isOK = value < endTime || value == 0;
                if (!isOK)
                {
                    errorTitle = Util.GetResourcesString("InvalidInput");
                    errorMessage = Util.GetResourcesString("InvalidInputStartTime");
                }
                return isOK;
            }
            else
            {
                //Checking pass if the other half is empty
                if (string.IsNullOrEmpty(txtAudioStart.Texts))
                    return true;

                //The end time must be later than start time
                float.TryParse(txtAudioStart.Texts, System.Globalization.CultureInfo.InvariantCulture, out float startTime);
                isOK = startTime < value || value == 0;
                if (!isOK)
                {
                    errorTitle = Util.GetResourcesString("InvalidInput");
                    errorMessage = Util.GetResourcesString("InvalidInputEndTime");
                }

                return isOK;
            }

        }

        private void chkUseBranchIndex_CheckedChanged(object sender, EventArgs e)
        {
            if (cbListIndex.Items.Count == 0)
                cbListIndex.Enabled = false;
            else
                cbListIndex.Enabled = !chkUseBranchIndex.Checked;
        }
    }




}
