namespace COM3D2_CustomEventEditor
{
    partial class MakeGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeGroupForm));
            dgGroup = new DataGridView();
            colNum = new DataGridViewTextBoxColumn();
            colGroupType = new DataGridViewTextBoxColumn();
            colMaid1Type = new DataGridViewComboBoxColumn();
            colMaid1Index = new DataGridViewTextBoxColumn();
            colMaid2Type = new DataGridViewComboBoxColumn();
            colMaid2Index = new DataGridViewTextBoxColumn();
            colMan1Type = new DataGridViewComboBoxColumn();
            colMan1Index = new DataGridViewTextBoxColumn();
            colMan2Type = new DataGridViewComboBoxColumn();
            colMan2Index = new DataGridViewTextBoxColumn();
            colMan3Type = new DataGridViewComboBoxColumn();
            colMan3Index = new DataGridViewTextBoxColumn();
            lblNoOfGroup = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            cbNumOfGroup = new ComboBox();
            colorDialog = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgGroup).BeginInit();
            SuspendLayout();
            // 
            // dgGroup
            // 
            dgGroup.AllowUserToAddRows = false;
            dgGroup.AllowUserToDeleteRows = false;
            dgGroup.AllowUserToOrderColumns = true;
            dgGroup.AllowUserToResizeColumns = false;
            dgGroup.AllowUserToResizeRows = false;
            dgGroup.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgGroup.BorderStyle = BorderStyle.None;
            dgGroup.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgGroup.Columns.AddRange(new DataGridViewColumn[] { colNum, colGroupType, colMaid1Type, colMaid1Index, colMaid2Type, colMaid2Index, colMan1Type, colMan1Index, colMan2Type, colMan2Index, colMan3Type, colMan3Index });
            dgGroup.GridColor = Color.FromArgb(128, 128, 255);
            dgGroup.Location = new Point(12, 56);
            dgGroup.MultiSelect = false;
            dgGroup.Name = "dgGroup";
            dgGroup.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgGroup.Size = new Size(776, 501);
            dgGroup.TabIndex = 0;
            dgGroup.CellContentClick += dgNPC_CellContentClick;
            dgGroup.CellValueChanged += dgNPC_CellValueChanged;
            dgGroup.CurrentCellDirtyStateChanged += dgNPC_CurrentCellDirtyStateChanged;
            dgGroup.DataError += dgNPC_DataError;
            // 
            // colNum
            // 
            colNum.DataPropertyName = "num";
            colNum.Frozen = true;
            colNum.HeaderText = "[Group No.]";
            colNum.Name = "colNum";
            colNum.Width = 40;
            // 
            // colGroupType
            // 
            colGroupType.DataPropertyName = "group_type";
            colGroupType.HeaderText = "[GroupType]";
            colGroupType.Name = "colGroupType";
            colGroupType.ReadOnly = true;
            // 
            // colMaid1Type
            // 
            colMaid1Type.DataPropertyName = "maid1_type";
            colMaid1Type.HeaderText = "[Maid1Type]";
            colMaid1Type.Name = "colMaid1Type";
            // 
            // colMaid1Index
            // 
            colMaid1Index.DataPropertyName = "maid1_index";
            colMaid1Index.HeaderText = "[Maid1Index]";
            colMaid1Index.Name = "colMaid1Index";
            colMaid1Index.Width = 110;
            // 
            // colMaid2Type
            // 
            colMaid2Type.DataPropertyName = "maid2_type";
            colMaid2Type.HeaderText = "[Maid2Type]";
            colMaid2Type.Name = "colMaid2Type";
            // 
            // colMaid2Index
            // 
            colMaid2Index.DataPropertyName = "maid2_index";
            colMaid2Index.HeaderText = "[Maid2Index]";
            colMaid2Index.Name = "colMaid2Index";
            colMaid2Index.Width = 110;
            // 
            // colMan1Type
            // 
            colMan1Type.DataPropertyName = "man1_type";
            colMan1Type.HeaderText = "[Man1Type]";
            colMan1Type.Name = "colMan1Type";
            // 
            // colMan1Index
            // 
            colMan1Index.DataPropertyName = "man1_index";
            colMan1Index.HeaderText = "[Man1Index]";
            colMan1Index.Name = "colMan1Index";
            colMan1Index.Width = 110;
            // 
            // colMan2Type
            // 
            colMan2Type.DataPropertyName = "man2_type";
            colMan2Type.HeaderText = "[Man2Type]";
            colMan2Type.Name = "colMan2Type";
            // 
            // colMan2Index
            // 
            colMan2Index.DataPropertyName = "man2_index";
            colMan2Index.HeaderText = "[Man2Index]";
            colMan2Index.Name = "colMan2Index";
            colMan2Index.Width = 110;
            // 
            // colMan3Type
            // 
            colMan3Type.DataPropertyName = "man3_type";
            colMan3Type.HeaderText = "[Man3Type]";
            colMan3Type.Name = "colMan3Type";
            // 
            // colMan3Index
            // 
            colMan3Index.DataPropertyName = "man3_index";
            colMan3Index.HeaderText = "[Man3Index]";
            colMan3Index.Name = "colMan3Index";
            colMan3Index.Width = 110;
            // 
            // lblNoOfGroup
            // 
            lblNoOfGroup.AutoSize = true;
            lblNoOfGroup.Font = new Font("Microsoft Sans Serif", 9F);
            lblNoOfGroup.Location = new Point(12, 9);
            lblNoOfGroup.Name = "lblNoOfGroup";
            lblNoOfGroup.Size = new Size(102, 15);
            lblNoOfGroup.TabIndex = 19;
            lblNoOfGroup.Text = "[HowManyGroup]";
            lblNoOfGroup.TextResourceKey = "MakeGroupFormNoOfGroupLabel";
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
            // cbNumOfGroup
            // 
            cbNumOfGroup.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbNumOfGroup.Location = new Point(12, 27);
            cbNumOfGroup.Name = "cbNumOfGroup";
            cbNumOfGroup.Size = new Size(121, 23);
            cbNumOfGroup.TabIndex = 0;
            cbNumOfGroup.SelectedIndexChanged += cbNumOfGroup_SelectedIndexChanged;
            // 
            // MakeGroupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(800, 561);
            Controls.Add(cbNumOfGroup);
            Controls.Add(lblNoOfGroup);
            Controls.Add(btnUpdate);
            Controls.Add(dgGroup);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MakeGroupForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Group Settings";
            ((System.ComponentModel.ISupportInitialize)dgGroup).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgGroup;
        private CustomControl.ExtendedLabel lblNoOfGroup;
        private CustomControl.ExtendedButton btnUpdate;
        private ComboBox cbNumOfGroup;
        private ColorDialog colorDialog;
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewTextBoxColumn colGroupType;
        private DataGridViewComboBoxColumn colMaid1Type;
        private DataGridViewTextBoxColumn colMaid1Index;
        private DataGridViewComboBoxColumn colMaid2Type;
        private DataGridViewTextBoxColumn colMaid2Index;
        private DataGridViewComboBoxColumn colMan1Type;
        private DataGridViewTextBoxColumn colMan1Index;
        private DataGridViewComboBoxColumn colMan2Type;
        private DataGridViewTextBoxColumn colMan2Index;
        private DataGridViewComboBoxColumn colMan3Type;
        private DataGridViewTextBoxColumn colMan3Index;
    }
}