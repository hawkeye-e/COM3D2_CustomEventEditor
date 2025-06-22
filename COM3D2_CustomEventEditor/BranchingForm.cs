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

namespace COM3D2_CustomEventEditor
{
    public partial class BranchingForm : Form, ILocalizable
    {
        private List<BranchData> _BranchList = new List<BranchData>();


        internal delegate void FormUpdateCompleteEventHandler(ADVStep.Branch result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;

        public static readonly List<ComboBoxData> NumberComparativeMethodTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.OperatorType.Equal, Util.GetResourcesString("OperationTypeEqual")),
            new ComboBoxData(Constant.OperatorType.GreaterThan, Util.GetResourcesString("OperationTypeGreaterThan")),
            new ComboBoxData(Constant.OperatorType.GreaterThanEqualTo, Util.GetResourcesString("OperationTypeGreaterThanEqualTo")),
            new ComboBoxData(Constant.OperatorType.LessThan, Util.GetResourcesString("OperationTypeLessThan")),
            new ComboBoxData(Constant.OperatorType.LessThanEqualTo, Util.GetResourcesString("OperationTypeLessThanEqualTo")),
        };

        public static readonly List<ComboBoxData> NonNumberComparativeMethodTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.OperatorType.Equal, Util.GetResourcesString("OperationTypeEqual")),
        };

        public static readonly List<ComboBoxData> VariableTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Enum.GetName(Constant.VariableType.String), Util.GetResourcesString("VariableTypeString")),
            new ComboBoxData(Enum.GetName(Constant.VariableType.Integer), Util.GetResourcesString("VariableTypeInteger")),
            new ComboBoxData(Enum.GetName(Constant.VariableType.FloatingPoint), Util.GetResourcesString("VariableTypeFloatingPoint")),
            new ComboBoxData(Enum.GetName(Constant.VariableType.Boolean), Util.GetResourcesString("VariableTypeBoolean")),
        };

        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colValue", "BranchFormValue" },
            { "colNextStepID", "BranchFormNextStepID" },
        };


        internal BranchingForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += BranchingForm_Load;

            InitDropDown();

            _BranchList = ConvertStepDataToLocalList(stepData);

            InitControl(stepData);

            BindDataGrid();
        }

        private void InitDropDown()
        {
            cbVariableType.DataSource = VariableTypeList;
            cbVariableType.SelectedIndex = 0;
        }

        private void InitControl(ADVStep stepData)
        {
            int branchCount = 0;

            if (stepData != null)
                if (stepData.BranchData != null)
                {
                    txtVariableName.Texts = stepData.BranchData.VariableName;
                    cbVariableType.SelectedValue = Enum.GetName(stepData.BranchData.VariableType);
                    cbComparativeMethod.SelectedValue = stepData.BranchData.CompareMethod;
                    

                    if (stepData.BranchData.BranchList != null)
                        branchCount = stepData.BranchData.BranchList.Count;
                }

            cbNumOfBranch.SelectedIndex = branchCount;

        }

        private List<BranchData> ConvertStepDataToLocalList(ADVStep stepData)
        {
            List<BranchData> result = new List<BranchData>();

            if (stepData != null)
                if (stepData.BranchData != null)
                    if (stepData.BranchData.BranchList != null)
                    {
                        int index = 1;
                        foreach (var data in stepData.BranchData.BranchList)
                        {
                            BranchData option = new BranchData();

                            option.num = index;
                            option.value = data.Value;
                            option.next_step_id = data.NextStepID;

                            result.Add(option);
                            index++;
                        }
                    }

            return result;
        }

        private void BranchingForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("BranchingFormWindowName");

            foreach (DataGridViewColumn col in dgBranch.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();
        }

        private void cbNumOfBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            //Update the internal list while preserving existing data
            if (cb.SelectedIndex < _BranchList.Count)
            {
                var toRemove = _BranchList.Where(x => x.num > cb.SelectedIndex).ToList();
                foreach (var item in toRemove)
                {
                    _BranchList.Remove(item);
                }
            }
            else
            {
                for (int i = _BranchList.Count; i < cb.SelectedIndex; i++)
                {
                    var newRow = new BranchData();
                    newRow.num = i + 1;
                    _BranchList.Add(newRow);
                }
            }

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            var list = new BindingList<BranchData>(_BranchList);

            dgBranch.DataSource = list;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _NPCList into List<NPCFemaleData>
            ADVStep.Branch result = new ADVStep.Branch();
            List<ADVStep.Branch.BranchItem> branchItemList = new List<ADVStep.Branch.BranchItem>();

            foreach (var choiceData in _BranchList)
            {
                ADVStep.Branch.BranchItem newItem = new ADVStep.Branch.BranchItem();

                newItem.Value = choiceData.value;
                newItem.NextStepID = choiceData.next_step_id;

                branchItemList.Add(newItem);
            }

            result.VariableName = txtVariableName.Texts;
            Enum.TryParse(cbVariableType.SelectedValue.ToString(), out result.VariableType);
            result.CompareMethod = cbComparativeMethod.SelectedValue.ToString();
            result.BranchList = branchItemList;

            //signal the main form to update
            if (OnFormCompleted != null)
                OnFormCompleted.Invoke(result);

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

            dgBranch.Refresh();
        }


        public class BranchData
        {
            public int num { get; set; }
            public string value { get; set; }
            public string next_step_id { get; set; }

        }

        private void dgNPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

        }


        private void dgNPC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = dgBranch.Columns[dgBranch.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                dgBranch.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgNPC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgBranch.CancelEdit();
            dgBranch.RefreshEdit();
            e.Cancel = true;
        }

        private void cbVariableType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbVariableType.SelectedValue.ToString() == Enum.GetName(Constant.VariableType.String) || cbVariableType.SelectedValue.ToString() == Enum.GetName(Constant.VariableType.Boolean))
            {
                cbComparativeMethod.DataSource = NonNumberComparativeMethodTypeList;
            }
            else if (cbVariableType.SelectedValue.ToString() == Enum.GetName(Constant.VariableType.Integer) || cbVariableType.SelectedValue.ToString() == Enum.GetName(Constant.VariableType.FloatingPoint))
            {
                cbComparativeMethod.DataSource = NumberComparativeMethodTypeList;
            }
        }
    }
}

