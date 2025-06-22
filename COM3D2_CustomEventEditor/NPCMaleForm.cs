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
using static COM3D2_CustomEventEditor.StepItem;

namespace COM3D2_CustomEventEditor
{
    public partial class NPCMaleForm : Form, ILocalizable
    {
        private List<NPCItem> _NPCList = new List<NPCItem>();

        private const int COL_INDEX_COLOR_PICK_BUTTON = 0;
        private const int COL_INDEX_NAME = 2;
        private const int COL_INDEX_FIRST_NAME = 3;
        private const int COL_INDEX_LAST_NAME = 4;
        private const int COL_INDEX_NICK_NAME = 5;
        private const int COL_INDEX_WAY_TO_CALL = 6;
        private const int COL_INDEX_HEAD = 7;
        private const int COL_INDEX_CLOTHED = 8;
        private const int COL_INDEX_NUDE = 9;
        private const int COL_INDEX_BODY_SIZE = 10;
        private const int COL_INDEX_COLOR = 11;


        internal delegate void FormUpdateCompleteEventHandler(List<ADVStep.CharaInit.NPCMaleData> result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;



        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colNum", "NPCFormNPCNo" },
            { "colName", "NPCFormName" },
            { "colFirstName", "NPCFormFirstName" },
            { "colLastName", "NPCFormLastName" },
            { "colNickName", "NPCFormNickName" },
            { "colWayToCall", "NPCFormWayToCall" },

            { "colHead", "NPCMaleFormHead" },
            { "colClothed", "NPCMaleFormClothed" },
            { "colNude", "NPCMaleFormNude" },
            { "colBodySize", "NPCMaleFormBodySize" },
            { "colColor", "NPCMaleFormColor" },
        };

        private static readonly List<ComboBoxData> _WayToCallOptions = new List<ComboBoxData>()
        {
            new ComboBoxData(Enum.GetName(ModNPC.CallType.FirstName), Util.GetResourcesString("NPCFormWayToCallFirstName")),
            new ComboBoxData(Enum.GetName(ModNPC.CallType.LastName), Util.GetResourcesString("NPCFormWayToCallLastName")),
            new ComboBoxData(Enum.GetName(ModNPC.CallType.NickName), Util.GetResourcesString("NPCFormWayToCallNickName")),
        };

        internal NPCMaleForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += NPCMaleForm_Load;

            _NPCList = ConvertStepDataToLocalList(stepData);

            InitDataGridView();
            InitControl(stepData);

            BindDataGrid();
        }

        private void InitDataGridView()
        {
            //further setup on the datagrid column
            colWayToCall.DataSource = _WayToCallOptions;
            colWayToCall.DisplayMember = "DisplayText";
            colWayToCall.ValueMember = "DataKey";
            colWayToCall.DataPropertyName = "way_to_call";

            colPickColor.Text = Util.GetResourcesString("PickColor");
        }

        private void InitControl(ADVStep stepData)
        {
            int npcNum = 0;

            if (stepData != null)
                if (stepData.CharaInitData != null)
                    if (stepData.CharaInitData.NPCMale != null)
                        npcNum = stepData.CharaInitData.NPCMale.Count;

            cbNumOfNPC.SelectedIndex = npcNum;
        }

        private List<NPCItem> ConvertStepDataToLocalList(ADVStep stepData)
        {
            List<NPCItem> result = new List<NPCItem>();

            int index = 1;
            if (stepData != null)
                if (stepData.CharaInitData != null)
                    if (stepData.CharaInitData.NPCFemale != null)
                    {
                        foreach (var data in stepData.CharaInitData.NPCMale)
                        {
                            NPCItem npc = new NPCItem();
                            npc.num = index;

                            npc.first_name = data.MaleData.FirstName;
                            npc.last_name = data.MaleData.LastName;
                            npc.nick_name = data.MaleData.NickName;
                            npc.way_to_call = Enum.GetName(data.MaleData.WayToCall);
                            npc.head = data.MaleData.Head;
                            npc.clothed = data.MaleData.Clothed;
                            npc.nude = data.MaleData.Nude;
                            npc.body_size = data.MaleData.BodySize;
                            if (!string.IsNullOrEmpty( data.MaleData.HexColor))
                                npc.color = "#" + data.MaleData.HexColor;

                            index++;
                            result.Add(npc);
                        }
                    }

            return result;
        }

        private void NPCMaleForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("NPCMaleFormWindowName");

            foreach (DataGridViewColumn col in dgNPC.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();
        }

        private void cbNumOfNPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            //Update the internal list while preserving existing data
            if (cb.SelectedIndex < _NPCList.Count)
            {
                var toRemove = _NPCList.Where(x => x.num > cb.SelectedIndex).ToList();
                foreach (var item in toRemove)
                {
                    _NPCList.Remove(item);
                }
            }
            else
            {
                for (int i = _NPCList.Count; i < cb.SelectedIndex; i++)
                {
                    var newRow = new NPCItem();
                    newRow.num = i + 1;
                    _NPCList.Add(newRow);
                }
            }

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            var list = new BindingList<NPCItem>(_NPCList);

            dgNPC.DataSource = list;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _NPCList into List<NPCFemaleData>
            List<ADVStep.CharaInit.NPCMaleData> resultList = new List<ADVStep.CharaInit.NPCMaleData>();

            foreach (var npc in _NPCList)
            {
                ADVStep.CharaInit.NPCMaleData newItem = new ADVStep.CharaInit.NPCMaleData();
                newItem.Index = npc.num - 1;

                newItem.MaleData = new ModNPCMale();
                newItem.MaleData.FirstName = npc.first_name;
                newItem.MaleData.LastName = npc.last_name;
                newItem.MaleData.NickName = npc.nick_name;
                Enum.TryParse(npc.way_to_call, out newItem.MaleData.WayToCall);

                newItem.MaleData.Head = npc.head;
                newItem.MaleData.Clothed = npc.clothed;
                newItem.MaleData.Nude = npc.nude;
                newItem.MaleData.BodySize = npc.body_size;
                if (!string.IsNullOrEmpty(npc.color))
                    newItem.MaleData.HexColor = npc.color.Trim('#');

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
                    //Color pick 
                    var result = colorDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        dgNPC.CurrentRow.Cells[COL_INDEX_COLOR].Value = "#"
                            + colorDialog.Color.A.ToString("X2")
                            + colorDialog.Color.R.ToString("X2")
                            + colorDialog.Color.G.ToString("X2")
                            + colorDialog.Color.B.ToString("X2");
                    }
                }
            }

            dgNPC.Refresh();
        }


        public class NPCItem
        {
            public int num { get; set; }
            public string name { get; set; }            //for display purpose
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string nick_name { get; set; }
            public string way_to_call { get; set; }
            public string head { get; set; }
            public string clothed { get; set; }
            public string nude { get; set; }
            public int body_size { get; set; }       //Range: [0-100]
            public string color { get; set; }       //ARGB in hex
        }

        private void dgNPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == COL_INDEX_FIRST_NAME || e.ColumnIndex == COL_INDEX_LAST_NAME)
            {
                //Update the name column too

                var firstName = dgNPC[COL_INDEX_FIRST_NAME, e.RowIndex].Value;
                var lastName = dgNPC[COL_INDEX_LAST_NAME, e.RowIndex].Value;
                dgNPC[COL_INDEX_NAME, e.RowIndex].Value = firstName + " " + lastName;

            }
        }


        private void dgNPC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = dgNPC.Columns[dgNPC.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                dgNPC.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgNPC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgNPC.CancelEdit();
            dgNPC.RefreshEdit();
            e.Cancel = true;
        }
    }
}

