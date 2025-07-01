namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class TextureStep
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblHeader = new ExtendedLabel();
            gbTexture = new ExtendedGroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblTextureType = new ExtendedLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbAddTexture = new ExtendedRadioButton();
            rbRemoveTexture = new ExtendedRadioButton();
            pnlAddTexture = new Panel();
            dgTexture = new DataGridView();
            colPart = new DataGridViewTextBoxColumn();
            colRemove = new DataGridViewButtonColumn();
            colValue = new DataGridViewTextBoxColumn();
            btnAddBodyPart = new ExtendedButton();
            cbBodyPart = new ComboBox();
            lblBodyPart = new ExtendedLabel();
            cbTextureType = new ComboBox();
            lblAddTextureType = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbTarget = new ExtendedGroupBox();
            cbTargetType = new ComboBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            pnlPosition = new Panel();
            lblPosition = new ExtendedLabel();
            cbListIndex = new ComboBox();
            lblTarget = new ExtendedLabel();
            pnlRemoveTexture = new Panel();
            cbRemoveTextureType = new ComboBox();
            lblRemoveTextureType = new ExtendedLabel();
            gbTexture.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlAddTexture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgTexture).BeginInit();
            flowLayoutPanel3.SuspendLayout();
            gbTarget.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            pnlPosition.SuspendLayout();
            pnlRemoveTexture.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(3, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(78, 20);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "[Header]";
            lblHeader.TextResourceKey = "TextureStepHeader";
            // 
            // gbTexture
            // 
            gbTexture.AutoSize = true;
            gbTexture.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbTexture.Controls.Add(flowLayoutPanel4);
            gbTexture.FlatStyle = FlatStyle.Flat;
            gbTexture.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbTexture.Location = new Point(3, 354);
            gbTexture.MinimumSize = new Size(267, 0);
            gbTexture.Name = "gbTexture";
            gbTexture.Size = new Size(267, 439);
            gbTexture.TabIndex = 3;
            gbTexture.TabStop = false;
            gbTexture.Text = "[Texture]";
            gbTexture.TextResourceKey = "TextureStepGroupLabel";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(lblTextureType);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.Controls.Add(pnlAddTexture);
            flowLayoutPanel4.Controls.Add(pnlRemoveTexture);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(6, 21);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(253, 397);
            flowLayoutPanel4.TabIndex = 48;
            // 
            // lblTextureType
            // 
            lblTextureType.AutoSize = true;
            lblTextureType.Font = new Font("Microsoft Sans Serif", 9F);
            lblTextureType.ForeColor = SystemColors.ControlText;
            lblTextureType.Location = new Point(3, 0);
            lblTextureType.Name = "lblTextureType";
            lblTextureType.Size = new Size(39, 15);
            lblTextureType.TabIndex = 40;
            lblTextureType.Text = "[Type]";
            lblTextureType.TextResourceKey = "TextureStepTypeLabel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(rbAddTexture);
            flowLayoutPanel1.Controls.Add(rbRemoveTexture);
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.MaximumSize = new Size(254, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(223, 25);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // rbAddTexture
            // 
            rbAddTexture.AutoSize = true;
            rbAddTexture.Checked = true;
            rbAddTexture.Font = new Font("Microsoft Sans Serif", 9F);
            rbAddTexture.Location = new Point(3, 3);
            rbAddTexture.Name = "rbAddTexture";
            rbAddTexture.Size = new Size(93, 19);
            rbAddTexture.TabIndex = 30;
            rbAddTexture.TabStop = true;
            rbAddTexture.Text = "[AddTexture]";
            rbAddTexture.TextResourceKey = "TextureStepAddTextureLabel";
            rbAddTexture.UseVisualStyleBackColor = true;
            rbAddTexture.CheckedChanged += rbAddTexture_CheckedChanged;
            // 
            // rbRemoveTexture
            // 
            rbRemoveTexture.AutoSize = true;
            rbRemoveTexture.Font = new Font("Microsoft Sans Serif", 9F);
            rbRemoveTexture.Location = new Point(102, 3);
            rbRemoveTexture.Name = "rbRemoveTexture";
            rbRemoveTexture.Size = new Size(118, 19);
            rbRemoveTexture.TabIndex = 31;
            rbRemoveTexture.Text = "[RemoveTexture]";
            rbRemoveTexture.TextResourceKey = "TextureStepRemoveTextureLabel";
            rbRemoveTexture.UseVisualStyleBackColor = true;
            rbRemoveTexture.CheckedChanged += rbRemoveTexture_CheckedChanged;
            // 
            // pnlAddTexture
            // 
            pnlAddTexture.Controls.Add(dgTexture);
            pnlAddTexture.Controls.Add(btnAddBodyPart);
            pnlAddTexture.Controls.Add(cbBodyPart);
            pnlAddTexture.Controls.Add(lblBodyPart);
            pnlAddTexture.Controls.Add(cbTextureType);
            pnlAddTexture.Controls.Add(lblAddTextureType);
            pnlAddTexture.Location = new Point(3, 49);
            pnlAddTexture.Name = "pnlAddTexture";
            pnlAddTexture.Size = new Size(247, 277);
            pnlAddTexture.TabIndex = 45;
            // 
            // dgTexture
            // 
            dgTexture.AllowUserToAddRows = false;
            dgTexture.AllowUserToResizeColumns = false;
            dgTexture.AllowUserToResizeRows = false;
            dgTexture.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgTexture.BorderStyle = BorderStyle.None;
            dgTexture.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgTexture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgTexture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTexture.Columns.AddRange(new DataGridViewColumn[] { colPart, colRemove, colValue });
            dgTexture.GridColor = Color.FromArgb(128, 128, 255);
            dgTexture.Location = new Point(4, 102);
            dgTexture.MultiSelect = false;
            dgTexture.Name = "dgTexture";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgTexture.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgTexture.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgTexture.ScrollBars = ScrollBars.Vertical;
            dgTexture.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgTexture.Size = new Size(240, 166);
            dgTexture.TabIndex = 46;
            dgTexture.CellContentClick += dgTexture_CellContentClick;
            // 
            // colPart
            // 
            colPart.DataPropertyName = "display_text";
            colPart.HeaderText = "[Part]";
            colPart.Name = "colPart";
            colPart.ReadOnly = true;
            colPart.Width = 120;
            // 
            // colRemove
            // 
            colRemove.HeaderText = "";
            colRemove.Name = "colRemove";
            colRemove.UseColumnTextForButtonValue = true;
            colRemove.Width = 60;
            // 
            // colValue
            // 
            colValue.DataPropertyName = "value";
            colValue.HeaderText = "[value]";
            colValue.Name = "colValue";
            colValue.Visible = false;
            // 
            // btnAddBodyPart
            // 
            btnAddBodyPart.FlatStyle = FlatStyle.Flat;
            btnAddBodyPart.Font = new Font("Microsoft Sans Serif", 8F);
            btnAddBodyPart.Location = new Point(150, 73);
            btnAddBodyPart.Name = "btnAddBodyPart";
            btnAddBodyPart.Size = new Size(75, 23);
            btnAddBodyPart.TabIndex = 47;
            btnAddBodyPart.Text = "[Add]";
            btnAddBodyPart.TextResourceKey = "Add";
            btnAddBodyPart.UseVisualStyleBackColor = true;
            btnAddBodyPart.Click += btnAddBodyPart_Click;
            // 
            // cbBodyPart
            // 
            cbBodyPart.DisplayMember = "DisplayText";
            cbBodyPart.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBodyPart.FlatStyle = FlatStyle.Flat;
            cbBodyPart.Font = new Font("Microsoft Sans Serif", 9F);
            cbBodyPart.FormattingEnabled = true;
            cbBodyPart.Location = new Point(4, 73);
            cbBodyPart.Name = "cbBodyPart";
            cbBodyPart.Size = new Size(111, 23);
            cbBodyPart.TabIndex = 45;
            cbBodyPart.ValueMember = "DataKey";
            // 
            // lblBodyPart
            // 
            lblBodyPart.AutoSize = true;
            lblBodyPart.Font = new Font("Microsoft Sans Serif", 9F);
            lblBodyPart.ForeColor = SystemColors.ControlText;
            lblBodyPart.Location = new Point(4, 55);
            lblBodyPart.Name = "lblBodyPart";
            lblBodyPart.Size = new Size(62, 15);
            lblBodyPart.TabIndex = 44;
            lblBodyPart.Text = "[BodyPart]";
            lblBodyPart.TextResourceKey = "TextureStepAddTextureBodyPartLabel";
            // 
            // cbTextureType
            // 
            cbTextureType.DisplayMember = "DisplayText";
            cbTextureType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTextureType.FlatStyle = FlatStyle.Flat;
            cbTextureType.Font = new Font("Microsoft Sans Serif", 9F);
            cbTextureType.FormattingEnabled = true;
            cbTextureType.Location = new Point(4, 29);
            cbTextureType.Name = "cbTextureType";
            cbTextureType.Size = new Size(111, 23);
            cbTextureType.TabIndex = 43;
            cbTextureType.ValueMember = "DataKey";
            cbTextureType.SelectedIndexChanged += cbTextureType_SelectedIndexChanged;
            // 
            // lblAddTextureType
            // 
            lblAddTextureType.AutoSize = true;
            lblAddTextureType.Font = new Font("Microsoft Sans Serif", 9F);
            lblAddTextureType.ForeColor = SystemColors.ControlText;
            lblAddTextureType.Location = new Point(3, 11);
            lblAddTextureType.Name = "lblAddTextureType";
            lblAddTextureType.Size = new Size(80, 15);
            lblAddTextureType.TabIndex = 42;
            lblAddTextureType.Text = "[TextureType]";
            lblAddTextureType.TextResourceKey = "TextureStepAddTextureTypeLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbTarget);
            flowLayoutPanel3.Controls.Add(gbTexture);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 796);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // ucBasicStepInfo
            // 
            ucBasicStepInfo.Font = new Font("Microsoft JhengHei UI", 9F);
            ucBasicStepInfo.Location = new Point(3, 3);
            ucBasicStepInfo.Name = "ucBasicStepInfo";
            ucBasicStepInfo.Size = new Size(278, 204);
            ucBasicStepInfo.StepID = "";
            ucBasicStepInfo.StepName = "";
            ucBasicStepInfo.StepNextID = "";
            ucBasicStepInfo.TabIndex = 6;
            // 
            // gbTarget
            // 
            gbTarget.AutoSize = true;
            gbTarget.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbTarget.Controls.Add(cbTargetType);
            gbTarget.Controls.Add(flowLayoutPanel5);
            gbTarget.Controls.Add(lblTarget);
            gbTarget.FlatStyle = FlatStyle.Flat;
            gbTarget.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbTarget.Location = new Point(3, 213);
            gbTarget.Name = "gbTarget";
            gbTarget.Size = new Size(267, 135);
            gbTarget.TabIndex = 7;
            gbTarget.TabStop = false;
            gbTarget.Text = "[Target]";
            gbTarget.TextResourceKey = "TextureStepTargetGroupLabel";
            // 
            // cbTargetType
            // 
            cbTargetType.DisplayMember = "DisplayText";
            cbTargetType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTargetType.FlatStyle = FlatStyle.Flat;
            cbTargetType.Font = new Font("Microsoft Sans Serif", 9F);
            cbTargetType.FormattingEnabled = true;
            cbTargetType.Location = new Point(13, 36);
            cbTargetType.Name = "cbTargetType";
            cbTargetType.Size = new Size(248, 23);
            cbTargetType.TabIndex = 21;
            cbTargetType.ValueMember = "DataKey";
            cbTargetType.SelectedIndexChanged += cbTargetType_SelectedIndexChanged;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(pnlPosition);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(6, 76);
            flowLayoutPanel5.Margin = new Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(258, 41);
            flowLayoutPanel5.TabIndex = 4;
            // 
            // pnlPosition
            // 
            pnlPosition.Controls.Add(lblPosition);
            pnlPosition.Controls.Add(cbListIndex);
            pnlPosition.Location = new Point(3, 3);
            pnlPosition.Name = "pnlPosition";
            pnlPosition.Size = new Size(252, 35);
            pnlPosition.TabIndex = 23;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblPosition.Location = new Point(4, 6);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 15);
            lblPosition.TabIndex = 21;
            lblPosition.Text = "[Position]";
            lblPosition.TextResourceKey = "TextureStepListPositionLabel";
            // 
            // cbListIndex
            // 
            cbListIndex.DisplayMember = "Value";
            cbListIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListIndex.FlatStyle = FlatStyle.Flat;
            cbListIndex.Font = new Font("Microsoft Sans Serif", 9F);
            cbListIndex.FormattingEnabled = true;
            cbListIndex.Location = new Point(141, 3);
            cbListIndex.Name = "cbListIndex";
            cbListIndex.Size = new Size(111, 23);
            cbListIndex.TabIndex = 20;
            cbListIndex.ValueMember = "Key";
            // 
            // lblTarget
            // 
            lblTarget.AutoSize = true;
            lblTarget.Font = new Font("Microsoft Sans Serif", 9F);
            lblTarget.Location = new Point(13, 18);
            lblTarget.Name = "lblTarget";
            lblTarget.Size = new Size(39, 15);
            lblTarget.TabIndex = 20;
            lblTarget.Text = "[Type]";
            lblTarget.TextResourceKey = "TextureStepTargetTypeLabel";
            // 
            // pnlRemoveTexture
            // 
            pnlRemoveTexture.Controls.Add(cbRemoveTextureType);
            pnlRemoveTexture.Controls.Add(lblRemoveTextureType);
            pnlRemoveTexture.Location = new Point(3, 332);
            pnlRemoveTexture.Name = "pnlRemoveTexture";
            pnlRemoveTexture.Size = new Size(247, 62);
            pnlRemoveTexture.TabIndex = 46;
            // 
            // cbRemoveTextureType
            // 
            cbRemoveTextureType.DisplayMember = "DisplayText";
            cbRemoveTextureType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRemoveTextureType.FlatStyle = FlatStyle.Flat;
            cbRemoveTextureType.Font = new Font("Microsoft Sans Serif", 9F);
            cbRemoveTextureType.FormattingEnabled = true;
            cbRemoveTextureType.Location = new Point(4, 29);
            cbRemoveTextureType.Name = "cbRemoveTextureType";
            cbRemoveTextureType.Size = new Size(111, 23);
            cbRemoveTextureType.TabIndex = 43;
            cbRemoveTextureType.ValueMember = "DataKey";
            // 
            // lblRemoveTextureType
            // 
            lblRemoveTextureType.AutoSize = true;
            lblRemoveTextureType.Font = new Font("Microsoft Sans Serif", 9F);
            lblRemoveTextureType.ForeColor = SystemColors.ControlText;
            lblRemoveTextureType.Location = new Point(3, 11);
            lblRemoveTextureType.Name = "lblRemoveTextureType";
            lblRemoveTextureType.Size = new Size(80, 15);
            lblRemoveTextureType.TabIndex = 42;
            lblRemoveTextureType.Text = "[TextureType]";
            lblRemoveTextureType.TextResourceKey = "TextureStepAddTextureTypeLabel";
            // 
            // TextureStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "TextureStep";
            Size = new Size(324, 845);
            gbTexture.ResumeLayout(false);
            gbTexture.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlAddTexture.ResumeLayout(false);
            pnlAddTexture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgTexture).EndInit();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            gbTarget.ResumeLayout(false);
            gbTarget.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            pnlPosition.ResumeLayout(false);
            pnlPosition.PerformLayout();
            pnlRemoveTexture.ResumeLayout(false);
            pnlRemoveTexture.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbTexture;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private FlowLayoutPanel flowLayoutPanel4;
        private ExtendedLabel lblTextureType;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedRadioButton rbAddTexture;
        private ExtendedRadioButton rbRemoveTexture;
        private ExtendedLabel lblAddTextureType;
        private Panel pnlAddTexture;
        private ComboBox cbTextureType;
        private ExtendedGroupBox gbTarget;
        private ExtendedLabel lblPosition;
        private ComboBox cbListIndex;
        private ComboBox cbTargetType;
        private ExtendedLabel lblTarget;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel pnlPosition;
        private ExtendedLabel lblBodyPart;
        private FlowLayoutPanel flowLayoutPanel2;
        private ExtendedLabel lblRemoveObjectInstructionLabel;
        private ComboBox cbBodyPart;
        private DataGridView dgTexture;
        private ExtendedButton btnAddBodyPart;
        private DataGridViewTextBoxColumn colPart;
        private DataGridViewButtonColumn colRemove;
        private DataGridViewTextBoxColumn colValue;
        private Panel pnlRemoveTexture;
        private ComboBox cbRemoveTextureType;
        private ExtendedLabel lblRemoveTextureType;
    }
}
