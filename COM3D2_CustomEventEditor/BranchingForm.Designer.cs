namespace COM3D2_CustomEventEditor
{
    partial class BranchingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BranchingForm));
            dgBranch = new DataGridView();
            colValue = new DataGridViewTextBoxColumn();
            colNextStepID = new DataGridViewTextBoxColumn();
            colNum = new DataGridViewTextBoxColumn();
            lblNoOfBranches = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            cbNumOfBranch = new ComboBox();
            lblVariableName = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            txtVariableName = new CustomControls.RJControls.RJTextBox();
            lblComparativeMethod = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            cbComparativeMethod = new ComboBox();
            cbVariableType = new ComboBox();
            lblVariableType = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            ((System.ComponentModel.ISupportInitialize)dgBranch).BeginInit();
            SuspendLayout();
            // 
            // dgBranch
            // 
            dgBranch.AllowUserToAddRows = false;
            dgBranch.AllowUserToDeleteRows = false;
            dgBranch.AllowUserToOrderColumns = true;
            dgBranch.AllowUserToResizeColumns = false;
            dgBranch.AllowUserToResizeRows = false;
            dgBranch.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgBranch.BorderStyle = BorderStyle.None;
            dgBranch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgBranch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBranch.Columns.AddRange(new DataGridViewColumn[] { colValue, colNextStepID, colNum });
            dgBranch.GridColor = Color.FromArgb(128, 128, 255);
            dgBranch.Location = new Point(12, 156);
            dgBranch.MultiSelect = false;
            dgBranch.Name = "dgBranch";
            dgBranch.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgBranch.Size = new Size(375, 296);
            dgBranch.TabIndex = 0;
            dgBranch.CellContentClick += dgNPC_CellContentClick;
            dgBranch.CellValueChanged += dgNPC_CellValueChanged;
            dgBranch.CurrentCellDirtyStateChanged += dgNPC_CurrentCellDirtyStateChanged;
            dgBranch.DataError += dgNPC_DataError;
            // 
            // colValue
            // 
            colValue.DataPropertyName = "value";
            colValue.HeaderText = "[Value]";
            colValue.Name = "colValue";
            // 
            // colNextStepID
            // 
            colNextStepID.DataPropertyName = "next_step_id";
            colNextStepID.HeaderText = "[NextStepID]";
            colNextStepID.Name = "colNextStepID";
            colNextStepID.Width = 200;
            // 
            // colNum
            // 
            colNum.DataPropertyName = "num";
            colNum.HeaderText = "";
            colNum.Name = "colNum";
            colNum.Visible = false;
            // 
            // lblNoOfBranches
            // 
            lblNoOfBranches.AutoSize = true;
            lblNoOfBranches.Font = new Font("Microsoft Sans Serif", 9F);
            lblNoOfBranches.Location = new Point(12, 108);
            lblNoOfBranches.Name = "lblNoOfBranches";
            lblNoOfBranches.Size = new Size(107, 15);
            lblNoOfBranches.TabIndex = 19;
            lblNoOfBranches.Text = "[HowManyBranch]";
            lblNoOfBranches.TextResourceKey = "BranchingFormNoOfBranchLabel";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(282, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbNumOfBranch
            // 
            cbNumOfBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumOfBranch.FlatStyle = FlatStyle.Flat;
            cbNumOfBranch.Font = new Font("Microsoft Sans Serif", 9F);
            cbNumOfBranch.FormattingEnabled = true;
            cbNumOfBranch.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            cbNumOfBranch.Location = new Point(12, 126);
            cbNumOfBranch.Name = "cbNumOfBranch";
            cbNumOfBranch.Size = new Size(181, 23);
            cbNumOfBranch.TabIndex = 31;
            cbNumOfBranch.SelectedIndexChanged += cbNumOfBranch_SelectedIndexChanged;
            // 
            // lblVariableName
            // 
            lblVariableName.AutoSize = true;
            lblVariableName.Font = new Font("Microsoft Sans Serif", 9F);
            lblVariableName.Location = new Point(12, 9);
            lblVariableName.Name = "lblVariableName";
            lblVariableName.Size = new Size(92, 15);
            lblVariableName.TabIndex = 32;
            lblVariableName.Text = "[VariableName]";
            lblVariableName.TextResourceKey = "BranchingFormVariableNameLabel";
            // 
            // txtVariableName
            // 
            txtVariableName.AutoScroll = true;
            txtVariableName.BackColor = SystemColors.Window;
            txtVariableName.BorderColor = Color.FromArgb(66, 124, 244);
            txtVariableName.BorderFocusColor = Color.HotPink;
            txtVariableName.BorderSize = 2;
            txtVariableName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVariableName.ForeColor = Color.Black;
            txtVariableName.Location = new Point(13, 28);
            txtVariableName.Margin = new Padding(4);
            txtVariableName.Multiline = false;
            txtVariableName.Name = "txtVariableName";
            txtVariableName.Padding = new Padding(7);
            txtVariableName.PasswordChar = false;
            txtVariableName.ReadOnly = false;
            txtVariableName.Size = new Size(180, 31);
            txtVariableName.TabIndex = 33;
            txtVariableName.Texts = "";
            txtVariableName.UnderlinedStyle = false;
            // 
            // lblComparativeMethod
            // 
            lblComparativeMethod.AutoSize = true;
            lblComparativeMethod.Font = new Font("Microsoft Sans Serif", 9F);
            lblComparativeMethod.Location = new Point(207, 63);
            lblComparativeMethod.Name = "lblComparativeMethod";
            lblComparativeMethod.Size = new Size(124, 15);
            lblComparativeMethod.TabIndex = 34;
            lblComparativeMethod.Text = "[ComparativeMethod]";
            lblComparativeMethod.TextResourceKey = "BranchingFormComparativeMethodLabel";
            // 
            // cbComparativeMethod
            // 
            cbComparativeMethod.DisplayMember = "DisplayText";
            cbComparativeMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cbComparativeMethod.FlatStyle = FlatStyle.Flat;
            cbComparativeMethod.Font = new Font("Microsoft Sans Serif", 9F);
            cbComparativeMethod.FormattingEnabled = true;
            cbComparativeMethod.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            cbComparativeMethod.Location = new Point(207, 82);
            cbComparativeMethod.Name = "cbComparativeMethod";
            cbComparativeMethod.Size = new Size(150, 23);
            cbComparativeMethod.TabIndex = 35;
            cbComparativeMethod.ValueMember = "DataKey";
            // 
            // cbVariableType
            // 
            cbVariableType.DisplayMember = "DisplayText";
            cbVariableType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbVariableType.FlatStyle = FlatStyle.Flat;
            cbVariableType.Font = new Font("Microsoft Sans Serif", 9F);
            cbVariableType.FormattingEnabled = true;
            cbVariableType.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            cbVariableType.Location = new Point(13, 82);
            cbVariableType.Name = "cbVariableType";
            cbVariableType.Size = new Size(180, 23);
            cbVariableType.TabIndex = 37;
            cbVariableType.ValueMember = "DataKey";
            cbVariableType.SelectedIndexChanged += cbVariableType_SelectedIndexChanged;
            // 
            // lblVariableType
            // 
            lblVariableType.AutoSize = true;
            lblVariableType.Font = new Font("Microsoft Sans Serif", 9F);
            lblVariableType.Location = new Point(13, 63);
            lblVariableType.Name = "lblVariableType";
            lblVariableType.Size = new Size(84, 15);
            lblVariableType.TabIndex = 36;
            lblVariableType.Text = "[VariableType]";
            lblVariableType.TextResourceKey = "BranchingFormVariableTypeLabel";
            // 
            // BranchingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(410, 467);
            Controls.Add(cbVariableType);
            Controls.Add(lblVariableType);
            Controls.Add(cbComparativeMethod);
            Controls.Add(lblComparativeMethod);
            Controls.Add(txtVariableName);
            Controls.Add(lblVariableName);
            Controls.Add(cbNumOfBranch);
            Controls.Add(lblNoOfBranches);
            Controls.Add(btnUpdate);
            Controls.Add(dgBranch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BranchingForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Edit Branches";
            ((System.ComponentModel.ISupportInitialize)dgBranch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgBranch;
        private CustomControl.ExtendedLabel lblNoOfBranches;
        private CustomControl.ExtendedButton btnUpdate;
        private ComboBox cbNumOfBranch;
        private CustomControl.ExtendedLabel lblVariableName;
        private CustomControls.RJControls.RJTextBox txtVariableName;
        private CustomControl.ExtendedLabel lblComparativeMethod;
        private ComboBox cbComparativeMethod;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewTextBoxColumn colNextStepID;
        private DataGridViewTextBoxColumn colNum;
        private ComboBox cbVariableType;
        private CustomControl.ExtendedLabel lblVariableType;
    }
}