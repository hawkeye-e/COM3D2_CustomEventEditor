namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class FadingStep
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
            gbFading = new ExtendedGroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblFadingType = new ExtendedLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbFadeOut = new ExtendedRadioButton();
            rbFadeIn = new ExtendedRadioButton();
            panel2 = new Panel();
            btnPickColor = new ExtendedButton();
            txtFadeColor = new CustomControls.RJControls.RJTextBox();
            lblFadeColor = new ExtendedLabel();
            panel1 = new Panel();
            txtFadeDuration = new CustomControls.RJControls.RJTextBox();
            lblFadeDuration = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            colorDialog1 = new ColorDialog();
            gbFading.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            lblHeader.TextResourceKey = "FadingStepHeader";
            // 
            // gbFading
            // 
            gbFading.AutoSize = true;
            gbFading.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbFading.Controls.Add(flowLayoutPanel4);
            gbFading.FlatStyle = FlatStyle.Flat;
            gbFading.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbFading.Location = new Point(3, 213);
            gbFading.MinimumSize = new Size(267, 0);
            gbFading.Name = "gbFading";
            gbFading.Size = new Size(269, 216);
            gbFading.TabIndex = 3;
            gbFading.TabStop = false;
            gbFading.Text = "[Fading]";
            gbFading.TextResourceKey = "FadingStepGroupLabel";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(lblFadingType);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.Controls.Add(panel2);
            flowLayoutPanel4.Controls.Add(panel1);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(6, 21);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(257, 174);
            flowLayoutPanel4.TabIndex = 48;
            // 
            // lblFadingType
            // 
            lblFadingType.AutoSize = true;
            lblFadingType.Font = new Font("Microsoft Sans Serif", 9F);
            lblFadingType.ForeColor = SystemColors.ControlText;
            lblFadingType.Location = new Point(3, 0);
            lblFadingType.Name = "lblFadingType";
            lblFadingType.Size = new Size(39, 15);
            lblFadingType.TabIndex = 40;
            lblFadingType.Text = "[Type]";
            lblFadingType.TextResourceKey = "FadingStepTypeLabel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(rbFadeOut);
            flowLayoutPanel1.Controls.Add(rbFadeIn);
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.MaximumSize = new Size(254, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(159, 25);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // rbFadeOut
            // 
            rbFadeOut.AutoSize = true;
            rbFadeOut.Checked = true;
            rbFadeOut.Font = new Font("Microsoft Sans Serif", 9F);
            rbFadeOut.Location = new Point(3, 3);
            rbFadeOut.Name = "rbFadeOut";
            rbFadeOut.Size = new Size(78, 19);
            rbFadeOut.TabIndex = 30;
            rbFadeOut.TabStop = true;
            rbFadeOut.Text = "[FadeOut]";
            rbFadeOut.TextResourceKey = "FadingStepFadeOutLabel";
            rbFadeOut.UseVisualStyleBackColor = true;
            rbFadeOut.CheckedChanged += rbFadeOut_CheckedChanged;
            // 
            // rbFadeIn
            // 
            rbFadeIn.AutoSize = true;
            rbFadeIn.Font = new Font("Microsoft Sans Serif", 9F);
            rbFadeIn.Location = new Point(87, 3);
            rbFadeIn.Name = "rbFadeIn";
            rbFadeIn.Size = new Size(69, 19);
            rbFadeIn.TabIndex = 31;
            rbFadeIn.Text = "[FadeIn]";
            rbFadeIn.TextResourceKey = "FadingStepFadeInLabel";
            rbFadeIn.UseVisualStyleBackColor = true;
            rbFadeIn.CheckedChanged += rbFadeIn_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnPickColor);
            panel2.Controls.Add(txtFadeColor);
            panel2.Controls.Add(lblFadeColor);
            panel2.Location = new Point(3, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 69);
            panel2.TabIndex = 45;
            // 
            // btnPickColor
            // 
            btnPickColor.FlatStyle = FlatStyle.Flat;
            btnPickColor.Font = new Font("Microsoft Sans Serif", 8F);
            btnPickColor.Location = new Point(172, 42);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(75, 23);
            btnPickColor.TabIndex = 48;
            btnPickColor.Text = "[PickColor]";
            btnPickColor.TextResourceKey = "PickColor";
            btnPickColor.UseVisualStyleBackColor = true;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // txtFadeColor
            // 
            txtFadeColor.AutoScroll = true;
            txtFadeColor.BackColor = SystemColors.Window;
            txtFadeColor.BorderColor = Color.FromArgb(66, 124, 244);
            txtFadeColor.BorderFocusColor = Color.HotPink;
            txtFadeColor.BorderSize = 2;
            txtFadeColor.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFadeColor.ForeColor = Color.Black;
            txtFadeColor.Location = new Point(146, 4);
            txtFadeColor.Margin = new Padding(4);
            txtFadeColor.Multiline = false;
            txtFadeColor.Name = "txtFadeColor";
            txtFadeColor.Padding = new Padding(7);
            txtFadeColor.PasswordChar = false;
            txtFadeColor.ReadOnly = false;
            txtFadeColor.Size = new Size(101, 31);
            txtFadeColor.TabIndex = 47;
            txtFadeColor.Texts = "";
            txtFadeColor.UnderlinedStyle = false;
            // 
            // lblFadeColor
            // 
            lblFadeColor.AutoSize = true;
            lblFadeColor.Font = new Font("Microsoft Sans Serif", 9F);
            lblFadeColor.ForeColor = SystemColors.ControlText;
            lblFadeColor.Location = new Point(3, 11);
            lblFadeColor.Name = "lblFadeColor";
            lblFadeColor.Size = new Size(70, 15);
            lblFadeColor.TabIndex = 42;
            lblFadeColor.Text = "[FadeColor]";
            lblFadeColor.TextResourceKey = "FadingStepFadeColorLabel";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFadeDuration);
            panel1.Controls.Add(lblFadeDuration);
            panel1.Location = new Point(3, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 47);
            panel1.TabIndex = 44;
            // 
            // txtFadeDuration
            // 
            txtFadeDuration.AutoScroll = true;
            txtFadeDuration.BackColor = SystemColors.Window;
            txtFadeDuration.BorderColor = Color.FromArgb(66, 124, 244);
            txtFadeDuration.BorderFocusColor = Color.HotPink;
            txtFadeDuration.BorderSize = 2;
            txtFadeDuration.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFadeDuration.ForeColor = Color.Black;
            txtFadeDuration.Location = new Point(184, 4);
            txtFadeDuration.Margin = new Padding(4);
            txtFadeDuration.Multiline = false;
            txtFadeDuration.Name = "txtFadeDuration";
            txtFadeDuration.Padding = new Padding(7);
            txtFadeDuration.PasswordChar = false;
            txtFadeDuration.ReadOnly = false;
            txtFadeDuration.Size = new Size(63, 31);
            txtFadeDuration.TabIndex = 46;
            txtFadeDuration.Texts = "";
            txtFadeDuration.UnderlinedStyle = false;
            // 
            // lblFadeDuration
            // 
            lblFadeDuration.AutoSize = true;
            lblFadeDuration.Font = new Font("Microsoft Sans Serif", 9F);
            lblFadeDuration.ForeColor = SystemColors.ControlText;
            lblFadeDuration.Location = new Point(1, 10);
            lblFadeDuration.Name = "lblFadeDuration";
            lblFadeDuration.Size = new Size(60, 15);
            lblFadeDuration.TabIndex = 44;
            lblFadeDuration.Text = "[Duration]";
            lblFadeDuration.TextResourceKey = "FadingStepDurationLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbFading);
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
            // FadingStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "FadingStep";
            Size = new Size(324, 1043);
            gbFading.ResumeLayout(false);
            gbFading.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbFading;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private FlowLayoutPanel flowLayoutPanel4;
        private ExtendedLabel lblFadingType;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedRadioButton rbFadeOut;
        private ExtendedRadioButton rbFadeIn;
        private ExtendedLabel lblFadeColor;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel1;
        private ExtendedLabel lblFadeDuration;
        private CustomControls.RJControls.RJTextBox txtFadeDuration;
        private CustomControls.RJControls.RJTextBox txtFadeColor;
        private ColorDialog colorDialog1;
        private ExtendedButton btnPickColor;
        private Panel panel2;
    }
}
