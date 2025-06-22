namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class TimeSleepStep
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
            gbTimeSleep = new ExtendedGroupBox();
            txtSleepValue = new CustomControls.RJControls.RJTextBox();
            lblSleepValue = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbTimeSleep.SuspendLayout();
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
            lblHeader.TextResourceKey = "TimeSleepStepHeader";
            // 
            // gbTimeSleep
            // 
            gbTimeSleep.AutoSize = true;
            gbTimeSleep.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbTimeSleep.Controls.Add(txtSleepValue);
            gbTimeSleep.Controls.Add(lblSleepValue);
            gbTimeSleep.FlatStyle = FlatStyle.Flat;
            gbTimeSleep.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbTimeSleep.Location = new Point(3, 213);
            gbTimeSleep.MinimumSize = new Size(267, 0);
            gbTimeSleep.Name = "gbTimeSleep";
            gbTimeSleep.Size = new Size(267, 112);
            gbTimeSleep.TabIndex = 3;
            gbTimeSleep.TabStop = false;
            gbTimeSleep.Text = "[TimeSleep]";
            gbTimeSleep.TextResourceKey = "TimeSleepStepGroupLabel";
            // 
            // txtSleepValue
            // 
            txtSleepValue.AutoScroll = true;
            txtSleepValue.BackColor = SystemColors.Window;
            txtSleepValue.BorderColor = Color.FromArgb(66, 124, 244);
            txtSleepValue.BorderFocusColor = Color.HotPink;
            txtSleepValue.BorderSize = 2;
            txtSleepValue.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSleepValue.ForeColor = Color.Black;
            txtSleepValue.Location = new Point(6, 59);
            txtSleepValue.Margin = new Padding(4);
            txtSleepValue.Multiline = false;
            txtSleepValue.Name = "txtSleepValue";
            txtSleepValue.Padding = new Padding(7);
            txtSleepValue.PasswordChar = false;
            txtSleepValue.ReadOnly = false;
            txtSleepValue.Size = new Size(55, 31);
            txtSleepValue.TabIndex = 30;
            txtSleepValue.Texts = "";
            txtSleepValue.UnderlinedStyle = false;
            // 
            // lblSleepValue
            // 
            lblSleepValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblSleepValue.ForeColor = SystemColors.ControlText;
            lblSleepValue.Location = new Point(6, 22);
            lblSleepValue.Name = "lblSleepValue";
            lblSleepValue.Size = new Size(255, 33);
            lblSleepValue.TabIndex = 23;
            lblSleepValue.Text = "[HowManySeconds]";
            lblSleepValue.TextResourceKey = "TimeSleepStepSleepValueLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbTimeSleep);
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
            // TimeSleepStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "TimeSleepStep";
            Size = new Size(324, 1043);
            gbTimeSleep.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbTimeSleep;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private CustomControls.RJControls.RJTextBox txtSleepValue;
        private ExtendedLabel lblSleepValue;
    }
}
