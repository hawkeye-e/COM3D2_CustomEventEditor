namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class BGMStep
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
            gbBackground = new ExtendedGroupBox();
            txtFileName = new CustomControls.RJControls.RJTextBox();
            lblBGMFileName = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbBackground.SuspendLayout();
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
            lblHeader.TextResourceKey = "BGMStepHeader";
            // 
            // gbBackground
            // 
            gbBackground.AutoSize = true;
            gbBackground.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbBackground.Controls.Add(txtFileName);
            gbBackground.Controls.Add(lblBGMFileName);
            gbBackground.FlatStyle = FlatStyle.Flat;
            gbBackground.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbBackground.Location = new Point(3, 213);
            gbBackground.Name = "gbBackground";
            gbBackground.Size = new Size(267, 90);
            gbBackground.TabIndex = 3;
            gbBackground.TabStop = false;
            gbBackground.Text = "[Background]";
            gbBackground.TextResourceKey = "BGMStepGroupLabel";
            // 
            // txtFileName
            // 
            txtFileName.AutoScroll = true;
            txtFileName.BackColor = SystemColors.Window;
            txtFileName.BorderColor = Color.FromArgb(66, 124, 244);
            txtFileName.BorderFocusColor = Color.HotPink;
            txtFileName.BorderSize = 2;
            txtFileName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileName.ForeColor = Color.Black;
            txtFileName.Location = new Point(6, 37);
            txtFileName.Margin = new Padding(4);
            txtFileName.Multiline = false;
            txtFileName.Name = "txtFileName";
            txtFileName.Padding = new Padding(7);
            txtFileName.PasswordChar = false;
            txtFileName.ReadOnly = false;
            txtFileName.Size = new Size(254, 31);
            txtFileName.TabIndex = 30;
            txtFileName.Texts = "";
            txtFileName.UnderlinedStyle = false;
            // 
            // lblBGMFileName
            // 
            lblBGMFileName.AutoSize = true;
            lblBGMFileName.Font = new Font("Microsoft Sans Serif", 9F);
            lblBGMFileName.ForeColor = SystemColors.ControlText;
            lblBGMFileName.Location = new Point(6, 18);
            lblBGMFileName.Name = "lblBGMFileName";
            lblBGMFileName.Size = new Size(95, 15);
            lblBGMFileName.TabIndex = 23;
            lblBGMFileName.Text = "[BGMFileName]";
            lblBGMFileName.TextResourceKey = "BGMStepFileNameLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbBackground);
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
            // BGMStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "BGMStep";
            Size = new Size(324, 1043);
            gbBackground.ResumeLayout(false);
            gbBackground.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbBackground;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private CustomControls.RJControls.RJTextBox txtFileName;
        private ExtendedLabel lblBGMFileName;
    }
}
