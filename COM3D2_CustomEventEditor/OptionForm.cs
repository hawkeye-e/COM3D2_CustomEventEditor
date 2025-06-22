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

namespace COM3D2_CustomEventEditor
{
    public partial class OptionForm : Form, ILocalizable
    {
        private List<OptionData> _OptionList = new List<OptionData>();

        internal delegate void FormUpdateCompleteEventHandler(List<ADVStep.Choice.ChoiceOption> result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;


        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colKey", "OptionFormKey" },
            { "colValue", "OptionFormDisplayText" },
        };


        internal OptionForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += OptionForm_Load;

            _OptionList = ConvertStepDataToLocalList(stepData);

            InitControl(stepData);

            BindDataGrid();
        }

        private void InitControl(ADVStep stepData)
        {
            int groupCount = 0;

            if (stepData != null)
                if (stepData.ChoiceData != null)
                    if (stepData.ChoiceData.Options != null)
                        groupCount = stepData.ChoiceData.Options.Count;

            cbNumOfOption.SelectedIndex = groupCount;
        }

        private List<OptionData> ConvertStepDataToLocalList(ADVStep stepData)
        {
            List<OptionData> result = new List<OptionData>();

            if (stepData != null)
                if (stepData.ChoiceData != null)
                    if (stepData.ChoiceData.Options != null)
                    {
                        int index = 1;
                        foreach (var data in stepData.ChoiceData.Options)
                        {
                            OptionData option = new OptionData();

                            option.key = data.Key;
                            option.text = data.Value;

                            result.Add(option);
                            index++;
                        }
                    }

            return result;
        }

        private void OptionForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("OptionFormWindowName");

            foreach (DataGridViewColumn col in dgOption.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();
        }

        private void cbNumOfOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            //Update the internal list while preserving existing data
            if (cb.SelectedIndex < _OptionList.Count)
            {
                var toRemove = _OptionList.Where(x => x.num > cb.SelectedIndex).ToList();
                foreach (var item in toRemove)
                {
                    _OptionList.Remove(item);
                }
            }
            else
            {
                for (int i = _OptionList.Count; i < cb.SelectedIndex; i++)
                {
                    var newRow = new OptionData();
                    newRow.num = i + 1;
                    _OptionList.Add(newRow);
                }
            }

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            var list = new BindingList<OptionData>(_OptionList);

            dgOption.DataSource = list;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _NPCList into List<NPCFemaleData>
            List<ADVStep.Choice.ChoiceOption> resultList = new List<ADVStep.Choice.ChoiceOption>();

            foreach (var choiceData in _OptionList)
            {
                ADVStep.Choice.ChoiceOption newItem = new ADVStep.Choice.ChoiceOption();

                newItem.Key = choiceData.key;
                newItem.Value = choiceData.text;

                resultList.Add(newItem);
            }

            //signal the main form to update
            if (OnFormCompleted != null)
                OnFormCompleted.Invoke(resultList);

            this.Close();
        }

        private void dgNPC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == 0)
                {
                    
                }
            }

            dgOption.Refresh();
        }


        public class OptionData
        {
            public int num { get; set; }
            public string key { get; set; }                
            public string text { get; set; }

        }

        private void dgNPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

        }


        private void dgNPC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = dgOption.Columns[dgOption.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                dgOption.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgNPC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgOption.CancelEdit();
            dgOption.RefreshEdit();
            e.Cancel = true;
        }


    }
}

