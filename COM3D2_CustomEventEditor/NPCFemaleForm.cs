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
    public partial class NPCFemaleForm : Form, ILocalizable
    {
        private List<NPCItem> _NPCList = new List<NPCItem>();
        private List<OfficialNPC> _OfficialNPCList = new List<OfficialNPC>();
        private const string NPC_TYPE_OFFICIAL = "Official";
        private const string NPC_TYPE_CUSTOM = "Custom";

        private const int COL_INDEX_PRESET_V2_BUTTON = 0;
        private const int COL_INDEX_PRESET_V2_5_BUTTON = 1;
        private const int COL_INDEX_NAME = 3;
        private const int COL_INDEX_TYPE = 4;
        private const int COL_INDEX_NPC_KEY = 5;
        private const int COL_INDEX_FIRST_NAME = 6;
        private const int COL_INDEX_LAST_NAME = 7;
        private const int COL_INDEX_NICK_NAME = 8;
        private const int COL_INDEX_WAY_TO_CALL = 9;
        private const int COL_INDEX_PRESET_V2 = 10;
        private const int COL_INDEX_PRESET_V2_5 = 11;
        private const int COL_INDEX_VOICE_PITCH = 12;

        private bool _IsFileOpenerV2;

        internal delegate void FormUpdateCompleteEventHandler(List<ADVStep.CharaInit.NPCFemaleData> result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;


        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colNum", "NPCFormNPCNo" },
            { "colName", "NPCFormName" },
            { "colType", "NPCFemaleFormNPCType" },
            { "colKey", "NPCFemaleFormOfficalNPCLabel" },
            { "colFirstName", "NPCFormFirstName" },
            { "colLastName", "NPCFormLastName" },
            { "colNickName", "NPCFormNickName" },
            { "colWayToCall", "NPCFormWayToCall" },
            { "colPresetV2", "NPCFemaleFormPresetV2" },
            { "colPresetV2_5", "NPCFemaleFormPresetV2_5" },
            { "colVoicePitch", "NPCFemaleFormVoicePitch" },
        };

        private static readonly List<ComboBoxData> _NPCTypeOptions = new List<ComboBoxData>()
        {
            new ComboBoxData(NPC_TYPE_OFFICIAL, Util.GetResourcesString("NPCFormTypeOfficial")),
            new ComboBoxData(NPC_TYPE_CUSTOM, Util.GetResourcesString("NPCFormTypeCustom")),
        };

        private static readonly List<ComboBoxData> _WayToCallOptions = new List<ComboBoxData>()
        {
            new ComboBoxData(Enum.GetName(ModNPC.CallType.FirstName), Util.GetResourcesString("NPCFormWayToCallFirstName")),
            new ComboBoxData(Enum.GetName(ModNPC.CallType.LastName), Util.GetResourcesString("NPCFormWayToCallLastName")),
            new ComboBoxData(Enum.GetName(ModNPC.CallType.NickName), Util.GetResourcesString("NPCFormWayToCallNickName")),
        };

        internal NPCFemaleForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += NPCFemaleForm_Load;

            _NPCList = ConvertStepDataToLocalList(stepData);

            InitDataGridView();
            InitControl(stepData);

            BindDataGrid();
        }

        private void InitDataGridView()
        {
            //further setup on the datagrid column
            _OfficialNPCList = OfficialNPC.ReadCSVFile();
            colKey.DataSource = _OfficialNPCList;
            colKey.DisplayMember = "DisplayName";
            colKey.ValueMember = "Key";
            colKey.DataPropertyName = "key";
            //colKey.DataSource

            colType.DataSource = _NPCTypeOptions;
            colType.DisplayMember = "DisplayText";
            colType.ValueMember = "DataKey";
            colType.DataPropertyName = "type";

            colWayToCall.DataSource = _WayToCallOptions;
            colWayToCall.DisplayMember = "DisplayText";
            colWayToCall.ValueMember = "DataKey";
            colWayToCall.DataPropertyName = "way_to_call";

            colPresetV2Button.Text = Util.GetResourcesString("SelectFile");
            colPresetV2_5Button.Text = Util.GetResourcesString("SelectFile");
        }

        private void InitControl(ADVStep stepData)
        {
            int npcNum = 0;

            if (stepData != null)
                if (stepData.CharaInitData != null)
                    if (stepData.CharaInitData.NPCFemale != null)
                        npcNum = stepData.CharaInitData.NPCFemale.Count;

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
                        foreach (var data in stepData.CharaInitData.NPCFemale)
                        {
                            NPCItem npc = new NPCItem();
                            npc.num = index;
                            npc.type = Enum.GetName(data.Type);
                            if (data.Type == ADVStep.CharaInit.NPCFemaleData.NPCType.Official)
                            {
                                npc.key = data.Key;
                            }
                            else
                            {
                                npc.first_name = data.CustomData.FirstName;
                                npc.last_name = data.CustomData.LastName;
                                npc.nick_name = data.CustomData.NickName;
                                npc.way_to_call = Enum.GetName(data.CustomData.WayToCall);
                                npc.preset_v2 = data.CustomData.PresetFile.V2;
                                npc.preset_v2_5 = data.CustomData.PresetFile.V2_5;
                                npc.voice_pitch = data.CustomData.VoicePitch;
                            }

                            index++;
                            result.Add(npc);
                        }
                    }

            return result;
        }

        private void NPCFemaleForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("NPCFemaleFormWindowName");

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
                    newRow.type = Enum.GetName(ADVStep.CharaInit.NPCFemaleData.NPCType.Official);
                    _NPCList.Add(newRow);
                }
            }

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            var list = new BindingList<NPCItem>(_NPCList);

            dgNPC.DataSource = list;

            foreach (DataGridViewRow row in dgNPC.Rows)
            {
                bool isOfficialNPC = row.Cells[COL_INDEX_TYPE].Value.ToString() == NPC_TYPE_OFFICIAL;
                UpdateCellEditableStatusForRow(row.Index, isOfficialNPC);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _NPCList into List<NPCFemaleData>
            List<ADVStep.CharaInit.NPCFemaleData> resultList = new List<ADVStep.CharaInit.NPCFemaleData>();

            foreach(var npc in _NPCList)
            {
                ADVStep.CharaInit.NPCFemaleData newItem = new ADVStep.CharaInit.NPCFemaleData();
                newItem.Index = npc.num - 1;
                if (npc.type == NPC_TYPE_OFFICIAL) {
                    newItem.Type = ADVStep.CharaInit.NPCFemaleData.NPCType.Official;
                    newItem.Key = npc.key;
                }
                else
                {
                    newItem.Type = ADVStep.CharaInit.NPCFemaleData.NPCType.Custom;
                    newItem.CustomData = new ModNPCFemale();
                    newItem.CustomData.FirstName = npc.first_name;
                    newItem.CustomData.LastName = npc.last_name;
                    newItem.CustomData.NickName = npc.nick_name;
                    Enum.TryParse(npc.way_to_call, out newItem.CustomData.WayToCall);
                    newItem.CustomData.VoicePitch = npc.voice_pitch;
                    newItem.CustomData.PresetFile = new PresetFileDetail();
                    newItem.CustomData.PresetFile.V2_5 = npc.preset_v2_5;
                    newItem.CustomData.PresetFile.V2 = npc.preset_v2;
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
            Debug.WriteLine(e.RowIndex + " " + e.ColumnIndex);
            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == 0)
                {
                    //Preset V2 button
                    if (dgNPC[COL_INDEX_TYPE, e.RowIndex].Value.ToString() == NPC_TYPE_OFFICIAL)
                        return;

                    _IsFileOpenerV2 = true;
                    openFileDialog.ShowDialog(this);
                }
                else if (e.ColumnIndex == 1)
                {
                    //Preset V2.5 button
                    if (dgNPC[COL_INDEX_TYPE, e.RowIndex].Value.ToString() == NPC_TYPE_OFFICIAL)
                        return;
                    _IsFileOpenerV2 = false;
                    openFileDialog.ShowDialog(this);
                }
            }

            dgNPC.Refresh();
        }







        public class NPCItem
        {
            public int num { get; set; }
            public string name { get; set; }            //for display purpose
            public string type { get; set; }            //official / custom. 
            public string key { get; set; }             //official npc used only
            public string first_name { get; set; }      //custom npc
            public string last_name { get; set; }      //custom npc
            public string nick_name { get; set; }      //custom npc
            public string way_to_call { get; set; }      //custom npc
            public string preset_v2 { get; set; }      //custom npc
            public string preset_v2_5 { get; set; }      //custom npc
            public int voice_pitch { get; set; } = 50;      //custom npc
        }

        private void dgNPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == COL_INDEX_TYPE)
            {
                /* NPC Type Changed */
                bool isOfficialNPC = dgNPC[e.ColumnIndex, e.RowIndex].Value.ToString() == NPC_TYPE_OFFICIAL;

                //Update the cell readonly status
                UpdateCellEditableStatusForRow(e.RowIndex, isOfficialNPC);

                //clear the value
                if (!isOfficialNPC)
                    dgNPC[COL_INDEX_NPC_KEY, e.RowIndex].Value = "";



            }
            else if (e.ColumnIndex == COL_INDEX_NPC_KEY)
            {
                /* Official NPC changed */
                var npc = _OfficialNPCList.Where(x => x.Key == dgNPC[e.ColumnIndex, e.RowIndex].Value).FirstOrDefault();
                if (npc != null)
                {
                    dgNPC[COL_INDEX_NAME, e.RowIndex].Value = npc.DisplayName;
                }

            }
            else if (e.ColumnIndex == COL_INDEX_FIRST_NAME || e.ColumnIndex == COL_INDEX_LAST_NAME)
            {
                //Update the name column too

                var firstName = dgNPC[COL_INDEX_FIRST_NAME, e.RowIndex].Value;
                var lastName = dgNPC[COL_INDEX_LAST_NAME, e.RowIndex].Value;
                dgNPC[COL_INDEX_NAME, e.RowIndex].Value = firstName + " " + lastName;
                
            }
        }

        private void UpdateCellEditableStatusForRow(int rowIndex, bool isOfficialNPC)
        {
            dgNPC[COL_INDEX_NPC_KEY, rowIndex].ReadOnly = !isOfficialNPC;
            dgNPC[COL_INDEX_FIRST_NAME, rowIndex].ReadOnly = isOfficialNPC;
            dgNPC[COL_INDEX_LAST_NAME, rowIndex].ReadOnly = isOfficialNPC;
            dgNPC[COL_INDEX_NICK_NAME, rowIndex].ReadOnly = isOfficialNPC;
            dgNPC[COL_INDEX_WAY_TO_CALL, rowIndex].ReadOnly = isOfficialNPC;
            dgNPC[COL_INDEX_VOICE_PITCH, rowIndex].ReadOnly = isOfficialNPC;

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

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            //copy the file to workspace
            EditorFileManager.CopyFileToWorkSpace(openFileDialog.FileName, openFileDialog.SafeFileName);

            if (_IsFileOpenerV2)
                dgNPC.CurrentRow.Cells[COL_INDEX_PRESET_V2].Value = openFileDialog.SafeFileName;
            else
                dgNPC.CurrentRow.Cells[COL_INDEX_PRESET_V2_5].Value = openFileDialog.SafeFileName;
        }
    }
}

