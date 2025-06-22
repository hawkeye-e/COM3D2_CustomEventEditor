namespace COM3D2_CustomEventEditor
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            dgOption = new DataGridView();
            colKey = new DataGridViewTextBoxColumn();
            colValue = new DataGridViewTextBoxColumn();
            colNum = new DataGridViewTextBoxColumn();
            lblNoOfOptions = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            cbNumOfOption = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgOption).BeginInit();
            SuspendLayout();
            // 
            // dgOption
            // 
            dgOption.AllowUserToAddRows = false;
            dgOption.AllowUserToDeleteRows = false;
            dgOption.AllowUserToOrderColumns = true;
            dgOption.AllowUserToResizeColumns = false;
            dgOption.AllowUserToResizeRows = false;
            dgOption.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgOption.BorderStyle = BorderStyle.None;
            dgOption.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgOption.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgOption.Columns.AddRange(new DataGridViewColumn[] { colKey, colValue, colNum });
            dgOption.GridColor = Color.FromArgb(128, 128, 255);
            dgOption.Location = new Point(12, 56);
            dgOption.MultiSelect = false;
            dgOption.Name = "dgOption";
            dgOption.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgOption.Size = new Size(678, 296);
            dgOption.TabIndex = 0;
            dgOption.CellContentClick += dgNPC_CellContentClick;
            dgOption.CellValueChanged += dgNPC_CellValueChanged;
            dgOption.CurrentCellDirtyStateChanged += dgNPC_CurrentCellDirtyStateChanged;
            dgOption.DataError += dgNPC_DataError;
            // 
            // colKey
            // 
            colKey.DataPropertyName = "key";
            colKey.HeaderText = "[OptionKey]";
            colKey.Name = "colKey";
            colKey.Width = 120;
            // 
            // colValue
            // 
            colValue.DataPropertyName = "text";
            colValue.HeaderText = "[DisplayText]";
            colValue.Name = "colValue";
            colValue.Width = 500;
            // 
            // colNum
            // 
            colNum.DataPropertyName = "num";
            colNum.HeaderText = "";
            colNum.Name = "colNum";
            colNum.Visible = false;
            // 
            // lblNoOfOptions
            // 
            lblNoOfOptions.AutoSize = true;
            lblNoOfOptions.Font = new Font("Microsoft Sans Serif", 9F);
            lblNoOfOptions.Location = new Point(12, 9);
            lblNoOfOptions.Name = "lblNoOfOptions";
            lblNoOfOptions.Size = new Size(104, 15);
            lblNoOfOptions.TabIndex = 19;
            lblNoOfOptions.Text = "[HowManyOption]";
            lblNoOfOptions.TextResourceKey = "OptionFormNoOfOptionsLabel";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(597, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbNumOfOption
            // 
            cbNumOfOption.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumOfOption.FlatStyle = FlatStyle.Flat;
            cbNumOfOption.Font = new Font("Microsoft Sans Serif", 9F);
            cbNumOfOption.FormattingEnabled = true;
            cbNumOfOption.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbNumOfOption.Location = new Point(12, 27);
            cbNumOfOption.Name = "cbNumOfOption";
            cbNumOfOption.Size = new Size(121, 23);
            cbNumOfOption.TabIndex = 31;
            cbNumOfOption.SelectedIndexChanged += cbNumOfOption_SelectedIndexChanged;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(691, 364);
            Controls.Add(cbNumOfOption);
            Controls.Add(lblNoOfOptions);
            Controls.Add(btnUpdate);
            Controls.Add(dgOption);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OptionForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Edit Options";
            ((System.ComponentModel.ISupportInitialize)dgOption).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgOption;
        private CustomControl.ExtendedLabel lblNoOfOptions;
        private CustomControl.ExtendedButton btnUpdate;
        private ComboBox cbNumOfOption;
        private DataGridViewTextBoxColumn colKey;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewTextBoxColumn colNum;
    }
}