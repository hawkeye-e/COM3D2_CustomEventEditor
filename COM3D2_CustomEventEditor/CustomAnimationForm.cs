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
using static COM3D2_CustomEventEditor.StepItem;

namespace COM3D2_CustomEventEditor
{
    public partial class CustomAnimationForm : Form, ILocalizable
    {
        private List<CustomAnim> _CustomAnimList = new List<CustomAnim>();

        private const int COL_INDEX_SELECT_FILE_BUTTON = 0;
        private const int COL_INDEX_DELETE_BUTTON = 1;
        private const int COL_INDEX_KEY = 2;
        private const int COL_FILE_NAME = 3;


        internal delegate void FormUpdateCompleteEventHandler(List<ADVStep.CharaInit.CustomAnimation> result);
        internal event FormUpdateCompleteEventHandler OnFormCompleted;



        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colKey", "CustomAnimFormKey" },
            { "colFileName", "CustomAnimFormFileName" },
        };

        internal CustomAnimationForm(ADVStep stepData)
        {
            InitializeComponent();
            this.Load += NPCMaleForm_Load;

            _CustomAnimList = ConvertStepDataToLocalList(stepData);

            InitDataGridView();

            BindDataGrid();
        }

        private void InitDataGridView()
        {
            //further setup on the datagrid column
            

            colSelectFile.Text = Util.GetResourcesString("SelectFile");
            colDelete.Text = Util.GetResourcesString("Delete");
        }



        private List<CustomAnim> ConvertStepDataToLocalList(ADVStep stepData)
        {
            List<CustomAnim> result = new List<CustomAnim>();

            if (stepData != null)
                if (stepData.CharaInitData != null)
                    if (stepData.CharaInitData.CustomAnim != null)
                    {
                        foreach (var data in stepData.CharaInitData.CustomAnim)
                        {
                            CustomAnim anim = new CustomAnim();
                            anim.key = data.Key;
                            anim.file_name = data.FileName;
                            
                            result.Add(anim);
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
            this.Text = Util.GetResourcesString("CustomAnimFormWindowName");

            foreach (DataGridViewColumn col in dgCustomAnim.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();
        }


        private void BindDataGrid()
        {
            var list = new BindingList<CustomAnim>(_CustomAnimList);

            dgCustomAnim.DataSource = list;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Convert the _CustomAnimList into List<CustomAnimation>
            List<ADVStep.CharaInit.CustomAnimation> resultList = new List<ADVStep.CharaInit.CustomAnimation>();

            foreach (var anim in _CustomAnimList)
            {
                ADVStep.CharaInit.CustomAnimation newItem = new ADVStep.CharaInit.CustomAnimation();
                newItem.Key = anim.key;
                newItem.FileName = anim.file_name;
                
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
                    //Select File
                    var result = openFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        //copy the selected file to workspace
                        EditorFileManager.CopyFileToWorkSpace(openFileDialog.FileName, openFileDialog.SafeFileName);

                        dgCustomAnim.CurrentRow.Cells[COL_FILE_NAME].Value = openFileDialog.SafeFileName;
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    //delete row
                    dgCustomAnim.Rows.RemoveAt(e.RowIndex);
                }
            }

            dgCustomAnim.Refresh();
        }


        public class CustomAnim
        {
            public string key { get; set; }
            public string file_name { get; set; }            //for display purpose
        }

        private void dgNPC_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

        }


        private void dgNPC_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DataGridViewColumn col = dgCustomAnim.Columns[dgCustomAnim.CurrentCell.ColumnIndex];
            if (col is DataGridViewComboBoxColumn)
            {
                dgCustomAnim.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgNPC_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            dgCustomAnim.CancelEdit();
            dgCustomAnim.RefreshEdit();
            e.Cancel = true;
        }
    }
}

