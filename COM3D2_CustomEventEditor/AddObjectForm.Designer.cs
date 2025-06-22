namespace COM3D2_CustomEventEditor
{
    partial class AddObjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddObjectForm));
            dgObject = new DataGridView();
            colNum = new DataGridViewTextBoxColumn();
            colObjectID = new DataGridViewTextBoxColumn();
            colSrc = new DataGridViewTextBoxColumn();
            colPos = new DataGridViewTextBoxColumn();
            colRot = new DataGridViewTextBoxColumn();
            colScale = new DataGridViewTextBoxColumn();
            lblNoOfObjects = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            cbNumOfObject = new ComboBox();
            colorDialog = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)dgObject).BeginInit();
            SuspendLayout();
            // 
            // dgObject
            // 
            dgObject.AllowUserToAddRows = false;
            dgObject.AllowUserToDeleteRows = false;
            dgObject.AllowUserToOrderColumns = true;
            dgObject.AllowUserToResizeColumns = false;
            dgObject.AllowUserToResizeRows = false;
            dgObject.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgObject.BorderStyle = BorderStyle.None;
            dgObject.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgObject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgObject.Columns.AddRange(new DataGridViewColumn[] { colNum, colObjectID, colSrc, colPos, colRot, colScale });
            dgObject.GridColor = Color.FromArgb(128, 128, 255);
            dgObject.Location = new Point(12, 56);
            dgObject.MultiSelect = false;
            dgObject.Name = "dgObject";
            dgObject.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgObject.Size = new Size(776, 501);
            dgObject.TabIndex = 0;
            dgObject.CellContentClick += dgNPC_CellContentClick;
            dgObject.CellValueChanged += dgNPC_CellValueChanged;
            dgObject.CurrentCellDirtyStateChanged += dgNPC_CurrentCellDirtyStateChanged;
            dgObject.DataError += dgNPC_DataError;
            // 
            // colNum
            // 
            colNum.DataPropertyName = "num";
            colNum.Frozen = true;
            colNum.HeaderText = "[Object No.]";
            colNum.Name = "colNum";
            colNum.Width = 40;
            // 
            // colObjectID
            // 
            colObjectID.DataPropertyName = "object_id";
            colObjectID.HeaderText = "[ObjectID]";
            colObjectID.Name = "colObjectID";
            colObjectID.Width = 120;
            // 
            // colSrc
            // 
            colSrc.DataPropertyName = "src";
            colSrc.HeaderText = "[Src]";
            colSrc.Name = "colSrc";
            // 
            // colPos
            // 
            colPos.DataPropertyName = "pos";
            colPos.HeaderText = "[Position]";
            colPos.Name = "colPos";
            colPos.Width = 180;
            // 
            // colRot
            // 
            colRot.DataPropertyName = "rot";
            colRot.HeaderText = "[Rotation]";
            colRot.Name = "colRot";
            colRot.Width = 180;
            // 
            // colScale
            // 
            colScale.DataPropertyName = "scale";
            colScale.HeaderText = "[Scale]";
            colScale.Name = "colScale";
            // 
            // lblNoOfObjects
            // 
            lblNoOfObjects.AutoSize = true;
            lblNoOfObjects.Font = new Font("Microsoft Sans Serif", 9F);
            lblNoOfObjects.Location = new Point(12, 9);
            lblNoOfObjects.Name = "lblNoOfObjects";
            lblNoOfObjects.Size = new Size(103, 15);
            lblNoOfObjects.TabIndex = 19;
            lblNoOfObjects.Text = "[HowManyObject]";
            lblNoOfObjects.TextResourceKey = "AddObjectFormNoOfObjectLabel";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(699, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbNumOfObject
            // 
            cbNumOfObject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNumOfObject.FlatStyle = FlatStyle.Flat;
            cbNumOfObject.Font = new Font("Microsoft Sans Serif", 9F);
            cbNumOfObject.FormattingEnabled = true;
            cbNumOfObject.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbNumOfObject.Location = new Point(12, 27);
            cbNumOfObject.Name = "cbNumOfObject";
            cbNumOfObject.Size = new Size(121, 23);
            cbNumOfObject.TabIndex = 31;
            cbNumOfObject.SelectedIndexChanged += cbNumOfObject_SelectedIndexChanged;
            // 
            // AddObjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(786, 561);
            Controls.Add(cbNumOfObject);
            Controls.Add(lblNoOfObjects);
            Controls.Add(btnUpdate);
            Controls.Add(dgObject);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddObjectForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Add World Objects";
            ((System.ComponentModel.ISupportInitialize)dgObject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgObject;
        private CustomControl.ExtendedLabel lblNoOfObjects;
        private CustomControl.ExtendedButton btnUpdate;
        private ComboBox cbNumOfObject;
        private ColorDialog colorDialog;
        private DataGridViewTextBoxColumn colNum;
        private DataGridViewTextBoxColumn colObjectID;
        private DataGridViewTextBoxColumn colSrc;
        private DataGridViewTextBoxColumn colPos;
        private DataGridViewTextBoxColumn colRot;
        private DataGridViewTextBoxColumn colScale;
    }
}