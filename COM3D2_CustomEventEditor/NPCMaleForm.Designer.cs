namespace COM3D2_CustomEventEditor
{
    partial class NPCMaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NPCMaleForm));
            dgNPC = new DataGridView();
            colNum = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colNickName = new DataGridViewTextBoxColumn();
            colWayToCall = new DataGridViewComboBoxColumn();
            colHead = new DataGridViewTextBoxColumn();
            colClothed = new DataGridViewTextBoxColumn();
            colNude = new DataGridViewTextBoxColumn();
            colBodySize = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewTextBoxColumn();
            colPickColor = new DataGridViewButtonColumn();
            lblNoOfNPC = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            cbNumOfNPC = new ComboBox();
            colorDialog = new ColorDialog();
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
            dgNPC.Columns.AddRange(new DataGridViewColumn[] { colNum, colName, colFirstName, colLastName, colNickName, colWayToCall, colHead, colClothed, colNude, colBodySize, colColor, colPickColor });
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
            // colHead
            // 
            colHead.DataPropertyName = "head";
            colHead.HeaderText = "[Head]";
            colHead.Name = "colHead";
            // 
            // colClothed
            // 
            colClothed.DataPropertyName = "clothed";
            colClothed.HeaderText = "[Clothed]";
            colClothed.Name = "colClothed";
            // 
            // colNude
            // 
            colNude.DataPropertyName = "nude";
            colNude.HeaderText = "[Nude]";
            colNude.Name = "colNude";
            // 
            // colBodySize
            // 
            colBodySize.DataPropertyName = "body_size";
            colBodySize.HeaderText = "[BodySize]";
            colBodySize.Name = "colBodySize";
            // 
            // colColor
            // 
            colColor.DataPropertyName = "color";
            colColor.HeaderText = "[Color]";
            colColor.Name = "colColor";
            // 
            // colPickColor
            // 
            colPickColor.HeaderText = "";
            colPickColor.Name = "colPickColor";
            colPickColor.UseColumnTextForButtonValue = true;
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
            lblNoOfNPC.TextResourceKey = "NPCMaleFormNoOfNPCLabel";
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
            // NPCMaleForm
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
            Name = "NPCMaleForm";
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
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colNickName;
        private DataGridViewComboBoxColumn colWayToCall;
        private DataGridViewTextBoxColumn colHead;
        private DataGridViewTextBoxColumn colClothed;
        private DataGridViewTextBoxColumn colNude;
        private DataGridViewTextBoxColumn colBodySize;
        private DataGridViewTextBoxColumn colColor;
        private DataGridViewButtonColumn colPickColor;
        private ColorDialog colorDialog;
    }
}