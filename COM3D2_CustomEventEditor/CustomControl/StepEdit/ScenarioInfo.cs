using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    public partial class ScenarioInfo : StepEditBase
    {

        public ScenarioInfo() : base()
        {
            InitializeComponent();
        }

        public void ShowPanel()
        {
            LoadData();
            Visible = true;
        }

        public void HidePanel() {  Visible = false; }

        public void LoadData()
        {
            //Set the data to the textbox etc
            txtTitle.Texts = Global.ScenarioDefinition.Title;
            txtEventContent.Texts = Global.ScenarioDefinition.EventContents;
            txtAuthor.Texts = Global.ScenarioDefinition.Author;
            txtLanguage.Texts = Global.ScenarioDefinition.Language;

            rbIconLove.Checked = Global.ScenarioDefinition.Icon == "event_love_icon";
            rbIconNTR.Checked = Global.ScenarioDefinition.Icon == "event_icon_ntr";
            rbIconNPC.Checked = Global.ScenarioDefinition.Icon == "event_npc_icon";
            rbIconIdol.Checked = Global.ScenarioDefinition.Icon == "event_idol_icon";
            rbIconExtra.Checked = Global.ScenarioDefinition.Icon == "event_extra_icon";
        }

        public override void SaveData()
        {
            //The maid requirement is handled in another form so no need to take care of them here
            Global.ScenarioDefinition.Title = txtTitle.Texts;
            Global.ScenarioDefinition.EventContents = txtEventContent.Texts;
            Global.ScenarioDefinition.Author = txtAuthor.Texts;
            Global.ScenarioDefinition.Language = txtLanguage.Texts;

            if (rbIconLove.Checked)
                Global.ScenarioDefinition.Icon = "event_love_icon";
            else if (rbIconNTR.Checked)
                Global.ScenarioDefinition.Icon = "event_icon_ntr";
            else if (rbIconNPC.Checked)
                Global.ScenarioDefinition.Icon = "event_npc_icon";
            else if (rbIconIdol.Checked)
                Global.ScenarioDefinition.Icon = "event_idol_icon";
            else if (rbIconExtra.Checked)
                Global.ScenarioDefinition.Icon = "event_extra_icon";
        }

        public override void ReloadData()
        {
            LoadData();
        }


        private void btnMaidRequirement_Click(object sender, EventArgs e)
        {
            PersonalityForm form = new PersonalityForm();
            form.ShowDialog();
        }

    }
}
