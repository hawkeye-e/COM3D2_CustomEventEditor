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
    public partial class PersonalityForm : Form, ILocalizable
    {
        private List<PersonalitySelection> _MaidData;

        //Key: Column Name, Value: Resources Key
        private static readonly Dictionary<string, string> _GridColumnHeaderTranslationKeys = new Dictionary<string, string>()
        {
            { "colNum", "PFormMaidNo" },
            { "colPure", "PersonalityPure" },
            { "colPride", "PersonalityPride" },
            { "colCool", "PersonalityCool" },
            { "colYandere", "PersonalityYandere" },
            { "colAnesan", "PersonalityAnesan" },
            { "colGenki", "PersonalityGenki" },
            { "colSadist", "PersonalitySadist" },
            { "colMuku", "PersonalityMuku" },
            { "colMajime", "PersonalityMajime" },
            { "colRindere", "PersonalityRindere" },
            { "colSilent", "PersonalitySilent" },
            { "colDevilish", "PersonalityDevilish" },
            { "colLadylike", "PersonalityLadylike" },
            { "colSecretary", "PersonalitySecretary" },
            { "colSister", "PersonalitySister" },
            { "colCurtness", "PersonalityCurtness" },
            { "colMissy", "PersonalityMissy" },
            { "colChildhood", "PersonalityChildhood" },
            { "colMasochist", "PersonalityMasochist" },
            { "colCunning", "PersonalityCunning" },
            { "colFriendly", "PersonalityFriendly" },
            { "colDame", "PersonalityDame" },
            { "colGyaru", "PersonalityGyaru" },
        };

        public PersonalityForm()
        {
            InitializeComponent();
            this.Load += PersonalityForm_Load;

            cbNumOfMaid.SelectedIndex = Global.ScenarioDefinition.MaidRequirement.Count;
            
            BindDataGrid();
        }

        private void PersonalityForm_Load(object? sender, EventArgs e)
        {
            Localize();
        }

        public void Localize()
        {
            this.Text = Util.GetResourcesString("PFormWindowName");

            foreach(DataGridViewColumn col in dgMaids.Columns)
            {
                if (_GridColumnHeaderTranslationKeys.ContainsKey(col.Name))
                    col.HeaderText = Util.GetResourcesString(_GridColumnHeaderTranslationKeys[col.Name]);
            }

            Controls.LocalizeCollection();

        }

        private void cbNumOfMaid_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;

            //Update the maid list array while preserving existing data
            if (cb.SelectedIndex < Global.ScenarioDefinition.MaidRequirement.Count)
            {
                var toRemove = Global.ScenarioDefinition.MaidRequirement.Where(x => x.IndexPosition >= cb.SelectedIndex).ToList();
                foreach (var item in toRemove)
                {
                    Global.ScenarioDefinition.MaidRequirement.Remove(item);
                }
            }
            else
            {
                for (int i = Global.ScenarioDefinition.MaidRequirement.Count; i < cb.SelectedIndex; i++)
                {
                    var newRow = new ScenarioDefinition.MaidRequirementInfo();
                    newRow.IndexPosition = i;
                    Global.ScenarioDefinition.MaidRequirement.Add(newRow);
                }
            }
            Global.ScenarioDefinition.MaidRequirement = Global.ScenarioDefinition.MaidRequirement.OrderBy(x => x.IndexPosition).ToList();

            BindDataGrid();
        }

        private void BindDataGrid()
        {
            _MaidData = ConvertToDataBindingSource(Global.ScenarioDefinition.MaidRequirement);

            dgMaids.DataSource = _MaidData;
        }

        private List<PersonalitySelection> ConvertToDataBindingSource(List<ScenarioDefinition.MaidRequirementInfo> infos)
        {
            List<PersonalitySelection> result = new List<PersonalitySelection>();

            foreach (var info in infos)
            {
                PersonalitySelection item = new PersonalitySelection();
                item.num = info.IndexPosition + 1;
                item.pure = info.PersonalityID.Contains(10);
                item.cool = info.PersonalityID.Contains(20);
                item.pride = info.PersonalityID.Contains(30);
                item.yandere = info.PersonalityID.Contains(40);
                item.anesan = info.PersonalityID.Contains(50);
                item.genki = info.PersonalityID.Contains(60);
                item.sadist = info.PersonalityID.Contains(70);
                item.muku = info.PersonalityID.Contains(80);
                item.majime = info.PersonalityID.Contains(90);
                item.rindere = info.PersonalityID.Contains(100);
                item.silent = info.PersonalityID.Contains(110);
                item.devilish = info.PersonalityID.Contains(120);
                item.ladylike = info.PersonalityID.Contains(130);
                item.secretary = info.PersonalityID.Contains(140);
                item.sister = info.PersonalityID.Contains(150);
                item.curtness = info.PersonalityID.Contains(160);
                item.missy = info.PersonalityID.Contains(170);
                item.childhood = info.PersonalityID.Contains(180);
                item.masochist = info.PersonalityID.Contains(190);
                item.cunning = info.PersonalityID.Contains(200);
                item.friendly = info.PersonalityID.Contains(210);
                item.dame = info.PersonalityID.Contains(220);
                item.gyaru = info.PersonalityID.Contains(230);

                result.Add(item);
            }

            return result;
        }

        public class PersonalitySelection
        {
            public int num { get; set; } 
            public bool pure { get; set; }
            public bool pride { get; set; }
            public bool cool { get; set; }
            public bool yandere { get; set; }
            public bool anesan { get; set; }
            public bool genki { get; set; }
            public bool sadist { get; set; }
            public bool muku { get; set; }
            public bool majime { get; set; }
            public bool rindere { get; set; }
            public bool silent { get; set; }
            public bool devilish { get; set; }
            public bool ladylike { get; set; }
            public bool secretary { get; set; }
            public bool sister { get; set; }
            public bool curtness { get; set; }
            public bool missy { get; set; }
            public bool childhood { get; set; }
            public bool masochist { get; set; }
            public bool cunning { get; set; }
            public bool friendly { get; set; }
            public bool dame { get; set; }
            public bool gyaru { get; set; }

            public void SetAllBoolean(bool value)
            {
                foreach (var bool_field in this.GetType().GetProperties()
                             .Where(x => x.PropertyType == false.GetType()))
                {
                    bool_field.SetValue(this, value);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Update ScenarioDefinition

            List<ScenarioDefinition.MaidRequirementInfo> newInfoList = new List<ScenarioDefinition.MaidRequirementInfo>();
            foreach (var item in _MaidData)
            {
                ScenarioDefinition.MaidRequirementInfo info = new ScenarioDefinition.MaidRequirementInfo();
                info.IndexPosition = item.num - 1;
                if (item.pure) info.PersonalityID.Add(10);
                if (item.cool) info.PersonalityID.Add(20);
                if (item.pride) info.PersonalityID.Add(30);
                if (item.yandere) info.PersonalityID.Add(40);
                if (item.anesan) info.PersonalityID.Add(50);
                if (item.genki) info.PersonalityID.Add(60);
                if (item.sadist) info.PersonalityID.Add(70);
                if (item.muku) info.PersonalityID.Add(80);
                if (item.majime) info.PersonalityID.Add(90);
                if (item.rindere) info.PersonalityID.Add(100);
                if (item.silent) info.PersonalityID.Add(110);
                if (item.devilish) info.PersonalityID.Add(120);
                if (item.ladylike) info.PersonalityID.Add(130);
                if (item.secretary) info.PersonalityID.Add(140);
                if (item.sister) info.PersonalityID.Add(150);
                if (item.curtness) info.PersonalityID.Add(160);
                if (item.missy) info.PersonalityID.Add(170);
                if (item.childhood) info.PersonalityID.Add(180);
                if (item.masochist) info.PersonalityID.Add(190);
                if (item.cunning) info.PersonalityID.Add(200);
                if (item.friendly) info.PersonalityID.Add(210);
                if (item.dame) info.PersonalityID.Add(220);
                if (item.gyaru) info.PersonalityID.Add(230);

                newInfoList.Add(info);
            }

            Global.ScenarioDefinition.MaidRequirement = newInfoList;

            this.Close();
        }

        private void dgMaids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine(e.RowIndex + " " + e.ColumnIndex);
            if (e.RowIndex >= 0) // exclude header
            {
                if (e.ColumnIndex == 0)
                {
                    //Select all
                    _MaidData[e.RowIndex].SetAllBoolean(true);
                }
                else if (e.ColumnIndex == 1)
                {
                    //Clear all
                    _MaidData[e.RowIndex].SetAllBoolean(false);
                }
            }

            dgMaids.Refresh();
        }
    }
}
