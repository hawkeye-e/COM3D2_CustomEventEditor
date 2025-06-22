namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class BasicStepInfo
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
            txtStepID = new CustomControls.RJControls.RJTextBox();
            lblStepID = new ExtendedLabel();
            txtStepName = new CustomControls.RJControls.RJTextBox();
            lblStepName = new ExtendedLabel();
            txtNextStepID = new CustomControls.RJControls.RJTextBox();
            lblNextStep = new ExtendedLabel();
            gbBasicInfo = new ExtendedGroupBox();
            cbWaitingType = new ComboBox();
            lblWaitingType = new ExtendedLabel();
            gbBasicInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtStepID
            // 
            txtStepID.AutoScroll = true;
            txtStepID.BackColor = SystemColors.Window;
            txtStepID.BorderColor = Color.FromArgb(66, 124, 244);
            txtStepID.BorderFocusColor = Color.HotPink;
            txtStepID.BorderSize = 2;
            txtStepID.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStepID.ForeColor = Color.Black;
            txtStepID.Location = new Point(7, 38);
            txtStepID.Margin = new Padding(4);
            txtStepID.Multiline = false;
            txtStepID.Name = "txtStepID";
            txtStepID.Padding = new Padding(7);
            txtStepID.PasswordChar = false;
            txtStepID.ReadOnly = false;
            txtStepID.Size = new Size(125, 31);
            txtStepID.TabIndex = 6;
            txtStepID.Texts = "";
            txtStepID.UnderlinedStyle = false;
            txtStepID._TextChanged += txtStepID__TextChanged;
            txtStepID.Validating += txtStepID_Validating;
            // 
            // lblStepID
            // 
            lblStepID.AutoSize = true;
            lblStepID.Font = new Font("Microsoft Sans Serif", 9F);
            lblStepID.Location = new Point(1, 19);
            lblStepID.Name = "lblStepID";
            lblStepID.Size = new Size(50, 15);
            lblStepID.TabIndex = 5;
            lblStepID.Text = "[StepID]";
            lblStepID.TextResourceKey = "BasicInfoStepIDLabel";
            // 
            // txtStepName
            // 
            txtStepName.AutoScroll = true;
            txtStepName.BackColor = SystemColors.Window;
            txtStepName.BorderColor = Color.FromArgb(66, 124, 244);
            txtStepName.BorderFocusColor = Color.HotPink;
            txtStepName.BorderSize = 2;
            txtStepName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStepName.ForeColor = Color.Black;
            txtStepName.Location = new Point(7, 92);
            txtStepName.Margin = new Padding(4);
            txtStepName.Multiline = false;
            txtStepName.Name = "txtStepName";
            txtStepName.Padding = new Padding(7);
            txtStepName.PasswordChar = false;
            txtStepName.ReadOnly = false;
            txtStepName.Size = new Size(255, 31);
            txtStepName.TabIndex = 8;
            txtStepName.Texts = "";
            txtStepName.UnderlinedStyle = false;
            txtStepName._TextChanged += txtStepName__TextChanged;
            // 
            // lblStepName
            // 
            lblStepName.AutoSize = true;
            lblStepName.Font = new Font("Microsoft Sans Serif", 9F);
            lblStepName.Location = new Point(1, 73);
            lblStepName.Name = "lblStepName";
            lblStepName.Size = new Size(72, 15);
            lblStepName.TabIndex = 7;
            lblStepName.Text = "[StepName]";
            lblStepName.TextResourceKey = "BasicInfoStepNameLabel";
            // 
            // txtNextStepID
            // 
            txtNextStepID.AutoScroll = true;
            txtNextStepID.BackColor = SystemColors.Window;
            txtNextStepID.BorderColor = Color.FromArgb(66, 124, 244);
            txtNextStepID.BorderFocusColor = Color.HotPink;
            txtNextStepID.BorderSize = 2;
            txtNextStepID.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNextStepID.ForeColor = Color.Black;
            txtNextStepID.Location = new Point(142, 38);
            txtNextStepID.Margin = new Padding(4);
            txtNextStepID.Multiline = false;
            txtNextStepID.Name = "txtNextStepID";
            txtNextStepID.Padding = new Padding(7);
            txtNextStepID.PasswordChar = false;
            txtNextStepID.ReadOnly = false;
            txtNextStepID.Size = new Size(120, 31);
            txtNextStepID.TabIndex = 10;
            txtNextStepID.Texts = "";
            txtNextStepID.UnderlinedStyle = false;
            // 
            // lblNextStep
            // 
            lblNextStep.AutoSize = true;
            lblNextStep.Font = new Font("Microsoft Sans Serif", 9F);
            lblNextStep.Location = new Point(142, 19);
            lblNextStep.Name = "lblNextStep";
            lblNextStep.Size = new Size(63, 15);
            lblNextStep.TabIndex = 9;
            lblNextStep.Text = "[NextStep]";
            lblNextStep.TextResourceKey = "BasicInfoNextStepLabel";
            // 
            // gbBasicInfo
            // 
            gbBasicInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbBasicInfo.Controls.Add(cbWaitingType);
            gbBasicInfo.Controls.Add(lblWaitingType);
            gbBasicInfo.Controls.Add(lblStepID);
            gbBasicInfo.Controls.Add(txtNextStepID);
            gbBasicInfo.Controls.Add(txtStepID);
            gbBasicInfo.Controls.Add(lblNextStep);
            gbBasicInfo.Controls.Add(lblStepName);
            gbBasicInfo.Controls.Add(txtStepName);
            gbBasicInfo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            gbBasicInfo.Location = new Point(0, 3);
            gbBasicInfo.Name = "gbBasicInfo";
            gbBasicInfo.Size = new Size(267, 193);
            gbBasicInfo.TabIndex = 11;
            gbBasicInfo.TabStop = false;
            gbBasicInfo.Text = "[BasicInfo]";
            gbBasicInfo.TextResourceKey = "BasicInfoGroupLabel";
            // 
            // cbWaitingType
            // 
            cbWaitingType.DisplayMember = "DisplayText";
            cbWaitingType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWaitingType.FlatStyle = FlatStyle.Flat;
            cbWaitingType.Font = new Font("Microsoft Sans Serif", 9F);
            cbWaitingType.FormattingEnabled = true;
            cbWaitingType.Location = new Point(7, 145);
            cbWaitingType.Name = "cbWaitingType";
            cbWaitingType.Size = new Size(254, 23);
            cbWaitingType.TabIndex = 22;
            cbWaitingType.ValueMember = "DataKey";
            // 
            // lblWaitingType
            // 
            lblWaitingType.AutoSize = true;
            lblWaitingType.Font = new Font("Microsoft Sans Serif", 9F);
            lblWaitingType.Location = new Point(7, 127);
            lblWaitingType.Name = "lblWaitingType";
            lblWaitingType.Size = new Size(80, 15);
            lblWaitingType.TabIndex = 11;
            lblWaitingType.Text = "[WaitingType]";
            lblWaitingType.TextResourceKey = "BasicInfoWaitingTypeLabel";
            // 
            // BasicStepInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbBasicInfo);
            Name = "BasicStepInfo";
            Size = new Size(279, 204);
            gbBasicInfo.ResumeLayout(false);
            gbBasicInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtStepID;
        private ExtendedLabel lblStepID;
        private CustomControls.RJControls.RJTextBox txtStepName;
        private ExtendedLabel lblStepName;
        private CustomControls.RJControls.RJTextBox txtNextStepID;
        private ExtendedLabel lblNextStep;
        private ExtendedGroupBox gbBasicInfo;
        private ExtendedLabel lblWaitingType;
        private ComboBox cbWaitingType;
    }
}
