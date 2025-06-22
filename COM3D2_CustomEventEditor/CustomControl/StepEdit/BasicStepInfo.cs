using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    //This user control is for displaying the common info like Step ID, Step Name etc
    public partial class BasicStepInfo : UserControl
    {
        public static readonly List<ComboBoxData> WaitingTypeList = new List<ComboBoxData>()
        {
            new ComboBoxData(Constant.WaitingType.Auto, Util.GetResourcesString("WaitingTypeAuto")),
            new ComboBoxData(Constant.WaitingType.Click, Util.GetResourcesString("WaitingTypeClick")),
            new ComboBoxData(Constant.WaitingType.CameraPan,Util.GetResourcesString("WaitingTypeCameraPan")),
            new ComboBoxData(Constant.WaitingType.FadeOut,Util.GetResourcesString("WaitingTypeFadeOut")),
            new ComboBoxData(Constant.WaitingType.InputChoice,Util.GetResourcesString("WaitingTypeInputChoice")),

            new ComboBoxData(Constant.WaitingType.Branching, Util.GetResourcesString("WaitingTypeBranching")),
            new ComboBoxData(Constant.WaitingType.TimeWait,Util.GetResourcesString("WaitingTypeTimeWait")),
        };

        ADVStep _StepData;
        private ToolTip _ErrorToolTip;

        public BasicStepInfo()
        {
            InitializeComponent();
        }

        public string StepID
        {
            get { return txtStepID.Texts; }
            set { txtStepID.Texts = value; }
        }
        public string StepName
        {
            get { return txtStepName.Texts; }
            set { txtStepName.Texts = value; }
        }
        public string StepNextID
        {
            get { return txtNextStepID.Texts; }
            set { txtNextStepID.Texts = value; }
        }
        public string WaitingType
        {
            get { return cbWaitingType.SelectedValue.ToString(); }
            set { cbWaitingType.SelectedValue = value; }
        }

        private void InitDropDown()
        {
            cbWaitingType.DataSource = WaitingTypeList;
            cbWaitingType.SelectedValue = _StepData.WaitingType;
        }

        internal void LoadData(ADVStep stepData)
        {
            txtNextStepID.Enabled = true;
            cbWaitingType.Enabled = true;

            _StepData = stepData;
            StepID = stepData.ID;
            StepNextID = stepData.NextStepID;
            StepName = stepData.Name;
            WaitingType = stepData.WaitingType;

            InitDropDown();

            if (stepData.Type == Constant.ADVType.ADVEnd)
            {
                txtNextStepID.Enabled = false;
                cbWaitingType.Enabled = false;
            }else if (stepData.Type == Constant.ADVType.TimeWait)
            {
                cbWaitingType.Enabled = false;
            }
            else if (stepData.Type == Constant.ADVType.ShowChoiceList)
            {
                cbWaitingType.Enabled = false;
            }
            else if (stepData.Type == Constant.ADVType.Branch)
            {
                cbWaitingType.Enabled = false;
                cbWaitingType.Enabled = false;
            }
        }

        internal void SaveData()
        {
            _StepData.ID = txtStepID.Texts;
            _StepData.Name = txtStepName.Texts;
            _StepData.NextStepID = txtNextStepID.Texts;
            if (_StepData.Type != Constant.ADVType.ADVEnd)
                _StepData.WaitingType = cbWaitingType.SelectedValue.ToString();

        }

        private void txtStepID__TextChanged(object sender, EventArgs e)
        {
            _StepData.ID = txtStepID.Texts;
            UpdateStepItem();
        }

        private void txtStepName__TextChanged(object sender, EventArgs e)
        {
            _StepData.Name = txtStepName.Texts;
            UpdateStepItem();
        }

        private void UpdateStepItem()
        {
            var stepItem = Global.AllSteps.Where(x => x.StepData == _StepData).First();
            stepItem.UpdateStepText();
        }

        private void txtStepID_Validating(object sender, CancelEventArgs e)
        {
            RemoveToolTip();

            e.Cancel = Global.AllSteps.Exists(x => x.StepData.ID == txtStepID.Texts && x.StepData != _StepData) && Visible;
            if (e.Cancel)
            {
                _ErrorToolTip = Util.ShowErrorMessage(txtStepID, Util.GetResourcesString("InvalidInput"), Util.GetResourcesString("ErrorDuplicateStepID"));
            }
        }


        public void RemoveToolTip()
        {
            if (_ErrorToolTip != null)
                _ErrorToolTip.Dispose();
        }


    }
}
