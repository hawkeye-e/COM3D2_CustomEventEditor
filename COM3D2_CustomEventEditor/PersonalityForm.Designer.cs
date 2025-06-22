namespace COM3D2_CustomEventEditor
{
    partial class PersonalityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalityForm));
            dgMaids = new DataGridView();
            lblNumOfMaids = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            cbNumOfMaid = new ComboBox();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            colNum = new DataGridViewTextBoxColumn();
            colSelectAll = new DataGridViewButtonColumn();
            colDeselectAll = new DataGridViewButtonColumn();
            colPure = new DataGridViewCheckBoxColumn();
            colCool = new DataGridViewCheckBoxColumn();
            colPride = new DataGridViewCheckBoxColumn();
            colYandere = new DataGridViewCheckBoxColumn();
            colAnesan = new DataGridViewCheckBoxColumn();
            colGenki = new DataGridViewCheckBoxColumn();
            colSadist = new DataGridViewCheckBoxColumn();
            colMuku = new DataGridViewCheckBoxColumn();
            colMajime = new DataGridViewCheckBoxColumn();
            colRindere = new DataGridViewCheckBoxColumn();
            colSilent = new DataGridViewCheckBoxColumn();
            colDevilish = new DataGridViewCheckBoxColumn();
            colLadylike = new DataGridViewCheckBoxColumn();
            colSecretary = new DataGridViewCheckBoxColumn();
            colSister = new DataGridViewCheckBoxColumn();
            colCurtness = new DataGridViewCheckBoxColumn();
            colMissy = new DataGridViewCheckBoxColumn();
            colChildhood = new DataGridViewCheckBoxColumn();
            colMasochist = new DataGridViewCheckBoxColumn();
            colCunning = new DataGridViewCheckBoxColumn();
            colFriendly = new DataGridViewCheckBoxColumn();
            colDame = new DataGridViewCheckBoxColumn();
            colGyaru = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgMaids).BeginInit();
            SuspendLayout();
            // 
            // dgMaids
            // 
            dgMaids.AllowUserToAddRows = false;
            dgMaids.AllowUserToDeleteRows = false;
            dgMaids.AllowUserToResizeColumns = false;
            dgMaids.AllowUserToResizeRows = false;
            dgMaids.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgMaids.BorderStyle = BorderStyle.None;
            dgMaids.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgMaids.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgMaids.Columns.AddRange(new DataGridViewColumn[] { colNum, colSelectAll, colDeselectAll, colPure, colCool, colPride, colYandere, colAnesan, colGenki, colSadist, colMuku, colMajime, colRindere, colSilent, colDevilish, colLadylike, colSecretary, colSister, colCurtness, colMissy, colChildhood, colMasochist, colCunning, colFriendly, colDame, colGyaru });
            dgMaids.GridColor = Color.FromArgb(128, 128, 255);
            dgMaids.Location = new Point(12, 59);
            dgMaids.MultiSelect = false;
            dgMaids.Name = "dgMaids";
            dgMaids.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgMaids.Size = new Size(776, 379);
            dgMaids.TabIndex = 0;
            dgMaids.CellContentClick += dgMaids_CellContentClick;
            // 
            // lblNumOfMaids
            // 
            lblNumOfMaids.AutoSize = true;
            lblNumOfMaids.Font = new Font("Microsoft Sans Serif", 9F);
            lblNumOfMaids.Location = new Point(12, 9);
            lblNumOfMaids.Name = "lblNumOfMaids";
            lblNumOfMaids.Size = new Size(270, 15);
            lblNumOfMaids.TabIndex = 1;
            lblNumOfMaids.Text = "[How many maids are required in this scenario?]";
            lblNumOfMaids.TextResourceKey = "PFormNumOfMaids";
            // 
            // cbNumOfMaid
            // 
            cbNumOfMaid.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumOfMaid.FlatStyle = FlatStyle.Flat;
            cbNumOfMaid.Font = new Font("Microsoft Sans Serif", 9F);
            cbNumOfMaid.FormattingEnabled = true;
            cbNumOfMaid.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbNumOfMaid.Location = new Point(12, 27);
            cbNumOfMaid.Name = "cbNumOfMaid";
            cbNumOfMaid.Size = new Size(121, 23);
            cbNumOfMaid.TabIndex = 18;
            cbNumOfMaid.SelectedIndexChanged += cbNumOfMaid_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(713, 27);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // colNum
            // 
            colNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colNum.DataPropertyName = "num";
            colNum.Frozen = true;
            colNum.HeaderText = "[Maid No.]";
            colNum.Name = "colNum";
            colNum.ReadOnly = true;
            colNum.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNum.Width = 75;
            // 
            // colSelectAll
            // 
            colSelectAll.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSelectAll.Frozen = true;
            colSelectAll.HeaderText = "";
            colSelectAll.MinimumWidth = 60;
            colSelectAll.Name = "colSelectAll";
            colSelectAll.Text = "All";
            colSelectAll.UseColumnTextForButtonValue = true;
            colSelectAll.Width = 60;
            // 
            // colDeselectAll
            // 
            colDeselectAll.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDeselectAll.Frozen = true;
            colDeselectAll.HeaderText = "";
            colDeselectAll.MinimumWidth = 60;
            colDeselectAll.Name = "colDeselectAll";
            colDeselectAll.Text = "Clear";
            colDeselectAll.UseColumnTextForButtonValue = true;
            colDeselectAll.Width = 60;
            // 
            // colPure
            // 
            colPure.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colPure.DataPropertyName = "pure";
            colPure.FalseValue = "false";
            colPure.HeaderText = "[Pure]";
            colPure.Name = "colPure";
            colPure.Resizable = DataGridViewTriState.False;
            colPure.TrueValue = "true";
            colPure.Width = 46;
            // 
            // colCool
            // 
            colCool.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCool.DataPropertyName = "cool";
            colCool.HeaderText = "[Kuudere]";
            colCool.Name = "colCool";
            colCool.Resizable = DataGridViewTriState.False;
            colCool.Width = 68;
            // 
            // colPride
            // 
            colPride.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colPride.DataPropertyName = "pride";
            colPride.HeaderText = "[Tsudere]";
            colPride.Name = "colPride";
            colPride.Resizable = DataGridViewTriState.False;
            colPride.Width = 66;
            // 
            // colYandere
            // 
            colYandere.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colYandere.DataPropertyName = "yandere";
            colYandere.HeaderText = "[Yandere]";
            colYandere.Name = "colYandere";
            colYandere.Resizable = DataGridViewTriState.False;
            colYandere.Width = 68;
            // 
            // colAnesan
            // 
            colAnesan.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colAnesan.DataPropertyName = "anesan";
            colAnesan.HeaderText = "[Oneechan]";
            colAnesan.Name = "colAnesan";
            colAnesan.Resizable = DataGridViewTriState.False;
            colAnesan.Width = 79;
            // 
            // colGenki
            // 
            colGenki.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colGenki.DataPropertyName = "genki";
            colGenki.HeaderText = "[Genki]";
            colGenki.Name = "colGenki";
            colGenki.Resizable = DataGridViewTriState.False;
            colGenki.Width = 53;
            // 
            // colSadist
            // 
            colSadist.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSadist.DataPropertyName = "sadist";
            colSadist.HeaderText = "[Sadist]";
            colSadist.Name = "colSadist";
            colSadist.Resizable = DataGridViewTriState.False;
            colSadist.Width = 55;
            // 
            // colMuku
            // 
            colMuku.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colMuku.DataPropertyName = "muku";
            colMuku.HeaderText = "[Muku]";
            colMuku.Name = "colMuku";
            colMuku.Resizable = DataGridViewTriState.False;
            colMuku.Width = 53;
            // 
            // colMajime
            // 
            colMajime.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colMajime.DataPropertyName = "majime";
            colMajime.HeaderText = "[Majime]";
            colMajime.Name = "colMajime";
            colMajime.Resizable = DataGridViewTriState.False;
            colMajime.Width = 64;
            // 
            // colRindere
            // 
            colRindere.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colRindere.DataPropertyName = "rindere";
            colRindere.HeaderText = "[Rindere]";
            colRindere.Name = "colRindere";
            colRindere.Resizable = DataGridViewTriState.False;
            colRindere.Width = 65;
            // 
            // colSilent
            // 
            colSilent.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSilent.DataPropertyName = "silent";
            colSilent.HeaderText = "[Silent]";
            colSilent.Name = "colSilent";
            colSilent.Resizable = DataGridViewTriState.False;
            colSilent.Width = 52;
            // 
            // colDevilish
            // 
            colDevilish.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDevilish.DataPropertyName = "devilish";
            colDevilish.HeaderText = "Koakuma";
            colDevilish.Name = "colDevilish";
            colDevilish.Resizable = DataGridViewTriState.False;
            colDevilish.Width = 66;
            // 
            // colLadylike
            // 
            colLadylike.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colLadylike.DataPropertyName = "ladylike";
            colLadylike.HeaderText = "[Anesan]";
            colLadylike.Name = "colLadylike";
            colLadylike.Resizable = DataGridViewTriState.False;
            colLadylike.Width = 62;
            // 
            // colSecretary
            // 
            colSecretary.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSecretary.DataPropertyName = "secretary";
            colSecretary.HeaderText = "[Maid Secretary]";
            colSecretary.Name = "colSecretary";
            colSecretary.Resizable = DataGridViewTriState.False;
            colSecretary.Width = 96;
            // 
            // colSister
            // 
            colSister.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSister.DataPropertyName = "sister";
            colSister.HeaderText = "[Fluffy]";
            colSister.Name = "colSister";
            colSister.Resizable = DataGridViewTriState.False;
            colSister.Width = 51;
            // 
            // colCurtness
            // 
            colCurtness.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCurtness.DataPropertyName = "curtness";
            colCurtness.HeaderText = "[Wary]";
            colCurtness.Name = "colCurtness";
            colCurtness.Resizable = DataGridViewTriState.False;
            colCurtness.Width = 50;
            // 
            // colMissy
            // 
            colMissy.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colMissy.DataPropertyName = "missy";
            colMissy.HeaderText = "[Ojou]";
            colMissy.Name = "colMissy";
            colMissy.Resizable = DataGridViewTriState.False;
            colMissy.Width = 49;
            // 
            // colChildhood
            // 
            colChildhood.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colChildhood.DataPropertyName = "childhood";
            colChildhood.HeaderText = "[Childhood Friend]";
            colChildhood.Name = "colChildhood";
            colChildhood.Resizable = DataGridViewTriState.False;
            colChildhood.Width = 107;
            // 
            // colMasochist
            // 
            colMasochist.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colMasochist.DataPropertyName = "masochist";
            colMasochist.HeaderText = "[Masochist]";
            colMasochist.Name = "colMasochist";
            colMasochist.Resizable = DataGridViewTriState.False;
            colMasochist.Width = 78;
            // 
            // colCunning
            // 
            colCunning.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colCunning.DataPropertyName = "cunning";
            colCunning.HeaderText = "[Cunning]";
            colCunning.Name = "colCunning";
            colCunning.Resizable = DataGridViewTriState.False;
            colCunning.Width = 68;
            // 
            // colFriendly
            // 
            colFriendly.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colFriendly.DataPropertyName = "friendly";
            colFriendly.HeaderText = "[Friendly]";
            colFriendly.Name = "colFriendly";
            colFriendly.Resizable = DataGridViewTriState.False;
            colFriendly.Width = 65;
            // 
            // colDame
            // 
            colDame.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDame.DataPropertyName = "dame";
            colDame.HeaderText = "[Lady]";
            colDame.Name = "colDame";
            colDame.Resizable = DataGridViewTriState.False;
            colDame.Width = 48;
            // 
            // colGyaru
            // 
            colGyaru.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colGyaru.DataPropertyName = "gyaru";
            colGyaru.HeaderText = "[Gyaru]";
            colGyaru.Name = "colGyaru";
            colGyaru.Resizable = DataGridViewTriState.False;
            colGyaru.Width = 54;
            // 
            // PersonalityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(cbNumOfMaid);
            Controls.Add(lblNumOfMaids);
            Controls.Add(dgMaids);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PersonalityForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Maid Settings";
            ((System.ComponentModel.ISupportInitialize)dgMaids).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgMaids;
        private CustomControl.ExtendedLabel lblNumOfMaids;
        private ComboBox cbNumOfMaid;
        private CustomControl.ExtendedButton btnUpdate;
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewButtonColumn colSelectAll;
        private DataGridViewButtonColumn colDeselectAll;
        private DataGridViewCheckBoxColumn colPure;
        private DataGridViewCheckBoxColumn colCool;
        private DataGridViewCheckBoxColumn colPride;
        private DataGridViewCheckBoxColumn colYandere;
        private DataGridViewCheckBoxColumn colAnesan;
        private DataGridViewCheckBoxColumn colGenki;
        private DataGridViewCheckBoxColumn colSadist;
        private DataGridViewCheckBoxColumn colMuku;
        private DataGridViewCheckBoxColumn colMajime;
        private DataGridViewCheckBoxColumn colRindere;
        private DataGridViewCheckBoxColumn colSilent;
        private DataGridViewCheckBoxColumn colDevilish;
        private DataGridViewCheckBoxColumn colLadylike;
        private DataGridViewCheckBoxColumn colSecretary;
        private DataGridViewCheckBoxColumn colSister;
        private DataGridViewCheckBoxColumn colCurtness;
        private DataGridViewCheckBoxColumn colMissy;
        private DataGridViewCheckBoxColumn colChildhood;
        private DataGridViewCheckBoxColumn colMasochist;
        private DataGridViewCheckBoxColumn colCunning;
        private DataGridViewCheckBoxColumn colFriendly;
        private DataGridViewCheckBoxColumn colDame;
        private DataGridViewCheckBoxColumn colGyaru;
    }
}