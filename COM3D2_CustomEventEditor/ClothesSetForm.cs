using COM3D2_CustomEventEditor.DataClass;
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
using static COM3D2_CustomEventEditor.ADVStep;
using static COM3D2_CustomEventEditor.ADVStep.CharaInit;
using static COM3D2_CustomEventEditor.StepItem;

namespace COM3D2_CustomEventEditor
{
    public partial class ClothesSetForm : Form, ILocalizable
    {
        private List<ClothesSetInfo> _ClothesSetList = new List<ClothesSetInfo>();

        private const int COL_INDEX_DELETE_BUTTON = 27;


        internal delegate void FormUpdateCompleteEventHandler(List<ADVStep.CharaInit.ClothesSetData> result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;



        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colKey", "ClothesSetFormKey" },

            { "colHat", "ClothesSetFormHat" },
            { "colHeadDress", "ClothesSetFormHeadDress" },
            { "colTop", "ClothesSetFormTop" },
            { "colBottom", "ClothesSetFormBottom" },
            { "colOnePiece", "ClothesSetFormOnePiece" },
            { "colSwimsuit", "ClothesSetFormSwimsuit" },
            { "colBra", "ClothesSetFormBra" },
            { "colPanties", "ClothesSetFormPanties" },
            { "colSocks", "ClothesSetFormSocks" },
            { "colShoes", "ClothesSetFormShoes" },
            { "colBangs", "ClothesSetFormBangs" },
            { "colEyeMask", "ClothesSetFormEyeMask" },
            { "colNose", "ClothesSetFormNose" },
            { "colEars", "ClothesSetFormEars" },
            { "colGloves", "ClothesSetFormGloves" },
            { "colNecklace", "ClothesSetFormNecklace" },
            { "colChoker", "ClothesSetFormChoker" },
            { "colRibbon", "ClothesSetFormRibbon" },
            { "colNipple", "ClothesSetFormNipple" },
            { "colArm", "ClothesSetFormArm" },
            { "colBellyButton", "ClothesSetFormBellyButton" },
            { "colAnkle", "ClothesSetFormAnkle" },
            { "colBack", "ClothesSetFormBack" },
            { "colTail", "ClothesSetFormTail" },
            { "colVagina", "ClothesSetFormVagina" },

        };

        internal ClothesSetForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += ClothesSetForm_Load;

            _ClothesSetList = ConvertStepDataToLocalList(stepData);

            InitDataGridView();

            BindDataGrid();
        }

        private void InitDataGridView()
        {
            //further setup on the datagrid column

            colDelete.Text = Util.GetResourcesString("Delete");
            
        }



        private List<ClothesSetInfo> ConvertStepDataToLocalList(ADVStep stepData)
        {
            List<ClothesSetInfo> result = new List<ClothesSetInfo>();

            if (stepData != null)
                if (stepData.CharaInitData != null)
                    if (stepData.CharaInitData.ClothesSet != null)
                    {
                        Type type = typeof(ClothesSetInfo);
                        foreach (var data in stepData.CharaInitData.ClothesSet)
                        {
                            ClothesSetInfo clothesSet = new ClothesSetInfo();
                            clothesSet.key = data.Key;
                            
                            foreach(var kvp in data.Slots)
                            {
                                var field = type.GetProperty(kvp.Key);
                                field.SetValue(clothesSet, kvp.Value);
                            }

                            result.Add(clothesSet);
                        }
                    }

            return result;
        }

        private void ClothesSetForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("ClothesSetFormWindowName");

            foreach (DataGridViewColumn col in dgClothesSet.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();
        }


        private void BindDataGrid()
        {
            dgClothesSet.AutoGenerateColumns = false;
            var list = new BindingList<ClothesSetInfo>(_ClothesSetList);

            dgClothesSet.DataSource = list;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _ClothesSetList into List<ClothesSetData>
            List<ADVStep.CharaInit.ClothesSetData> resultList = new List<ADVStep.CharaInit.ClothesSetData>();

            foreach (var clothesSet in _ClothesSetList)
            {
                ADVStep.CharaInit.ClothesSetData newItem = new ADVStep.CharaInit.ClothesSetData();
                newItem.Key = clothesSet.key;
                newItem.Slots = new Dictionary<string, string>();

                Type type = typeof(ClothesSetInfo);
                foreach (var p in type.GetProperties())
                {
                    if (p.Name != "key")
                    {
                        var objectValue = p.GetValue(clothesSet);
                        if (objectValue != null)
                        {
                            string value = p.GetValue(clothesSet).ToString();
                            if (!string.IsNullOrWhiteSpace(value))
                                newItem.Slots.Add(p.Name, value);
                        }
                        

                        
                    }
                }

                resultList.Add(newItem);
            }


            //signal the main form to update
            if (OnFormCompleted != null)
                OnFormCompleted.Invoke(resultList);

            this.Close();
        }

        private void dgClothesSet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == COL_INDEX_DELETE_BUTTON)
                {
                    //delete row
                    try
                    {
                        dgClothesSet.Rows.RemoveAt(e.RowIndex);
                    }
                    catch { }
                }
            }

            dgClothesSet.Refresh();
        }


        public class ClothesSetInfo
        {
            public string key { get; set; }
            public string acchat { get; set; }
            public string headset { get; set; }
            public string acckami { get; set; }
            public string acckamisub { get; set; }
            public string wear { get; set; }
            public string skirt { get; set; }
            public string megane { get; set; }
            public string acchead { get; set; }
            public string onepiece { get; set; }
            public string mizugi { get; set; }
            public string accmimi { get; set; }
            public string acchana { get; set; }
            public string bra { get; set; }
            public string panz { get; set; }
            public string acckubi { get; set; }
            public string acckubiwa { get; set; }
            public string shoes { get; set; }
            public string stkg { get; set; }
            public string accude { get; set; }
            public string accsenaka { get; set; }
            public string glove { get; set; }
            public string accashi { get; set; }
            public string accshippo { get; set; }
            public string accheso { get; set; }
            public string accnip { get; set; }
            public string accxxx { get; set; }
        }

        private void dgClothesSet_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

        }


        private void dgClothesSet_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = dgClothesSet.Columns[dgClothesSet.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                dgClothesSet.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgClothesSet_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgClothesSet.CancelEdit();
            dgClothesSet.RefreshEdit();
            e.Cancel = true;
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> clothesSetData = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(txtParse.Texts);

                if (clothesSetData != null)
                {
                    ClothesSetInfo newItem = new ClothesSetInfo();

                    Type type = typeof(ClothesSetInfo);
                    foreach (var p in type.GetProperties())
                    {
                        if (clothesSetData.ContainsKey(p.Name))
                            p.SetValue(newItem, clothesSetData[p.Name]);

                    }

                    newItem.key = "";
                    _ClothesSetList.Add(newItem);
                    BindDataGrid();
                }
            }
            catch (Exception ex)
            {
                //If there is any problem during parsing, do nothing
            }
            finally
            {
                txtParse.Texts = "";
            }
        }
    }
}

