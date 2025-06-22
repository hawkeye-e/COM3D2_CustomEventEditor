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
    public partial class AddObjectForm : Form, ILocalizable
    {
        private List<ObjectData> _ObjectList = new List<ObjectData>();

        internal delegate void FormUpdateCompleteEventHandler(List<ADVStep.WorldObject> result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;

        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colNum", "AddObjectFormGroupNo" },
            { "colObjectID", "AddObjectFormObjectID" },
            { "colSrc", "AddObjectFormSrc" },
            { "colPos", "AddObjectFormPos" },
            { "colRot", "AddObjectFormRot" },
            { "colScale", "AddObjectFormScale" },
        };


        internal AddObjectForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += MakeGroupForm_Load;

            _ObjectList = ConvertStepDataToLocalList(stepData);

            InitControl(stepData);

            BindDataGrid();
        }

        private void InitControl(ADVStep stepData)
        {
            int groupCount = 0;

            if (stepData != null)
                if (stepData.WorldObjectData != null)
                    groupCount = stepData.WorldObjectData.Count;

            cbNumOfObject.SelectedIndex = groupCount;
        }

        private List<ObjectData> ConvertStepDataToLocalList(ADVStep stepData)
        {
            List<ObjectData> result = new List<ObjectData>();

            if (stepData != null)
                if (stepData.WorldObjectData != null)
                {
                    int index = 1;
                    foreach (var data in stepData.WorldObjectData)
                    {
                        ObjectData groupData = new ObjectData();
                        groupData.num = index;

                        groupData.object_id = data.ObjectID;
                        groupData.src = data.Src;
                        if (data.PosRot != null)
                        {
                            groupData.pos = data.PosRot.PosString;
                            groupData.rot = data.PosRot.RotString;
                        }
                        groupData.scale = data.Scale;

                        result.Add(groupData);
                        index++;
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
            this.Text = Util.GetResourcesString("AddObjectFormWindowName");

            foreach (DataGridViewColumn col in dgObject.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();
        }

        private void cbNumOfObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            //Update the internal list while preserving existing data
            if (cb.SelectedIndex < _ObjectList.Count)
            {
                var toRemove = _ObjectList.Where(x => x.num > cb.SelectedIndex).ToList();
                foreach (var item in toRemove)
                {
                    _ObjectList.Remove(item);
                }
            }
            else
            {
                for (int i = _ObjectList.Count; i < cb.SelectedIndex; i++)
                {
                    var newRow = new ObjectData();
                    newRow.num = i + 1;
                    _ObjectList.Add(newRow);
                }
            }

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            var list = new BindingList<ObjectData>(_ObjectList);

            dgObject.DataSource = list;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _NPCList into List<NPCFemaleData>
            List<ADVStep.WorldObject> resultList = new List<ADVStep.WorldObject>();

            foreach (var objectData in _ObjectList)
            {
                ADVStep.WorldObject newItem = new ADVStep.WorldObject();

                newItem.Src = objectData.src;
                newItem.ObjectID = objectData.object_id;
                newItem.PosRot = new PosRot();
                newItem.PosRot.PosString = objectData.pos;
                newItem.PosRot.RotString = objectData.rot;
                newItem.Scale = objectData.scale;

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

            dgObject.Refresh();
        }


        public class ObjectData
        {
            public int num { get; set; }                //require user to input in this form
            public string object_id { get; set; }
            public string src { get; set; }
            public string pos { get; set; }
            public string rot { get; set; }
            public float scale { get; set; } = 1;
           
        }

        private void dgNPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

        }


        private void dgNPC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = dgObject.Columns[dgObject.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                dgObject.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgNPC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgObject.CancelEdit();
            dgObject.RefreshEdit();
            e.Cancel = true;
        }

        
    }
}

