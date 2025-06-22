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
    public partial class TextureStep : StepEditBase
    {
        private List<SelectedBodyPart> _SelectedBodyParts = new List<SelectedBodyPart>();

        public static readonly List<ComboBoxData> TargetTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.TargetType.SingleMaid, Util.GetResourcesString("TargetTypeMaid")),
            new ComboBoxData(Constant.TargetType.NPCFemale,Util.GetResourcesString("TargetTypeNPCFemale")),

            new ComboBoxData(Constant.TargetType.AllMaids, Util.GetResourcesString("TargetTypeAllMaid")),
            new ComboBoxData(Constant.TargetType.AllNPCFemale,Util.GetResourcesString("TargetTypeAllNPCFemale")),
        };

        public static readonly List<ComboBoxData> TextureTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.TextureType.Semen, Util.GetResourcesString("TextureTypeSemen")),
        };

        public static readonly List<ComboBoxData> SemenBodyPartTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.BodyPartType.Vagina, Util.GetResourcesString("BodyPartTypeVagina")),
            new ComboBoxData(Constant.BodyPartType.Belly, Util.GetResourcesString("BodyPartTypeBelly")),
            new ComboBoxData(Constant.BodyPartType.Ass, Util.GetResourcesString("BodyPartTypeAss")),
            new ComboBoxData(Constant.BodyPartType.Back, Util.GetResourcesString("BodyPartTypeBack")),
            new ComboBoxData(Constant.BodyPartType.Breast, Util.GetResourcesString("BodyPartTypeBreast")),
            new ComboBoxData(Constant.BodyPartType.Mouth, Util.GetResourcesString("BodyPartTypeMouth")),
            new ComboBoxData(Constant.BodyPartType.Face, Util.GetResourcesString("BodyPartTypeFace")),
        };




        private bool _isInit = true;

        public TextureStep()
        {
            InitializeComponent();

            colRemove.Text = Util.GetResourcesString("Delete");
            colPart.HeaderText = Util.GetResourcesString("TextureStepBodyPartHeader");
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;



            rbAddTexture.Checked = _StepData.Type == Constant.ADVType.AddTexture;
            rbRemoveTexture.Checked = _StepData.Type == Constant.ADVType.RemoveTexture;

            if (_StepData.TextureData != null)
                if (_StepData.TextureData.Length > 0)
                {
                    cbTextureType.SelectedValue = _StepData.TextureData[0].Type; 
                    cbTargetType.SelectedValue = _StepData.TextureData[0].TargetType;
                    cbListIndex.SelectedIndex = _StepData.TextureData[0].IndexPosition;

                    if (rbAddTexture.Checked)
                    {
                        foreach (var part in _StepData.TextureData[0].BodyTarget)
                        {
                            SelectedBodyPart item = new SelectedBodyPart();
                            item.value = part;
                            item.display_text = GetBodyPartData(cbTextureType.SelectedValue.ToString(), part).DisplayText;
                            _SelectedBodyParts.Add(item);
                        }
                        BindDataGrid();
                    }
                }

            UpdatePanelVisibility();

        }

        private ComboBoxData GetBodyPartData(string textureType, string value) 
        {
            if (textureType == Constant.TextureType.Semen)
            {
                return SemenBodyPartTypeList.Where(x => x.DataKey == value).FirstOrDefault();
            }

            return null;
        }

        private void InitDropDown()
        {
            cbTargetType.DataSource = TargetTypeList;
            cbTargetType.SelectedIndex = 0;

            cbTextureType.DataSource = TextureTypeList;
            cbTextureType.SelectedIndex = 0;

            SetupListIndexDropDown();
            if (cbListIndex.Items.Count > 0)
                cbListIndex.SelectedIndex = 0;
        }


        internal void LoadData(ADVStep stepData)
        {
            _isInit = true;

            InitDropDown();

            rbAddTexture.Checked = true;
            cbTargetType.SelectedIndex = 0;
            _SelectedBodyParts = new List<SelectedBodyPart>();
            dgTexture.Rows.Clear();
            UpdatePanelVisibility();

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

            List<ADVStep.Texture> newDataList = new List<ADVStep.Texture>();
            ADVStep.Texture newData = new ADVStep.Texture();
            newDataList.Add(newData);

            newData.Type = cbTextureType.SelectedValue.ToString();
            newData.TargetType = cbTargetType.SelectedValue.ToString();
            newData.IndexPosition = cbListIndex.SelectedIndex;

            if (rbAddTexture.Checked)
            {
                //Add texture

                newData.BodyTarget = new List<string>();
                foreach (var bodyPart in _SelectedBodyParts)
                    newData.BodyTarget.Add(bodyPart.value);
            }
            else
            {
                //Remove texture
                
            }

            _StepData.TextureData = newDataList.ToArray();
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        public void TextureTypeUpdate()
        {
            StepItem.StepType stepType = rbAddTexture.Checked ? StepItem.StepType.AddTexture : StepItem.StepType.RemoveTexture;
            var stepItem = Global.AllSteps.Where(x => x.StepData == _StepData).First();
            stepItem.SetStepType(stepType);


        }

        private void UpdatePanelVisibility()
        {
            pnlAddTexture.Visible = rbAddTexture.Checked;
        }

        private void rbAddTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;

            _StepData.Type = Constant.ADVType.AddTexture;
            TextureTypeUpdate();
            UpdatePanelVisibility();
        }

        private void rbRemoveTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;

            _StepData.Type = Constant.ADVType.RemoveTexture;
            TextureTypeUpdate();
            UpdatePanelVisibility();
        }

        private void cbTextureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTextureType.SelectedValue.ToString() == Constant.TextureType.Semen)
            {
                cbBodyPart.DataSource = SemenBodyPartTypeList;
                cbBodyPart.SelectedIndex = 0;
            }

        }

        private void cbTargetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTargetType.SelectedValue == Constant.TargetType.AllMaids || cbTargetType.SelectedValue == Constant.TargetType.AllNPCFemale)
            {
                pnlPosition.Visible = false;
            }
            else
            {
                pnlPosition.Visible = true;
            }

            SetupListIndexDropDown();
        }

        private void SetupListIndexDropDown()
        {
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
                    if (cbTargetType.SelectedValue == Constant.TargetType.NPCFemale)
                    {
                        if (charaInitStepData.CharaInitData.NPCFemale != null)
                            listItemCount = charaInitStepData.CharaInitData.NPCFemale.Count;
                    }
                }
            }
            Util.SetupIndexPositionComboBox(cbListIndex, listItemCount);
        }

        private void btnAddBodyPart_Click(object sender, EventArgs e)
        {
            SelectedBodyPart newItem = new SelectedBodyPart();
            ComboBoxData data = (ComboBoxData)cbBodyPart.SelectedItem;
            newItem.display_text = data.DisplayText;
            newItem.value = data.DataKey;
            _SelectedBodyParts.Add(newItem);

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            var list = new BindingList<SelectedBodyPart>(_SelectedBodyParts);

            dgTexture.DataSource = list;
        }

        private void dgTexture_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == 0)
                {
                    //Remove button
                    //_SelectedBodyParts.RemoveAt(e.RowIndex);
                    dgTexture.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void dgTexture_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == 0)
                {
                    //Remove button
                    _SelectedBodyParts.RemoveAt(e.RowIndex);
                }
            }
        }


        private class SelectedBodyPart
        {
            public string display_text { get; set; }
            public string value { get; set; }
        }


    }




}
