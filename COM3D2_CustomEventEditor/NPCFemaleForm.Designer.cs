namespace COM3D2_CustomEventEditor
{
    partial class NPCFemaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPCFemaleForm));
            dgNPC = new DataGridView();
            colNum = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colType = new DataGridViewComboBoxColumn();
            colKey = new DataGridViewComboBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colNickName = new DataGridViewTextBoxColumn();
            colWayToCall = new DataGridViewComboBoxColumn();
            colPresetV2 = new DataGridViewTextBoxColumn();
            colPresetV2Button = new DataGridViewButtonColumn();
            colPresetV2_5 = new DataGridViewTextBoxColumn();
            colPresetV2_5Button = new DataGridViewButtonColumn();
            colVoicePitch = new DataGridViewTextBoxColumn();
            lblNoOfNPC = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            cbNumOfNPC = new ComboBox();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgNPC).BeginInit();
            SuspendLayout();
            // 
            // dgNPC
            // 
            dgNPC.AllowUserToAddRows = false;
            dgNPC.AllowUserToDeleteRows = false;
            dgNPC.AllowUserToOrderColumns = true;
            dgNPC.AllowUserToResizeColumns = false;
            dgNPC.AllowUserToResizeRows = false;
            dgNPC.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgNPC.BorderStyle = BorderStyle.None;
            dgNPC.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgNPC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNPC.Columns.AddRange(new DataGridViewColumn[] { colNum, colName, colType, colKey, colFirstName, colLastName, colNickName, colWayToCall, colPresetV2, colPresetV2Button, colPresetV2_5, colPresetV2_5Button, colVoicePitch });
            dgNPC.GridColor = Color.FromArgb(128, 128, 255);
            dgNPC.Location = new Point(12, 56);
            dgNPC.MultiSelect = false;
            dgNPC.Name = "dgNPC";
            dgNPC.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgNPC.Size = new Size(776, 501);
            dgNPC.TabIndex = 0;
            dgNPC.CellContentClick += dgNPC_CellContentClick;
            dgNPC.CellValueChanged += dgNPC_CellValueChanged;
            dgNPC.CurrentCellDirtyStateChanged += dgNPC_CurrentCellDirtyStateChanged;
            dgNPC.DataError += dgNPC_DataError;
            // 
            // colNum
            // 
            colNum.DataPropertyName = "num";
            colNum.Frozen = true;
            colNum.HeaderText = "[NPC No.]";
            colNum.Name = "colNum";
            colNum.ReadOnly = true;
            colNum.Width = 40;
            // 
            // colName
            // 
            colName.DataPropertyName = "name";
            colName.Frozen = true;
            colName.HeaderText = "[Name]";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colType
            // 
            colType.DataPropertyName = "type";
            colType.HeaderText = "[Type]";
            colType.Name = "colType";
            colType.Width = 80;
            // 
            // colKey
            // 
            colKey.DataPropertyName = "key";
            colKey.HeaderText = "[NPC Key]";
            colKey.Name = "colKey";
            colKey.Width = 120;
            // 
            // colFirstName
            // 
            colFirstName.DataPropertyName = "first_name";
            colFirstName.HeaderText = "[FirstName]";
            colFirstName.Name = "colFirstName";
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "last_name";
            colLastName.HeaderText = "[LastName]";
            colLastName.Name = "colLastName";
            // 
            // colNickName
            // 
            colNickName.DataPropertyName = "nick_name";
            colNickName.HeaderText = "[NickName]";
            colNickName.Name = "colNickName";
            // 
            // colWayToCall
            // 
            colWayToCall.DataPropertyName = "way_to_call";
            colWayToCall.HeaderText = "[WayToCall]";
            colWayToCall.Items.AddRange(new object[] { "FirstName", "LastName", "NickName" });
            colWayToCall.Name = "colWayToCall";
            // 
            // colPresetV2
            // 
            colPresetV2.DataPropertyName = "preset_v2";
            colPresetV2.HeaderText = "[PresetV2]";
            colPresetV2.Name = "colPresetV2";
            colPresetV2.ReadOnly = true;
            colPresetV2.Width = 140;
            // 
            // colPresetV2Button
            // 
            colPresetV2Button.HeaderText = "";
            colPresetV2Button.Name = "colPresetV2Button";
            colPresetV2Button.UseColumnTextForButtonValue = true;
            colPresetV2Button.Width = 80;
            // 
            // colPresetV2_5
            // 
            colPresetV2_5.DataPropertyName = "preset_v2_5";
            colPresetV2_5.HeaderText = "[PresetV2_5]";
            colPresetV2_5.Name = "colPresetV2_5";
            colPresetV2_5.ReadOnly = true;
            colPresetV2_5.Width = 140;
            // 
            // colPresetV2_5Button
            // 
            colPresetV2_5Button.HeaderText = "";
            colPresetV2_5Button.Name = "colPresetV2_5Button";
            colPresetV2_5Button.UseColumnTextForButtonValue = true;
            colPresetV2_5Button.Width = 80;
            // 
            // colVoicePitch
            // 
            colVoicePitch.DataPropertyName = "voice_pitch";
            colVoicePitch.HeaderText = "[Pitch]";
            colVoicePitch.Name = "colVoicePitch";
            colVoicePitch.Width = 80;
            // 
            // lblNoOfNPC
            // 
            lblNoOfNPC.AutoSize = true;
            lblNoOfNPC.Font = new Font("Microsoft Sans Serif", 9F);
            lblNoOfNPC.Location = new Point(12, 9);
            lblNoOfNPC.Name = "lblNoOfNPC";
            lblNoOfNPC.Size = new Size(93, 15);
            lblNoOfNPC.TabIndex = 19;
            lblNoOfNPC.Text = "[HowManyNPC]";
            lblNoOfNPC.TextResourceKey = "NPCFemaleFormNoOfNPCLabel";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(713, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbNumOfNPC
            // 
            cbNumOfNPC.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumOfNPC.FlatStyle = FlatStyle.Flat;
            cbNumOfNPC.Font = new Font("Microsoft Sans Serif", 9F);
            cbNumOfNPC.FormattingEnabled = true;
            cbNumOfNPC.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbNumOfNPC.Location = new Point(12, 27);
            cbNumOfNPC.Name = "cbNumOfNPC";
            cbNumOfNPC.Size = new Size(121, 23);
            cbNumOfNPC.TabIndex = 31;
            cbNumOfNPC.SelectedIndexChanged += cbNumOfNPC_SelectedIndexChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Preset files|*.preset";
            openFileDialog.FileOk += openFileDialog_FileOk;
            // 
            // NPCFemaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(800, 561);
            Controls.Add(cbNumOfNPC);
            Controls.Add(lblNoOfNPC);
            Controls.Add(btnUpdate);
            Controls.Add(dgNPC);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NPCFemaleForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "NPC Settings";
            ((System.ComponentModel.ISupportInitialize)dgNPC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgNPC;
        private CustomControl.ExtendedLabel lblNoOfNPC;
        private CustomControl.ExtendedButton btnUpdate;
        private ComboBox cbNumOfNPC;
        private OpenFileDialog openFileDialog;
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewComboBoxColumn colType;
        private DataGridViewComboBoxColumn colKey;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colNickName;
        private DataGridViewComboBoxColumn colWayToCall;
        private DataGridViewTextBoxColumn colPresetV2;
        private DataGridViewButtonColumn colPresetV2Button;
        private DataGridViewTextBoxColumn colPresetV2_5;
        private DataGridViewButtonColumn colPresetV2_5Button;
        private DataGridViewTextBoxColumn colVoicePitch;
    }
}