namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class BackgroundStep
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
            txtPrefabNameDay = new CustomControls.RJControls.RJTextBox();
            lblPrefabName = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            lblPrefabNameNight = new ExtendedLabel();
            txtPrefabNameNight = new CustomControls.RJControls.RJTextBox();
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
            lblHeader.TextResourceKey = "BackgroundStepHeader";
            // 
            // gbBackground
            // 
            gbBackground.AutoSize = true;
            gbBackground.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbBackground.Controls.Add(txtPrefabNameNight);
            gbBackground.Controls.Add(lblPrefabNameNight);
            gbBackground.Controls.Add(txtPrefabNameDay);
            gbBackground.Controls.Add(lblPrefabName);
            gbBackground.FlatStyle = FlatStyle.Flat;
            gbBackground.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbBackground.Location = new Point(3, 213);
            gbBackground.Name = "gbBackground";
            gbBackground.Size = new Size(267, 144);
            gbBackground.TabIndex = 3;
            gbBackground.TabStop = false;
            gbBackground.Text = "[Background]";
            gbBackground.TextResourceKey = "BackgroundStepGroupLabel";
            // 
            // txtPrefabNameDay
            // 
            txtPrefabNameDay.AutoScroll = true;
            txtPrefabNameDay.BackColor = SystemColors.Window;
            txtPrefabNameDay.BorderColor = Color.FromArgb(66, 124, 244);
            txtPrefabNameDay.BorderFocusColor = Color.HotPink;
            txtPrefabNameDay.BorderSize = 2;
            txtPrefabNameDay.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrefabNameDay.ForeColor = Color.Black;
            txtPrefabNameDay.Location = new Point(6, 37);
            txtPrefabNameDay.Margin = new Padding(4);
            txtPrefabNameDay.Multiline = false;
            txtPrefabNameDay.Name = "txtPrefabNameDay";
            txtPrefabNameDay.Padding = new Padding(7);
            txtPrefabNameDay.PasswordChar = false;
            txtPrefabNameDay.ReadOnly = false;
            txtPrefabNameDay.Size = new Size(254, 31);
            txtPrefabNameDay.TabIndex = 30;
            txtPrefabNameDay.Texts = "";
            txtPrefabNameDay.UnderlinedStyle = false;
            // 
            // lblPrefabName
            // 
            lblPrefabName.AutoSize = true;
            lblPrefabName.Font = new Font("Microsoft Sans Serif", 9F);
            lblPrefabName.ForeColor = SystemColors.ControlText;
            lblPrefabName.Location = new Point(6, 18);
            lblPrefabName.Name = "lblPrefabName";
            lblPrefabName.Size = new Size(104, 15);
            lblPrefabName.TabIndex = 23;
            lblPrefabName.Text = "[PrefabNameDay]";
            lblPrefabName.TextResourceKey = "BackgroundStepPrefabNameDayLabel";
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
            // lblPrefabNameNight
            // 
            lblPrefabNameNight.AutoSize = true;
            lblPrefabNameNight.Font = new Font("Microsoft Sans Serif", 9F);
            lblPrefabNameNight.ForeColor = SystemColors.ControlText;
            lblPrefabNameNight.Location = new Point(6, 72);
            lblPrefabNameNight.Name = "lblPrefabNameNight";
            lblPrefabNameNight.Size = new Size(112, 15);
            lblPrefabNameNight.TabIndex = 31;
            lblPrefabNameNight.Text = "[PrefabNameNight]";
            lblPrefabNameNight.TextResourceKey = "BackgroundStepPrefabNameNightLabel";
            // 
            // txtPrefabNameNight
            // 
            txtPrefabNameNight.AutoScroll = true;
            txtPrefabNameNight.BackColor = SystemColors.Window;
            txtPrefabNameNight.BorderColor = Color.FromArgb(66, 124, 244);
            txtPrefabNameNight.BorderFocusColor = Color.HotPink;
            txtPrefabNameNight.BorderSize = 2;
            txtPrefabNameNight.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrefabNameNight.ForeColor = Color.Black;
            txtPrefabNameNight.Location = new Point(6, 91);
            txtPrefabNameNight.Margin = new Padding(4);
            txtPrefabNameNight.Multiline = false;
            txtPrefabNameNight.Name = "txtPrefabNameNight";
            txtPrefabNameNight.Padding = new Padding(7);
            txtPrefabNameNight.PasswordChar = false;
            txtPrefabNameNight.ReadOnly = false;
            txtPrefabNameNight.Size = new Size(254, 31);
            txtPrefabNameNight.TabIndex = 32;
            txtPrefabNameNight.Texts = "";
            txtPrefabNameNight.UnderlinedStyle = false;
            // 
            // BackgroundStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "BackgroundStep";
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
        private CustomControls.RJControls.RJTextBox txtPrefabNameDay;
        private ExtendedLabel lblPrefabName;
        private ExtendedLabel lblPrefabNameNight;
        private CustomControls.RJControls.RJTextBox txtPrefabNameNight;
    }
}
