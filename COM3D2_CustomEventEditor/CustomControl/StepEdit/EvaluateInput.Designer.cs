namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class EvaluateInput
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
            txtVariableName = new CustomControls.RJControls.RJTextBox();
            lblVariableName = new ExtendedLabel();
            gbInput = new ExtendedGroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pnlVariable = new Panel();
            pnlCharaStatus = new Panel();
            cbFieldName = new ComboBox();
            lblFieldName = new ExtendedLabel();
            lblPosition = new ExtendedLabel();
            cbListIndex = new ComboBox();
            cbListType = new ComboBox();
            lblListType = new ExtendedLabel();
            pnlFixedValue = new Panel();
            cbFixedValueType = new ComboBox();
            lblFixedValueType = new ExtendedLabel();
            lblFixedValue = new ExtendedLabel();
            txtFixedValue = new CustomControls.RJControls.RJTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbVariable = new ExtendedRadioButton();
            rbCharaStatus = new ExtendedRadioButton();
            rbFixedValue = new ExtendedRadioButton();
            lblSourceType = new ExtendedLabel();
            rbRandomNumber = new ExtendedRadioButton();
            pnlRandomNumber = new Panel();
            lblMaxValue = new ExtendedLabel();
            txtMaxValue = new CustomControls.RJControls.RJTextBox();
            gbInput.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            pnlVariable.SuspendLayout();
            pnlCharaStatus.SuspendLayout();
            pnlFixedValue.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlRandomNumber.SuspendLayout();
            SuspendLayout();
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
            txtVariableName.Location = new Point(6, 19);
            txtVariableName.Margin = new Padding(4);
            txtVariableName.Multiline = false;
            txtVariableName.Name = "txtVariableName";
            txtVariableName.Padding = new Padding(7);
            txtVariableName.PasswordChar = false;
            txtVariableName.ReadOnly = false;
            txtVariableName.Size = new Size(230, 31);
            txtVariableName.TabIndex = 6;
            txtVariableName.Texts = "";
            txtVariableName.UnderlinedStyle = false;
            // 
            // lblVariableName
            // 
            lblVariableName.AutoSize = true;
            lblVariableName.Font = new Font("Microsoft Sans Serif", 9F);
            lblVariableName.Location = new Point(6, 0);
            lblVariableName.Name = "lblVariableName";
            lblVariableName.Size = new Size(92, 15);
            lblVariableName.TabIndex = 5;
            lblVariableName.Text = "[VariableName]";
            lblVariableName.TextResourceKey = "EvaluateInputVariableNameLabel";
            // 
            // gbInput
            // 
            gbInput.AutoSize = true;
            gbInput.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbInput.Controls.Add(flowLayoutPanel2);
            gbInput.Controls.Add(flowLayoutPanel1);
            gbInput.Controls.Add(lblSourceType);
            gbInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            gbInput.Location = new Point(0, 3);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(267, 504);
            gbInput.TabIndex = 11;
            gbInput.TabStop = false;
            gbInput.Text = "[Input]";
            gbInput.TextResourceKey = "";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(pnlVariable);
            flowLayoutPanel2.Controls.Add(pnlCharaStatus);
            flowLayoutPanel2.Controls.Add(pnlFixedValue);
            flowLayoutPanel2.Controls.Add(pnlRandomNumber);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 91);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(258, 393);
            flowLayoutPanel2.TabIndex = 43;
            // 
            // pnlVariable
            // 
            pnlVariable.Controls.Add(lblVariableName);
            pnlVariable.Controls.Add(txtVariableName);
            pnlVariable.Location = new Point(3, 3);
            pnlVariable.Name = "pnlVariable";
            pnlVariable.Size = new Size(252, 64);
            pnlVariable.TabIndex = 0;
            // 
            // pnlCharaStatus
            // 
            pnlCharaStatus.Controls.Add(cbFieldName);
            pnlCharaStatus.Controls.Add(lblFieldName);
            pnlCharaStatus.Controls.Add(lblPosition);
            pnlCharaStatus.Controls.Add(cbListIndex);
            pnlCharaStatus.Controls.Add(cbListType);
            pnlCharaStatus.Controls.Add(lblListType);
            pnlCharaStatus.Location = new Point(3, 73);
            pnlCharaStatus.Name = "pnlCharaStatus";
            pnlCharaStatus.Size = new Size(252, 137);
            pnlCharaStatus.TabIndex = 1;
            // 
            // cbFieldName
            // 
            cbFieldName.DisplayMember = "DisplayText";
            cbFieldName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFieldName.FlatStyle = FlatStyle.Flat;
            cbFieldName.Font = new Font("Microsoft Sans Serif", 9F);
            cbFieldName.FormattingEnabled = true;
            cbFieldName.Location = new Point(6, 100);
            cbFieldName.Name = "cbFieldName";
            cbFieldName.Size = new Size(230, 23);
            cbFieldName.TabIndex = 28;
            cbFieldName.ValueMember = "DataKey";
            // 
            // lblFieldName
            // 
            lblFieldName.AutoSize = true;
            lblFieldName.Font = new Font("Microsoft Sans Serif", 9F);
            lblFieldName.Location = new Point(6, 82);
            lblFieldName.Name = "lblFieldName";
            lblFieldName.Size = new Size(74, 15);
            lblFieldName.TabIndex = 26;
            lblFieldName.Text = "[FieldName]";
            lblFieldName.TextResourceKey = "EvaluateInputFieldNameLabel";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblPosition.Location = new Point(6, 49);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 15);
            lblPosition.TabIndex = 25;
            lblPosition.Text = "[Position]";
            lblPosition.TextResourceKey = "EvaluateInputListPositionLabel";
            // 
            // cbListIndex
            // 
            cbListIndex.DisplayMember = "Value";
            cbListIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListIndex.FlatStyle = FlatStyle.Flat;
            cbListIndex.Font = new Font("Microsoft Sans Serif", 9F);
            cbListIndex.FormattingEnabled = true;
            cbListIndex.Location = new Point(125, 49);
            cbListIndex.Name = "cbListIndex";
            cbListIndex.Size = new Size(111, 23);
            cbListIndex.TabIndex = 24;
            cbListIndex.ValueMember = "Key";
            // 
            // cbListType
            // 
            cbListType.DisplayMember = "DisplayText";
            cbListType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListType.FlatStyle = FlatStyle.Flat;
            cbListType.Font = new Font("Microsoft Sans Serif", 9F);
            cbListType.FormattingEnabled = true;
            cbListType.Location = new Point(6, 18);
            cbListType.Name = "cbListType";
            cbListType.Size = new Size(230, 23);
            cbListType.TabIndex = 23;
            cbListType.ValueMember = "DataKey";
            cbListType.SelectedIndexChanged += cbListType_SelectedIndexChanged;
            // 
            // lblListType
            // 
            lblListType.AutoSize = true;
            lblListType.Font = new Font("Microsoft Sans Serif", 9F);
            lblListType.Location = new Point(6, 0);
            lblListType.Name = "lblListType";
            lblListType.Size = new Size(39, 15);
            lblListType.TabIndex = 22;
            lblListType.Text = "[Type]";
            lblListType.TextResourceKey = "EvaluateInputListTypeLabel";
            // 
            // pnlFixedValue
            // 
            pnlFixedValue.Controls.Add(cbFixedValueType);
            pnlFixedValue.Controls.Add(lblFixedValueType);
            pnlFixedValue.Controls.Add(lblFixedValue);
            pnlFixedValue.Controls.Add(txtFixedValue);
            pnlFixedValue.Location = new Point(3, 216);
            pnlFixedValue.Name = "pnlFixedValue";
            pnlFixedValue.Size = new Size(252, 104);
            pnlFixedValue.TabIndex = 2;
            // 
            // cbFixedValueType
            // 
            cbFixedValueType.DisplayMember = "DisplayText";
            cbFixedValueType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFixedValueType.FlatStyle = FlatStyle.Flat;
            cbFixedValueType.Font = new Font("Microsoft Sans Serif", 9F);
            cbFixedValueType.FormattingEnabled = true;
            cbFixedValueType.Location = new Point(6, 18);
            cbFixedValueType.Name = "cbFixedValueType";
            cbFixedValueType.Size = new Size(230, 23);
            cbFixedValueType.TabIndex = 25;
            cbFixedValueType.ValueMember = "DataKey";
            // 
            // lblFixedValueType
            // 
            lblFixedValueType.AutoSize = true;
            lblFixedValueType.Font = new Font("Microsoft Sans Serif", 9F);
            lblFixedValueType.Location = new Point(6, 0);
            lblFixedValueType.Name = "lblFixedValueType";
            lblFixedValueType.Size = new Size(100, 15);
            lblFixedValueType.TabIndex = 24;
            lblFixedValueType.Text = "[FixedValueType]";
            lblFixedValueType.TextResourceKey = "EvaluateInputFixedValueTypeLabel";
            // 
            // lblFixedValue
            // 
            lblFixedValue.AutoSize = true;
            lblFixedValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblFixedValue.Location = new Point(6, 44);
            lblFixedValue.Name = "lblFixedValue";
            lblFixedValue.Size = new Size(74, 15);
            lblFixedValue.TabIndex = 5;
            lblFixedValue.Text = "[FixedValue]";
            lblFixedValue.TextResourceKey = "EvaluateInputFixedValueLabel";
            // 
            // txtFixedValue
            // 
            txtFixedValue.AutoScroll = true;
            txtFixedValue.BackColor = SystemColors.Window;
            txtFixedValue.BorderColor = Color.FromArgb(66, 124, 244);
            txtFixedValue.BorderFocusColor = Color.HotPink;
            txtFixedValue.BorderSize = 2;
            txtFixedValue.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFixedValue.ForeColor = Color.Black;
            txtFixedValue.Location = new Point(6, 63);
            txtFixedValue.Margin = new Padding(4);
            txtFixedValue.Multiline = false;
            txtFixedValue.Name = "txtFixedValue";
            txtFixedValue.Padding = new Padding(7);
            txtFixedValue.PasswordChar = false;
            txtFixedValue.ReadOnly = false;
            txtFixedValue.Size = new Size(230, 31);
            txtFixedValue.TabIndex = 6;
            txtFixedValue.Texts = "";
            txtFixedValue.UnderlinedStyle = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(rbVariable);
            flowLayoutPanel1.Controls.Add(rbCharaStatus);
            flowLayoutPanel1.Controls.Add(rbFixedValue);
            flowLayoutPanel1.Controls.Add(rbRandomNumber);
            flowLayoutPanel1.Location = new Point(9, 35);
            flowLayoutPanel1.MaximumSize = new Size(254, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(228, 50);
            flowLayoutPanel1.TabIndex = 42;
            // 
            // rbVariable
            // 
            rbVariable.AutoSize = true;
            rbVariable.Checked = true;
            rbVariable.Font = new Font("Microsoft Sans Serif", 9F);
            rbVariable.Location = new Point(3, 3);
            rbVariable.Name = "rbVariable";
            rbVariable.Size = new Size(76, 19);
            rbVariable.TabIndex = 30;
            rbVariable.TabStop = true;
            rbVariable.Text = "[Variable]";
            rbVariable.TextResourceKey = "EvaluateInputSourceTypeVariableLabel";
            rbVariable.UseVisualStyleBackColor = true;
            rbVariable.CheckedChanged += rbSourceTypeVariable_CheckedChanged;
            // 
            // rbCharaStatus
            // 
            rbCharaStatus.AutoSize = true;
            rbCharaStatus.Font = new Font("Microsoft Sans Serif", 9F);
            rbCharaStatus.Location = new Point(85, 3);
            rbCharaStatus.Name = "rbCharaStatus";
            rbCharaStatus.Size = new Size(118, 19);
            rbCharaStatus.TabIndex = 31;
            rbCharaStatus.Text = "[CharacterStatus]";
            rbCharaStatus.TextResourceKey = "EvaluateInputSourceTypeCharaStatusLabel";
            rbCharaStatus.UseVisualStyleBackColor = true;
            rbCharaStatus.CheckedChanged += rbCharaStatus_CheckedChanged;
            // 
            // rbFixedValue
            // 
            rbFixedValue.AutoSize = true;
            rbFixedValue.Font = new Font("Microsoft Sans Serif", 9F);
            rbFixedValue.Location = new Point(3, 28);
            rbFixedValue.Name = "rbFixedValue";
            rbFixedValue.Size = new Size(92, 19);
            rbFixedValue.TabIndex = 32;
            rbFixedValue.Text = "[FixedValue]";
            rbFixedValue.TextResourceKey = "EvaluateInputSourceTypeFixedValueLabel";
            rbFixedValue.UseVisualStyleBackColor = true;
            rbFixedValue.CheckedChanged += rbFixedValue_CheckedChanged;
            // 
            // lblSourceType
            // 
            lblSourceType.AutoSize = true;
            lblSourceType.Font = new Font("Microsoft Sans Serif", 9F);
            lblSourceType.Location = new Point(9, 17);
            lblSourceType.Name = "lblSourceType";
            lblSourceType.Size = new Size(78, 15);
            lblSourceType.TabIndex = 23;
            lblSourceType.Text = "[SourceType]";
            lblSourceType.TextResourceKey = "EvaluateInputSourceTypeLabel";
            // 
            // rbRandomNumber
            // 
            rbRandomNumber.AutoSize = true;
            rbRandomNumber.Font = new Font("Microsoft Sans Serif", 9F);
            rbRandomNumber.Location = new Point(101, 28);
            rbRandomNumber.Name = "rbRandomNumber";
            rbRandomNumber.Size = new Size(124, 19);
            rbRandomNumber.TabIndex = 33;
            rbRandomNumber.Text = "[RandomNumber]";
            rbRandomNumber.TextResourceKey = "EvaluateInputSourceTypeRandomNumberLabel";
            rbRandomNumber.UseVisualStyleBackColor = true;
            // 
            // pnlRandomNumber
            // 
            pnlRandomNumber.Controls.Add(lblMaxValue);
            pnlRandomNumber.Controls.Add(txtMaxValue);
            pnlRandomNumber.Location = new Point(3, 326);
            pnlRandomNumber.Name = "pnlRandomNumber";
            pnlRandomNumber.Size = new Size(252, 64);
            pnlRandomNumber.TabIndex = 7;
            // 
            // lblMaxValue
            // 
            lblMaxValue.AutoSize = true;
            lblMaxValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblMaxValue.Location = new Point(6, 0);
            lblMaxValue.Name = "lblMaxValue";
            lblMaxValue.Size = new Size(92, 15);
            lblMaxValue.TabIndex = 5;
            lblMaxValue.Text = "[VariableName]";
            lblMaxValue.TextResourceKey = "EvaluateInputMaxValueLabel";
            // 
            // txtMaxValue
            // 
            txtMaxValue.AutoScroll = true;
            txtMaxValue.BackColor = SystemColors.Window;
            txtMaxValue.BorderColor = Color.FromArgb(66, 124, 244);
            txtMaxValue.BorderFocusColor = Color.HotPink;
            txtMaxValue.BorderSize = 2;
            txtMaxValue.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaxValue.ForeColor = Color.Black;
            txtMaxValue.Location = new Point(6, 19);
            txtMaxValue.Margin = new Padding(4);
            txtMaxValue.Multiline = false;
            txtMaxValue.Name = "txtMaxValue";
            txtMaxValue.Padding = new Padding(7);
            txtMaxValue.PasswordChar = false;
            txtMaxValue.ReadOnly = false;
            txtMaxValue.Size = new Size(230, 31);
            txtMaxValue.TabIndex = 6;
            txtMaxValue.Texts = "";
            txtMaxValue.UnderlinedStyle = false;
            // 
            // EvaluateInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(gbInput);
            Name = "EvaluateInput";
            Size = new Size(270, 510);
            gbInput.ResumeLayout(false);
            gbInput.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            pnlVariable.ResumeLayout(false);
            pnlVariable.PerformLayout();
            pnlCharaStatus.ResumeLayout(false);
            pnlCharaStatus.PerformLayout();
            pnlFixedValue.ResumeLayout(false);
            pnlFixedValue.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlRandomNumber.ResumeLayout(false);
            pnlRandomNumber.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtVariableName;
        private ExtendedLabel lblVariableName;
        private ExtendedGroupBox gbInput;
        private ExtendedLabel lblSourceType;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedRadioButton rbVariable;
        private ExtendedRadioButton rbCharaStatus;
        private ExtendedRadioButton rbFixedValue;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnlVariable;
        private Panel pnlCharaStatus;
        private ComboBox cbListType;
        private ExtendedLabel lblListType;
        private ExtendedLabel lblPosition;
        private ComboBox cbListIndex;
        private ExtendedLabel lblFieldName;
        private Panel pnlFixedValue;
        private ComboBox cbFixedValueType;
        private ExtendedLabel lblFixedValueType;
        private ExtendedLabel lblFixedValue;
        private CustomControls.RJControls.RJTextBox txtFixedValue;
        private ComboBox cbFieldName;
        private ExtendedRadioButton rbRandomNumber;
        private Panel pnlRandomNumber;
        private ExtendedLabel lblMaxValue;
        private CustomControls.RJControls.RJTextBox txtMaxValue;
    }
}
