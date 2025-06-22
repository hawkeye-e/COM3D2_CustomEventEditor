namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class ShowOptionStep
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
            lblHeader = new ExtendedLabel();
            gbShowOption = new ExtendedGroupBox();
            txtVariableName = new CustomControls.RJControls.RJTextBox();
            lblVariableName = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            lblOptionCountValue = new ExtendedLabel();
            btnEditOption = new ExtendedButton();
            lblOptionCount = new ExtendedLabel();
            gbShowOption.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
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
            lblHeader.TextResourceKey = "ShowOptionStepHeader";
            // 
            // gbShowOption
            // 
            gbShowOption.AutoSize = true;
            gbShowOption.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbShowOption.Controls.Add(lblOptionCountValue);
            gbShowOption.Controls.Add(btnEditOption);
            gbShowOption.Controls.Add(lblOptionCount);
            gbShowOption.Controls.Add(txtVariableName);
            gbShowOption.Controls.Add(lblVariableName);
            gbShowOption.FlatStyle = FlatStyle.Flat;
            gbShowOption.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbShowOption.Location = new Point(3, 213);
            gbShowOption.MinimumSize = new Size(267, 0);
            gbShowOption.Name = "gbShowOption";
            gbShowOption.Size = new Size(268, 146);
            gbShowOption.TabIndex = 3;
            gbShowOption.TabStop = false;
            gbShowOption.Text = "[ShowOption]";
            gbShowOption.TextResourceKey = "ShowOptionStepGroupLabel";
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
            txtVariableName.Location = new Point(6, 59);
            txtVariableName.Margin = new Padding(4);
            txtVariableName.Multiline = false;
            txtVariableName.Name = "txtVariableName";
            txtVariableName.Padding = new Padding(7);
            txtVariableName.PasswordChar = false;
            txtVariableName.ReadOnly = false;
            txtVariableName.Size = new Size(255, 31);
            txtVariableName.TabIndex = 30;
            txtVariableName.Texts = "";
            txtVariableName.UnderlinedStyle = false;
            // 
            // lblVariableName
            // 
            lblVariableName.Font = new Font("Microsoft Sans Serif", 9F);
            lblVariableName.ForeColor = SystemColors.ControlText;
            lblVariableName.Location = new Point(6, 22);
            lblVariableName.Name = "lblVariableName";
            lblVariableName.Size = new Size(255, 33);
            lblVariableName.TabIndex = 23;
            lblVariableName.Text = "[NameOfVariable]";
            lblVariableName.TextResourceKey = "ShowOptionStepVariableNameLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbShowOption);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 580);
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
            // lblOptionCountValue
            // 
            lblOptionCountValue.AutoSize = true;
            lblOptionCountValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblOptionCountValue.ForeColor = SystemColors.ControlText;
            lblOptionCountValue.Location = new Point(150, 105);
            lblOptionCountValue.Name = "lblOptionCountValue";
            lblOptionCountValue.Size = new Size(14, 15);
            lblOptionCountValue.TabIndex = 35;
            lblOptionCountValue.Text = "0";
            lblOptionCountValue.TextAlign = ContentAlignment.TopRight;
            lblOptionCountValue.TextResourceKey = "";
            // 
            // btnEditOption
            // 
            btnEditOption.FlatStyle = FlatStyle.Flat;
            btnEditOption.Font = new Font("Microsoft Sans Serif", 8F);
            btnEditOption.Location = new Point(186, 102);
            btnEditOption.Name = "btnEditOption";
            btnEditOption.Size = new Size(75, 23);
            btnEditOption.TabIndex = 33;
            btnEditOption.Text = "[Edit]";
            btnEditOption.TextResourceKey = "Edit";
            btnEditOption.UseVisualStyleBackColor = true;
            btnEditOption.Click += btnEditOption_Click;
            // 
            // lblOptionCount
            // 
            lblOptionCount.AutoSize = true;
            lblOptionCount.Font = new Font("Microsoft Sans Serif", 9F);
            lblOptionCount.ForeColor = SystemColors.ControlText;
            lblOptionCount.Location = new Point(6, 105);
            lblOptionCount.Name = "lblOptionCount";
            lblOptionCount.Size = new Size(77, 15);
            lblOptionCount.TabIndex = 34;
            lblOptionCount.Text = "[NoOfOption]";
            lblOptionCount.TextResourceKey = "ShowOptionStepOptionCountLabel";
            // 
            // ShowOptionStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "ShowOptionStep";
            Size = new Size(324, 1043);
            gbShowOption.ResumeLayout(false);
            gbShowOption.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbShowOption;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private CustomControls.RJControls.RJTextBox txtVariableName;
        private ExtendedLabel lblVariableName;
        private ExtendedLabel lblOptionCountValue;
        private ExtendedButton btnEditOption;
        private ExtendedLabel lblOptionCount;
    }
}
