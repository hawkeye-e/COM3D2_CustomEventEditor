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
    public partial class CharaInitStep : StepEditBase
    {
        private List<ADVStep.CharaInit.NPCFemaleData> _FemaleNPCData = new List<ADVStep.CharaInit.NPCFemaleData>();
        private List<ADVStep.CharaInit.NPCMaleData> _MaleNPCData = new List<ADVStep.CharaInit.NPCMaleData>();
        private List<ADVStep.CharaInit.CustomAnimation> _CustomAnimData = new List<ADVStep.CharaInit.CustomAnimation>();

        public CharaInitStep()
        {
            InitializeComponent();


        }


        private void InitControlData()
        {

            if (_StepData == null)
                return;
            if (_StepData.CharaInitData == null)
                return;

            cbManCount.SelectedIndex = _StepData.CharaInitData.ManRequired;
            if (_StepData.CharaInitData.ValidManType != null)
            {
                chkManTypeYoungMan.Checked = _StepData.CharaInitData.ValidManType.Contains(Constant.DefinedManTypeCode.YoungMan);
                chkManTypeYanki.Checked = _StepData.CharaInitData.ValidManType.Contains(Constant.DefinedManTypeCode.Yanki);
                chkManTypeMiddleAged.Checked = _StepData.CharaInitData.ValidManType.Contains(Constant.DefinedManTypeCode.MiddleAged);
                chkManTypeOtaku.Checked = _StepData.CharaInitData.ValidManType.Contains(Constant.DefinedManTypeCode.Otaku);
                chkManTypeShota.Checked = _StepData.CharaInitData.ValidManType.Contains(Constant.DefinedManTypeCode.Shota);
            }

            if (_StepData.CharaInitData.NPCFemale != null)
                _FemaleNPCData = _StepData.CharaInitData.NPCFemale;
            if (_StepData.CharaInitData.NPCMale != null)
                _MaleNPCData = _StepData.CharaInitData.NPCMale;
            if ( _StepData.CharaInitData.CustomAnim != null)
                _CustomAnimData = _StepData.CharaInitData.CustomAnim;

            UpdateCountNumber();
        }


        internal void LoadData(ADVStep stepData)
        {
            cbManCount.SelectedIndex = 0;
            lblFemaleNPCCount.Text = "0";
            lblMaleNPCCount.Text = "0";
            lblCustomAnimCount.Text = "0";

            _StepData = stepData;

            ucBasicStepInfo.LoadData(stepData);
            InitControlData();
        }

        public override void SaveData()
        {
            if (_StepData == null)
                return;

            ucBasicStepInfo.SaveData();

            ADVStep.CharaInit newData = new ADVStep.CharaInit();
            newData.ManRequired = cbManCount.SelectedIndex;
            newData.ValidManType = new List<string>();
            if (chkManTypeYoungMan.Checked)
                newData.ValidManType.Add(Constant.DefinedManTypeCode.YoungMan);
            if (chkManTypeYanki.Checked)
                newData.ValidManType.Add(Constant.DefinedManTypeCode.Yanki);
            if (chkManTypeMiddleAged.Checked)
                newData.ValidManType.Add(Constant.DefinedManTypeCode.MiddleAged);
            if (chkManTypeOtaku.Checked)
                newData.ValidManType.Add(Constant.DefinedManTypeCode.Otaku);
            if (chkManTypeShota.Checked)
                newData.ValidManType.Add(Constant.DefinedManTypeCode.Shota);

            newData.NPCFemale = _FemaleNPCData;
            newData.NPCMale = _MaleNPCData;
            newData.CustomAnim = _CustomAnimData;

            _StepData.CharaInitData = newData;
        }

        public override void ReloadData()
        {
            LoadData(_StepData);
        }

        private void btnEditNPC_Click(object sender, EventArgs e)
        {
            NPCFemaleForm form = new NPCFemaleForm(_StepData);
            form.OnFormCompleted += NPCFemaleForm_OnFormCompleted;
            form.ShowDialog();
        }

        private void NPCFemaleForm_OnFormCompleted(List<ADVStep.CharaInit.NPCFemaleData> result)
        {
            _FemaleNPCData = result;
            SaveData();
            UpdateCountNumber();
        }

        private void UpdateCountNumber()
        {
            lblFemaleNPCCount.Text = _FemaleNPCData.Count.ToString();
            lblMaleNPCCount.Text = _MaleNPCData.Count.ToString();
            lblCustomAnimCount.Text = _CustomAnimData.Count.ToString();
        }

        private void btnEditNPCMale_Click(object sender, EventArgs e)
        {
            NPCMaleForm form = new NPCMaleForm(_StepData);
            form.OnFormCompleted += NPCMaleForm_OnFormCompleted;
            form.ShowDialog();
        }

        private void NPCMaleForm_OnFormCompleted(List<ADVStep.CharaInit.NPCMaleData> result)
        {
            _MaleNPCData = result;
            SaveData();
            UpdateCountNumber();
        }

        private void btnEditCustomAnim_Click(object sender, EventArgs e)
        {
            CustomAnimationForm form = new CustomAnimationForm(_StepData);
            form.OnFormCompleted += CustomAnimForm_OnFormCompleted;
            form.ShowDialog();
        }

        private void CustomAnimForm_OnFormCompleted(List<ADVStep.CharaInit.CustomAnimation> result)
        {
            _CustomAnimData = result;
            SaveData();
            UpdateCountNumber();
        }
    }




}
