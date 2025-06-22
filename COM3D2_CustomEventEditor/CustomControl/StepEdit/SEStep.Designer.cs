namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class SEStep
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
            gbSE = new ExtendedGroupBox();
            txtFileName = new CustomControls.RJControls.RJTextBox();
            lblSEFileName = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            chkStopSE = new ExtendedCheckBox();
            chkLoop = new ExtendedCheckBox();
            gbSE.SuspendLayout();
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
            lblHeader.TextResourceKey = "SEStepHeader";
            // 
            // gbSE
            // 
            gbSE.AutoSize = true;
            gbSE.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbSE.Controls.Add(chkLoop);
            gbSE.Controls.Add(chkStopSE);
            gbSE.Controls.Add(txtFileName);
            gbSE.Controls.Add(lblSEFileName);
            gbSE.FlatStyle = FlatStyle.Flat;
            gbSE.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbSE.Location = new Point(3, 213);
            gbSE.Name = "gbSE";
            gbSE.Size = new Size(267, 151);
            gbSE.TabIndex = 3;
            gbSE.TabStop = false;
            gbSE.Text = "[SE]";
            gbSE.TextResourceKey = "SEStepGroupLabel";
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
            txtFileName.Location = new Point(6, 77);
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
            // lblSEFileName
            // 
            lblSEFileName.AutoSize = true;
            lblSEFileName.Font = new Font("Microsoft Sans Serif", 9F);
            lblSEFileName.ForeColor = SystemColors.ControlText;
            lblSEFileName.Location = new Point(6, 58);
            lblSEFileName.Name = "lblSEFileName";
            lblSEFileName.Size = new Size(83, 15);
            lblSEFileName.TabIndex = 23;
            lblSEFileName.Text = "[SEFileName]";
            lblSEFileName.TextResourceKey = "SEStepFileNameLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbSE);
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
            // chkStopSE
            // 
            chkStopSE.AutoSize = true;
            chkStopSE.Font = new Font("Microsoft Sans Serif", 9F);
            chkStopSE.Location = new Point(6, 21);
            chkStopSE.Name = "chkStopSE";
            chkStopSE.Size = new Size(73, 19);
            chkStopSE.TabIndex = 31;
            chkStopSE.Text = "[StopSE]";
            chkStopSE.TextResourceKey = "SEStepStopSELabel";
            chkStopSE.UseVisualStyleBackColor = true;
            // 
            // chkLoop
            // 
            chkLoop.AutoSize = true;
            chkLoop.Font = new Font("Microsoft Sans Serif", 9F);
            chkLoop.Location = new Point(6, 111);
            chkLoop.Name = "chkLoop";
            chkLoop.Size = new Size(60, 19);
            chkLoop.TabIndex = 32;
            chkLoop.Text = "[Loop]";
            chkLoop.TextResourceKey = "SEStepLoopSELabel";
            chkLoop.UseVisualStyleBackColor = true;
            // 
            // SEStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "SEStep";
            Size = new Size(324, 1043);
            gbSE.ResumeLayout(false);
            gbSE.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbSE;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private CustomControls.RJControls.RJTextBox txtFileName;
        private ExtendedLabel lblSEFileName;
        private ExtendedCheckBox chkStopSE;
        private ExtendedCheckBox chkLoop;
    }
}
