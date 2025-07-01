using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    
    public partial class EvaluateInput : UserControl
    {
        public readonly List<ComboBoxData> SourceListTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.TargetType.SingleMaid, Util.GetResourcesString("TargetTypeMaid")),
            new ComboBoxData(Constant.TargetType.NPCFemale, Util.GetResourcesString("TargetTypeNPCFemale")),
        };

        public readonly List<ComboBoxData> FixedValueTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Enum.GetName(Constant.VariableType.String), Util.GetResourcesString("VariableTypeString")),
            new ComboBoxData(Enum.GetName(Constant.VariableType.Integer), Util.GetResourcesString("VariableTypeInteger")),
            new ComboBoxData(Enum.GetName(Constant.VariableType.FloatingPoint), Util.GetResourcesString("VariableTypeFloatingPoint")),
            new ComboBoxData(Enum.GetName(Constant.VariableType.Boolean), Util.GetResourcesString("VariableTypeBoolean")),
        };

        public readonly List<ComboBoxData> CharaStatusFieldNameList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.CharacterStatusField.HeroineType, Util.GetResourcesString("CharaStatusFieldHeroineType")),

            new ComboBoxData(Constant.CharacterStatusField.Likability, Util.GetResourcesString("CharaStatusFieldLikability")),
            new ComboBoxData(Constant.CharacterStatusField.Lovely, Util.GetResourcesString("CharaStatusFieldLovely")),
            new ComboBoxData(Constant.CharacterStatusField.Elegance, Util.GetResourcesString("CharaStatusFieldElegance")),
            new ComboBoxData(Constant.CharacterStatusField.Charm, Util.GetResourcesString("CharaStatusFieldCharm")),

            new ComboBoxData(Constant.CharacterStatusField.Care, Util.GetResourcesString("CharaStatusFieldCare")),
            new ComboBoxData(Constant.CharacterStatusField.Reception, Util.GetResourcesString("CharaStatusFieldReception")),
            new ComboBoxData(Constant.CharacterStatusField.Cooking, Util.GetResourcesString("CharaStatusFieldCooking")),
            new ComboBoxData(Constant.CharacterStatusField.Dance, Util.GetResourcesString("CharaStatusFieldDance")),
            new ComboBoxData(Constant.CharacterStatusField.Vocal, Util.GetResourcesString("CharaStatusFieldVocal")),
            new ComboBoxData(Constant.CharacterStatusField.NightWorkCount, Util.GetResourcesString("CharaStatusFieldNightWorkCount")),

            new ComboBoxData(Constant.CharacterStatusField.Inyoku, Util.GetResourcesString("CharaStatusFieldInyoku")),
            new ComboBoxData(Constant.CharacterStatusField.MValue, Util.GetResourcesString("CharaStatusFieldMValue")),
            new ComboBoxData(Constant.CharacterStatusField.Hentai, Util.GetResourcesString("CharaStatusFieldHentai")),
            new ComboBoxData(Constant.CharacterStatusField.Houshi, Util.GetResourcesString("CharaStatusFieldHoushi")),
            new ComboBoxData(Constant.CharacterStatusField.YotogiCount, Util.GetResourcesString("CharaStatusFieldYotogiCount")),

            new ComboBoxData(Constant.CharacterStatusField.SexExperienceVaginal, Util.GetResourcesString("CharaStatusFieldSexExperienceVaginal")),
            new ComboBoxData(Constant.CharacterStatusField.SexExperienceAnal, Util.GetResourcesString("CharaStatusFieldSexExperienceAnal")),

            new ComboBoxData(Constant.CharacterStatusField.Height, Util.GetResourcesString("CharaStatusFieldHeight")),
            new ComboBoxData(Constant.CharacterStatusField.Weight, Util.GetResourcesString("CharaStatusFieldWeight")),
            new ComboBoxData(Constant.CharacterStatusField.Bust, Util.GetResourcesString("CharaStatusFieldBust")),
            new ComboBoxData(Constant.CharacterStatusField.Waist, Util.GetResourcesString("CharaStatusFieldWaist")),
            new ComboBoxData(Constant.CharacterStatusField.Hip, Util.GetResourcesString("CharaStatusFieldHip")),
            new ComboBoxData(Constant.CharacterStatusField.Cup, Util.GetResourcesString("CharaStatusFieldCup")),

            new ComboBoxData(Constant.CharacterStatusField.SexNumOfPeople, Util.GetResourcesString("CharaStatusFieldSexNumOfPeople")),
        };

        ADVStep _StepData;
        
        public EvaluateInput()
        {
            InitializeComponent();
        }

        public void SetInputType(bool isInput1 = true)
        {
            if (isInput1)
                gbInput.Text = Util.GetResourcesString("EvaluateInput1GroupLabel");
            else
                gbInput.Text = Util.GetResourcesString("EvaluateInput2GroupLabel");
        }


        private void InitDropDown()
        {
            cbListType.DataSource = SourceListTypeList;
            cbListType.SelectedIndex = 0;

            cbFixedValueType.DataSource = FixedValueTypeList;
            cbFixedValueType.SelectedIndex = 0;

            cbFieldName.DataSource = CharaStatusFieldNameList;
            cbFieldName.SelectedIndex = 0;

            BindListIndexDropDown();
        }

        internal void ResetData()
        {
            txtFixedValue.Texts = "";
            txtVariableName.Texts = "";
            txtMaxValue.Texts = "";
            rbVariable.Checked = true;
            UpdatePanelVisibility();

            InitDropDown();
        }

        internal void LoadData(ADVStep.Evaluate.InputDetail inputDetail)
        {
            
            if (inputDetail == null)
                return;

            if (inputDetail.SourceType == ADVStep.Evaluate.SourceType.Variable)
            {
                rbVariable.Checked = true;
                if (inputDetail.Variable != null)
                    txtVariableName.Texts = inputDetail.Variable.VariableName;
            }
            else if (inputDetail.SourceType == ADVStep.Evaluate.SourceType.CharcterStatus)
            {
                rbCharaStatus.Checked = true;
                if (inputDetail.CharaStatus != null)
                {
                    cbListType.SelectedValue = inputDetail.CharaStatus.ListType;
                    cbListIndex.SelectedIndex = inputDetail.CharaStatus.ArrayPosition;
                    
                    cbFieldName.SelectedValue = inputDetail.CharaStatus.FieldName;
                }
            }
            else if (inputDetail.SourceType == ADVStep.Evaluate.SourceType.FixedValue)
            {
                rbFixedValue.Checked = true;
                if (inputDetail.FixedValue != null)
                {
                    cbFixedValueType.SelectedValue = Enum.GetName( inputDetail.FixedValue.FixedValueType);
                    txtFixedValue.Texts = inputDetail.FixedValue.FixedValue;
                }
            }
            else if (inputDetail.SourceType == ADVStep.Evaluate.SourceType.RandomNumber)
            {
                rbRandomNumber.Checked = true;
                if (inputDetail.RandomNumber != null)
                    txtMaxValue.Texts = inputDetail.RandomNumber.MaxValue.ToString();
            }

            //_IsInit = false;
        }

        internal ADVStep.Evaluate.InputDetail GetInputDetail()
        {
            ADVStep.Evaluate.InputDetail result = new ADVStep.Evaluate.InputDetail();

            if (rbVariable.Checked)
            {
                result.SourceType = ADVStep.Evaluate.SourceType.Variable;
                result.Variable = new ADVStep.Evaluate.VariableInfo();
                result.Variable.VariableName = txtVariableName.Texts;
            }
            else if (rbCharaStatus.Checked)
            {
                result.SourceType = ADVStep.Evaluate.SourceType.CharcterStatus;
                result.CharaStatus = new ADVStep.Evaluate.CharaStatusInfo();
                result.CharaStatus.ListType = cbListType.SelectedValue.ToString();
                result.CharaStatus.ArrayPosition = cbListIndex.SelectedIndex;

                result.CharaStatus.FieldName = cbFieldName.SelectedValue.ToString();
            }
            else if (rbFixedValue.Checked)
            {
                result.SourceType = ADVStep.Evaluate.SourceType.FixedValue;
                result.FixedValue = new ADVStep.Evaluate.FixedValueInfo();
                Enum.TryParse(cbFixedValueType.SelectedValue.ToString(), out result.FixedValue.FixedValueType);
                result.FixedValue.FixedValue = txtFixedValue.Texts;
            }
            else if (rbRandomNumber.Checked)
            {
                result.SourceType = ADVStep.Evaluate.SourceType.RandomNumber;
                result.RandomNumber = new ADVStep.Evaluate.RandomNumberInfo();
                int.TryParse(txtMaxValue.Texts, out result.RandomNumber.MaxValue);
            }

            return result;
        }

        private void UpdatePanelVisibility()
        {
            pnlVariable.Visible = rbVariable.Checked;
            pnlCharaStatus.Visible = rbCharaStatus.Checked;
            pnlFixedValue.Visible = rbFixedValue.Checked;
        }

        private void rbSourceTypeVariable_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanelVisibility();
        }

        private void rbCharaStatus_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanelVisibility();
        }

        private void rbFixedValue_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePanelVisibility();
        }

        private void cbListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindListIndexDropDown();
        }

        private void BindListIndexDropDown()
        {
            int listItemCount = 0;
            if (cbListType.SelectedValue == Constant.TargetType.SingleMaid)
            {
                if (Global.ScenarioDefinition.MaidRequirement != null)
                    listItemCount = Global.ScenarioDefinition.MaidRequirement.Count;
            }
            else
            {
                ADVStep charaInitStepData = Global.AllSteps.Where(x => x.Type == StepItem.StepType.CharaInit).First().StepData;
                if (charaInitStepData != null && charaInitStepData.CharaInitData != null)
                {
                    if (cbListType.SelectedValue == Constant.TargetType.NPCFemale)
                    {
                        if (charaInitStepData.CharaInitData.NPCFemale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCFemale.Count;
                    }
                }
            }
            Util.SetupIndexPositionComboBox(cbListIndex, listItemCount);
        }
    }
}
