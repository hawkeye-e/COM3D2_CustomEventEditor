namespace COM3D2_CustomEventEditor
{
    partial class CustomAnimationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomAnimationForm));
            dgCustomAnim = new DataGridView();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            lblInstruction = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            openFileDialog = new OpenFileDialog();
            colKey = new DataGridViewTextBoxColumn();
            colFileName = new DataGridViewTextBoxColumn();
            colSelectFile = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgCustomAnim).BeginInit();
            SuspendLayout();
            // 
            // dgCustomAnim
            // 
            dgCustomAnim.AllowUserToOrderColumns = true;
            dgCustomAnim.AllowUserToResizeColumns = false;
            dgCustomAnim.AllowUserToResizeRows = false;
            dgCustomAnim.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgCustomAnim.BorderStyle = BorderStyle.None;
            dgCustomAnim.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgCustomAnim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomAnim.Columns.AddRange(new DataGridViewColumn[] { colKey, colFileName, colSelectFile, colDelete });
            dgCustomAnim.GridColor = Color.FromArgb(128, 128, 255);
            dgCustomAnim.Location = new Point(12, 64);
            dgCustomAnim.MultiSelect = false;
            dgCustomAnim.Name = "dgCustomAnim";
            dgCustomAnim.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgCustomAnim.Size = new Size(615, 468);
            dgCustomAnim.TabIndex = 0;
            dgCustomAnim.CellContentClick += dgNPC_CellContentClick;
            dgCustomAnim.CellValueChanged += dgNPC_CellValueChanged;
            dgCustomAnim.CurrentCellDirtyStateChanged += dgNPC_CurrentCellDirtyStateChanged;
            dgCustomAnim.DataError += dgNPC_DataError;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(516, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Microsoft Sans Serif", 9F);
            lblInstruction.Location = new Point(12, 46);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(68, 15);
            lblInstruction.TabIndex = 19;
            lblInstruction.Text = "[FileToAdd]";
            lblInstruction.TextResourceKey = "CustomAnimFormInstructionLabel";
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Animation files|*.anm";
            // 
            // colKey
            // 
            colKey.DataPropertyName = "key";
            colKey.Frozen = true;
            colKey.HeaderText = "[Key]";
            colKey.Name = "colKey";
            colKey.Width = 160;
            // 
            // colFileName
            // 
            colFileName.DataPropertyName = "file_name";
            colFileName.HeaderText = "[FileName]";
            colFileName.Name = "colFileName";
            colFileName.ReadOnly = true;
            colFileName.Width = 200;
            // 
            // colSelectFile
            // 
            colSelectFile.HeaderText = "";
            colSelectFile.Name = "colSelectFile";
            colSelectFile.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "";
            colDelete.Name = "colDelete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 80;
            // 
            // CustomAnimationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(645, 561);
            Controls.Add(lblInstruction);
            Controls.Add(btnUpdate);
            Controls.Add(dgCustomAnim);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomAnimationForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Custom Animation Settings";
            ((System.ComponentModel.ISupportInitialize)dgCustomAnim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomAnim;
        private CustomControl.ExtendedButton btnUpdate;
        private CustomControl.ExtendedLabel lblInstruction;
        private OpenFileDialog openFileDialog;
        private DataGridViewTextBoxColumn colKey;
        private DataGridViewTextBoxColumn colFileName;
        private DataGridViewButtonColumn colSelectFile;
        private DataGridViewButtonColumn colDelete;
    }
}