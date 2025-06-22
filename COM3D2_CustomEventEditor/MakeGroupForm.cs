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
    public partial class MakeGroupForm : Form, ILocalizable
    {
        private List<GroupData> _GroupList = new List<GroupData>();

        internal delegate void FormUpdateCompleteEventHandler(List<ADVStep.MakeGroupFormat> result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;

        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colNum", "MakeGroupFormGroupNo" },
            { "colGroupType", "MakeGroupFormGroupType" },
            { "colMaid1Type", "MakeGroupFormMaid1Type" },
            { "colMaid1Index", "MakeGroupFormMaid1Index" },
            { "colMaid2Type", "MakeGroupFormMaid2Type" },
            { "colMaid2Index", "MakeGroupFormMaid2Index" },

            { "colMan1Type", "MakeGroupFormMan1Type" },
            { "colMan1Index", "MakeGroupFormMan1Index" },
            { "colMan2Type", "MakeGroupFormMan2Type" },
            { "colMan2Index", "MakeGroupFormMan2Index" },
            { "colMan3Type", "MakeGroupFormMan3Type" },
            { "colMan3Index", "MakeGroupFormMan3Index" },
        };

        private static readonly List<ComboBoxData> _MaleTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(ADVStep.MakeGroupFormat.MemberType.NotSelect, Util.GetResourcesString("MakeGroupTypeNotSelect")),
            new ComboBoxData(ADVStep.MakeGroupFormat.MemberType.Owner, Util.GetResourcesString("MakeGroupTypeOwner")),
            new ComboBoxData(ADVStep.MakeGroupFormat.MemberType.NPC, Util.GetResourcesString("MakeGroupTypeNPCMale")),
            new ComboBoxData(ADVStep.MakeGroupFormat.MemberType.Man,Util.GetResourcesString("MakeGroupTypeMan")),
        };

        private static readonly List<ComboBoxData> _FemaleTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(ADVStep.MakeGroupFormat.MemberType.NotSelect, Util.GetResourcesString("MakeGroupTypeNotSelect")),
            new ComboBoxData(ADVStep.MakeGroupFormat.MemberType.Maid,Util.GetResourcesString("MakeGroupTypeMaid")),
            new ComboBoxData(ADVStep.MakeGroupFormat.MemberType.NPC, Util.GetResourcesString("MakeGroupTypeNPCFemale")),
        };

        internal MakeGroupForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += MakeGroupForm_Load;

            _GroupList = ConvertStepDataToLocalList(stepData);

            InitDataGridView();
            InitControl(stepData);

            BindDataGrid();
        }

        private void InitDataGridView()
        {
            //further setup on the datagrid column

            colMan1Type.DataSource = _MaleTypeList;
            colMan1Type.DisplayMember = "DisplayText";
            colMan1Type.ValueMember = "DataKey";
            colMan1Type.DataPropertyName = "man1_type";

            colMan2Type.DataSource = _MaleTypeList;
            colMan2Type.DisplayMember = "DisplayText";
            colMan2Type.ValueMember = "DataKey";
            colMan2Type.DataPropertyName = "man2_type";

            colMan3Type.DataSource = _MaleTypeList;
            colMan3Type.DisplayMember = "DisplayText";
            colMan3Type.ValueMember = "DataKey";
            colMan3Type.DataPropertyName = "man3_type";

            colMaid1Type.DataSource = _FemaleTypeList;
            colMaid1Type.DisplayMember = "DisplayText";
            colMaid1Type.ValueMember = "DataKey";
            colMaid1Type.DataPropertyName = "maid1_type";

            colMaid2Type.DataSource = _FemaleTypeList;
            colMaid2Type.DisplayMember = "DisplayText";
            colMaid2Type.ValueMember = "DataKey";
            colMaid2Type.DataPropertyName = "maid2_type";
        }

        private void InitControl(ADVStep stepData)
        {

            int groupCount = 0;

            if (stepData != null)
                if (stepData.GroupFormat != null)
                    groupCount = stepData.GroupFormat.Count;

            cbNumOfGroup.SelectedIndex = groupCount;
        }

        private List<GroupData> ConvertStepDataToLocalList(ADVStep stepData)
        {
            List<GroupData> result = new List<GroupData>();

            if (stepData != null)
                if (stepData.GroupFormat != null)
                {
                    foreach (var data in stepData.GroupFormat)
                    {
                        GroupData groupData = new GroupData();
                        groupData.num = data.GroupIndex + 1;

                        if (data.Maid1 != null)
                        {
                            groupData.maid1_type = data.Maid1.Type;
                            groupData.maid1_index = data.Maid1.ArrayPosition + 1;
                        }
                        if (data.Maid2 != null)
                        {
                            groupData.maid2_type = data.Maid2.Type;
                            groupData.maid2_index = data.Maid2.ArrayPosition + 1;
                        }
                        if (data.Man1 != null)
                        {
                            groupData.man1_type = data.Man1.Type;
                            groupData.man1_index = data.Man1.ArrayPosition + 1;
                        }
                        if (data.Man2 != null)
                        {
                            groupData.man2_type = data.Man2.Type;
                            groupData.man2_index = data.Man2.ArrayPosition + 1;
                        }
                        if (data.Man3 != null)
                        {
                            groupData.man3_type = data.Man3.Type;
                            groupData.man3_index = data.Man3.ArrayPosition + 1;
                        }

                        result.Add(groupData);
                    }
                }

            return result;
        }

        private void MakeGroupForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("MakeGroupFormWindowName");

            foreach (DataGridViewColumn col in dgGroup.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();
        }

        private void cbNumOfGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            //Update the internal list while preserving existing data
            if (cb.SelectedIndex < _GroupList.Count)
            {
                var toRemove = _GroupList.Where(x => x.num > cb.SelectedIndex).ToList();
                foreach (var item in toRemove)
                {
                    _GroupList.Remove(item);
                }
            }
            else
            {
                for (int i = _GroupList.Count; i < cb.SelectedIndex; i++)
                {
                    var newRow = new GroupData();
                    newRow.num = i + 1;
                    _GroupList.Add(newRow);
                }
            }

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            var list = new BindingList<GroupData>(_GroupList);

            dgGroup.DataSource = list;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _NPCList into List<NPCFemaleData>
            List<ADVStep.MakeGroupFormat> resultList = new List<ADVStep.MakeGroupFormat>();

            foreach (var groupData in _GroupList)
            {
                ADVStep.MakeGroupFormat newItem = new ADVStep.MakeGroupFormat();
                newItem.GroupIndex = groupData.num - 1;

                if (groupData.maid1_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                {
                    newItem.Maid1 = new ADVStep.MakeGroupFormat.GroupMemberInfo();
                    newItem.Maid1.Type = groupData.maid1_type;
                    newItem.Maid1.ArrayPosition = groupData.maid1_index - 1;
                }
                if (groupData.maid2_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                {
                    newItem.Maid2 = new ADVStep.MakeGroupFormat.GroupMemberInfo();
                    newItem.Maid2.Type = groupData.maid2_type;
                    newItem.Maid2.ArrayPosition = groupData.maid2_index - 1;
                }

                if (groupData.man1_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                {
                    newItem.Man1 = new ADVStep.MakeGroupFormat.GroupMemberInfo();
                    newItem.Man1.Type = groupData.man1_type;
                    newItem.Man1.ArrayPosition = groupData.man1_index - 1;
                }
                if (groupData.man2_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                {
                    newItem.Man2 = new ADVStep.MakeGroupFormat.GroupMemberInfo();
                    newItem.Man2.Type = groupData.man2_type;
                    newItem.Man2.ArrayPosition = groupData.man2_index - 1;
                }
                if (groupData.man3_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                {
                    newItem.Man3 = new ADVStep.MakeGroupFormat.GroupMemberInfo();
                    newItem.Man3.Type = groupData.man3_type;
                    newItem.Man3.ArrayPosition = groupData.man3_index - 1;
                }

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

            dgGroup.Refresh();
        }


        public class GroupData
        {
            public int num { get; set; }                //require user to input in this form
            public string group_type { get; set; } = Util.GetResourcesString("GroupTypeInvalid");
            public string maid1_type { get; set; } = "";
            public int maid1_index { get; set; } = 1;
            public string maid2_type { get; set; } = "";
            public int maid2_index { get; set; } = 1;
            public string man1_type { get; set; } = "";
            public int man1_index { get; set; } = 1;
            public string man2_type { get; set; } = "";
            public int man2_index { get; set; } = 1;
            public string man3_type { get; set; } = "";
            public int man3_index { get; set; } = 1;
        }

        private void dgNPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            CheckGroupTypeChanged(e.RowIndex);
        }


        private void dgNPC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = dgGroup.Columns[dgGroup.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                dgGroup.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgNPC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgGroup.CancelEdit();
            dgGroup.RefreshEdit();
            e.Cancel = true;
        }

        private void CheckGroupTypeChanged(int index)
        {
            var group = _GroupList[index];
            int maleCount = 0;
            int femaleCount = 0;

            if (group.maid1_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                femaleCount++;
            if (group.maid2_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                femaleCount++;
            if (group.man1_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                maleCount++;
            if (group.man2_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                maleCount++;
            if (group.man3_type != ADVStep.MakeGroupFormat.MemberType.NotSelect)
                maleCount++;

            if (femaleCount == 2 && maleCount == 1)
                group.group_type = Util.GetResourcesString("GroupTypeFFM");
            else if (femaleCount == 1 && maleCount == 2)
                group.group_type = Util.GetResourcesString("GroupTypeMMF" );
            else if (femaleCount == 1 && maleCount == 3)
                group.group_type = Util.GetResourcesString("GroupTypeMMMF");
            else if (femaleCount == 1 && maleCount == 1)
                group.group_type = Util.GetResourcesString("GroupTypeMF" );
            else if (femaleCount == 2 && maleCount == 0)
                group.group_type = Util.GetResourcesString("GroupTypeFF" );
            else
                group.group_type = Util.GetResourcesString("GroupTypeInvalid");

            dgGroup.Refresh();
        }

        
    }
}

