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
    public partial class WorldObjectStep : StepEditBase
    {
        List<ADVStep.WorldObject> _WorldObjectResult = new List<ADVStep.WorldObject>();
        private bool _isInit = true;

        public WorldObjectStep()
        {
            InitializeComponent();
        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;

            rbAddObjects.Checked = _StepData.Type == Constant.ADVType.AddObject;
            rbRemoveObjects.Checked = _StepData.Type == Constant.ADVType.RemoveObject;

            if (rbAddObjects.Checked)
            {
                if (_StepData.WorldObjectData != null)
                {
                    _WorldObjectResult = _StepData.WorldObjectData;
                    lblAddObjectCountValue.Text = _StepData.WorldObjectData.Count.ToString();
                }
            }
            else
            {
                if (_StepData.WorldObjectData != null)
                {
                    txtRemoveObjects.Texts = String.Join(Environment.NewLine, _StepData.WorldObjectData.Select(x => x.ObjectID).ToArray());
                }
            }
            
            UpdatePanelVisibility();

        }


        internal void LoadData(ADVStep stepData)
        {
            _isInit = true;
            _WorldObjectResult = null;

            rbAddObjects.Checked = true;
            lblAddObjectCountValue.Text = "0";
            txtRemoveObjects.Texts = "";
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

            if (rbAddObjects.Checked)
            {
                //Make Group
                _StepData.WorldObjectData = _WorldObjectResult;
            }
            else
            {
                //Dismiss Group
                List<ADVStep.WorldObject> newData = new List<ADVStep.WorldObject>();
                string[] split = txtRemoveObjects.Texts.Split(Environment.NewLine);
                foreach (string s in split)
                {
                    if (!string.IsNullOrEmpty(s.Trim()))
                    {
                        ADVStep.WorldObject item = new ADVStep.WorldObject();
                        item.ObjectID = s;
                        newData.Add(item);
                    }
                }
                _StepData.WorldObjectData = newData;
            }

        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        public void WorldObjectTypeUpdate()
        {
            StepItem.StepType stepType = rbAddObjects.Checked ? StepItem.StepType.AddObject : StepItem.StepType.RemoveObject;
            var stepItem = Global.AllSteps.Where(x => x.StepData == _StepData).First();
            stepItem.SetStepType(stepType);
        }

        private void UpdatePanelVisibility()
        {
            pnlAddObjects.Visible = rbAddObjects.Checked;
            pnlRemoveObjects.Visible = rbRemoveObjects.Checked;
        }

        private void rbAddObjects_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;

            _StepData.Type = Constant.ADVType.AddObject;
            WorldObjectTypeUpdate();
            UpdatePanelVisibility();
        }

        private void rbRemoveObject_CheckedChanged(object sender, EventArgs e)
        {
            if (_isInit) return;

            _StepData.Type = Constant.ADVType.RemoveObject;
            WorldObjectTypeUpdate();
            UpdatePanelVisibility();
        }

        private void btnAddObjects_Click(object sender, EventArgs e)
        {
            AddObjectForm form = new AddObjectForm(_StepData);
            form.OnFormCompleted += AddObjectForm_OnFormCompleted;
            form.ShowDialog();
        }

        private void AddObjectForm_OnFormCompleted(List<ADVStep.WorldObject> result)
        {
            _WorldObjectResult = result;
            SaveData();
            lblAddObjectCountValue.Text = _WorldObjectResult.Count.ToString();
        }


    }




}
