namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class CameraStep
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
            gbCamera = new ExtendedGroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblLockCamera = new ExtendedLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbLockCameraNoChange = new ExtendedRadioButton();
            rbLockCameraLocked = new ExtendedRadioButton();
            rbLockCameraUnlocked = new ExtendedRadioButton();
            lblBlur = new ExtendedLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rbBlurCameraNoChange = new ExtendedRadioButton();
            rbBlurCameraBlur = new ExtendedRadioButton();
            rbBlurCameraUnblur = new ExtendedRadioButton();
            panel1 = new Panel();
            lblCameraDataParser = new ExtendedLabel();
            txtCameraDataToParse = new CustomControls.RJControls.RJTextBox();
            btnParser = new ExtendedButton();
            txtCameraPanDuration = new CustomControls.RJControls.RJTextBox();
            lblDuration = new ExtendedLabel();
            chkCameraPan = new ExtendedCheckBox();
            txtDistance = new CustomControls.RJControls.RJTextBox();
            lblDistance = new ExtendedLabel();
            txtAroundAngles = new CustomControls.RJControls.RJTextBox();
            lblAroundAngle = new ExtendedLabel();
            txtTargetPosition = new CustomControls.RJControls.RJTextBox();
            lblTargetPosition = new ExtendedLabel();
            txtPosString = new CustomControls.RJControls.RJTextBox();
            lblPosString = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbCamera.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
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
            lblHeader.TextResourceKey = "CameraStepHeader";
            // 
            // gbCamera
            // 
            gbCamera.AutoSize = true;
            gbCamera.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbCamera.Controls.Add(flowLayoutPanel4);
            gbCamera.Controls.Add(txtCameraPanDuration);
            gbCamera.Controls.Add(lblDuration);
            gbCamera.Controls.Add(chkCameraPan);
            gbCamera.Controls.Add(txtDistance);
            gbCamera.Controls.Add(lblDistance);
            gbCamera.Controls.Add(txtAroundAngles);
            gbCamera.Controls.Add(lblAroundAngle);
            gbCamera.Controls.Add(txtTargetPosition);
            gbCamera.Controls.Add(lblTargetPosition);
            gbCamera.Controls.Add(txtPosString);
            gbCamera.Controls.Add(lblPosString);
            gbCamera.FlatStyle = FlatStyle.Flat;
            gbCamera.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbCamera.Location = new Point(3, 213);
            gbCamera.Name = "gbCamera";
            gbCamera.Size = new Size(269, 496);
            gbCamera.TabIndex = 3;
            gbCamera.TabStop = false;
            gbCamera.Text = "[Camera]";
            gbCamera.TextResourceKey = "CameraStepGroupLabel";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(lblLockCamera);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.Controls.Add(lblBlur);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel4.Controls.Add(panel1);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(6, 236);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(257, 239);
            flowLayoutPanel4.TabIndex = 47;
            // 
            // lblLockCamera
            // 
            lblLockCamera.AutoSize = true;
            lblLockCamera.Font = new Font("Microsoft Sans Serif", 9F);
            lblLockCamera.ForeColor = SystemColors.ControlText;
            lblLockCamera.Location = new Point(3, 0);
            lblLockCamera.Name = "lblLockCamera";
            lblLockCamera.Size = new Size(83, 15);
            lblLockCamera.TabIndex = 40;
            lblLockCamera.Text = "[LockCamera]";
            lblLockCamera.TextResourceKey = "CameraStepLockCameraLabel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(rbLockCameraNoChange);
            flowLayoutPanel1.Controls.Add(rbLockCameraLocked);
            flowLayoutPanel1.Controls.Add(rbLockCameraUnlocked);
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.MaximumSize = new Size(254, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(178, 50);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // rbLockCameraNoChange
            // 
            rbLockCameraNoChange.AutoSize = true;
            rbLockCameraNoChange.Checked = true;
            rbLockCameraNoChange.Font = new Font("Microsoft Sans Serif", 9F);
            rbLockCameraNoChange.Location = new Point(3, 3);
            rbLockCameraNoChange.Name = "rbLockCameraNoChange";
            rbLockCameraNoChange.Size = new Size(95, 19);
            rbLockCameraNoChange.TabIndex = 30;
            rbLockCameraNoChange.TabStop = true;
            rbLockCameraNoChange.Text = "[Unchanged]";
            rbLockCameraNoChange.TextResourceKey = "CameraStepLockCameraNoChangeLabel";
            rbLockCameraNoChange.UseVisualStyleBackColor = true;
            // 
            // rbLockCameraLocked
            // 
            rbLockCameraLocked.AutoSize = true;
            rbLockCameraLocked.Font = new Font("Microsoft Sans Serif", 9F);
            rbLockCameraLocked.Location = new Point(104, 3);
            rbLockCameraLocked.Name = "rbLockCameraLocked";
            rbLockCameraLocked.Size = new Size(71, 19);
            rbLockCameraLocked.TabIndex = 31;
            rbLockCameraLocked.Text = "[Locked]";
            rbLockCameraLocked.TextResourceKey = "CameraStepLockCameraLockedLabel";
            rbLockCameraLocked.UseVisualStyleBackColor = true;
            // 
            // rbLockCameraUnlocked
            // 
            rbLockCameraUnlocked.AutoSize = true;
            rbLockCameraUnlocked.Font = new Font("Microsoft Sans Serif", 9F);
            rbLockCameraUnlocked.Location = new Point(3, 28);
            rbLockCameraUnlocked.Name = "rbLockCameraUnlocked";
            rbLockCameraUnlocked.Size = new Size(83, 19);
            rbLockCameraUnlocked.TabIndex = 32;
            rbLockCameraUnlocked.Text = "[Unlocked]";
            rbLockCameraUnlocked.TextResourceKey = "CameraStepLockCameraUnlockedLabel";
            rbLockCameraUnlocked.UseVisualStyleBackColor = true;
            // 
            // lblBlur
            // 
            lblBlur.AutoSize = true;
            lblBlur.Font = new Font("Microsoft Sans Serif", 9F);
            lblBlur.ForeColor = SystemColors.ControlText;
            lblBlur.Location = new Point(3, 71);
            lblBlur.Name = "lblBlur";
            lblBlur.Size = new Size(79, 15);
            lblBlur.TabIndex = 42;
            lblBlur.Text = "[BlurCamera]";
            lblBlur.TextResourceKey = "CameraStepBlurCameraLabel";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(rbBlurCameraNoChange);
            flowLayoutPanel2.Controls.Add(rbBlurCameraBlur);
            flowLayoutPanel2.Controls.Add(rbBlurCameraUnblur);
            flowLayoutPanel2.Location = new Point(3, 89);
            flowLayoutPanel2.MaximumSize = new Size(254, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(234, 25);
            flowLayoutPanel2.TabIndex = 43;
            // 
            // rbBlurCameraNoChange
            // 
            rbBlurCameraNoChange.AutoSize = true;
            rbBlurCameraNoChange.Checked = true;
            rbBlurCameraNoChange.Font = new Font("Microsoft Sans Serif", 9F);
            rbBlurCameraNoChange.Location = new Point(3, 3);
            rbBlurCameraNoChange.Name = "rbBlurCameraNoChange";
            rbBlurCameraNoChange.Size = new Size(95, 19);
            rbBlurCameraNoChange.TabIndex = 30;
            rbBlurCameraNoChange.TabStop = true;
            rbBlurCameraNoChange.Text = "[Unchanged]";
            rbBlurCameraNoChange.TextResourceKey = "CameraStepBlurCameraNoChangeLabel";
            rbBlurCameraNoChange.UseVisualStyleBackColor = true;
            // 
            // rbBlurCameraBlur
            // 
            rbBlurCameraBlur.AutoSize = true;
            rbBlurCameraBlur.Font = new Font("Microsoft Sans Serif", 9F);
            rbBlurCameraBlur.Location = new Point(104, 3);
            rbBlurCameraBlur.Name = "rbBlurCameraBlur";
            rbBlurCameraBlur.Size = new Size(53, 19);
            rbBlurCameraBlur.TabIndex = 31;
            rbBlurCameraBlur.Text = "[Blur]";
            rbBlurCameraBlur.TextResourceKey = "CameraStepLockCameraBlurLabel";
            rbBlurCameraBlur.UseVisualStyleBackColor = true;
            // 
            // rbBlurCameraUnblur
            // 
            rbBlurCameraUnblur.AutoSize = true;
            rbBlurCameraUnblur.Font = new Font("Microsoft Sans Serif", 9F);
            rbBlurCameraUnblur.Location = new Point(163, 3);
            rbBlurCameraUnblur.Name = "rbBlurCameraUnblur";
            rbBlurCameraUnblur.Size = new Size(68, 19);
            rbBlurCameraUnblur.TabIndex = 32;
            rbBlurCameraUnblur.Text = "[Unblur]";
            rbBlurCameraUnblur.TextResourceKey = "CameraStepLockCameraUnblurLabel";
            rbBlurCameraUnblur.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCameraDataParser);
            panel1.Controls.Add(txtCameraDataToParse);
            panel1.Controls.Add(btnParser);
            panel1.Location = new Point(3, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 116);
            panel1.TabIndex = 44;
            // 
            // lblCameraDataParser
            // 
            lblCameraDataParser.AutoSize = true;
            lblCameraDataParser.Font = new Font("Microsoft Sans Serif", 9F);
            lblCameraDataParser.ForeColor = SystemColors.ControlText;
            lblCameraDataParser.Location = new Point(1, 6);
            lblCameraDataParser.Name = "lblCameraDataParser";
            lblCameraDataParser.Size = new Size(119, 15);
            lblCameraDataParser.TabIndex = 44;
            lblCameraDataParser.Text = "[CameraDataParser]";
            lblCameraDataParser.TextResourceKey = "CameraStepCameraDataParserLabel";
            // 
            // txtCameraDataToParse
            // 
            txtCameraDataToParse.BackColor = SystemColors.Window;
            txtCameraDataToParse.BorderColor = Color.FromArgb(66, 124, 244);
            txtCameraDataToParse.BorderFocusColor = Color.HotPink;
            txtCameraDataToParse.BorderSize = 2;
            txtCameraDataToParse.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCameraDataToParse.ForeColor = Color.Black;
            txtCameraDataToParse.Location = new Point(3, 33);
            txtCameraDataToParse.Margin = new Padding(16, 4, 4, 4);
            txtCameraDataToParse.Multiline = true;
            txtCameraDataToParse.Name = "txtCameraDataToParse";
            txtCameraDataToParse.Padding = new Padding(7);
            txtCameraDataToParse.PasswordChar = false;
            txtCameraDataToParse.ReadOnly = false;
            txtCameraDataToParse.Size = new Size(248, 72);
            txtCameraDataToParse.TabIndex = 45;
            txtCameraDataToParse.Texts = "";
            txtCameraDataToParse.UnderlinedStyle = false;
            // 
            // btnParser
            // 
            btnParser.FlatStyle = FlatStyle.Flat;
            btnParser.Font = new Font("Microsoft Sans Serif", 8F);
            btnParser.Location = new Point(176, 3);
            btnParser.Name = "btnParser";
            btnParser.Size = new Size(75, 23);
            btnParser.TabIndex = 46;
            btnParser.Text = "[Parse]";
            btnParser.TextResourceKey = "Parse";
            btnParser.UseVisualStyleBackColor = true;
            btnParser.Click += btnParser_Click;
            // 
            // txtCameraPanDuration
            // 
            txtCameraPanDuration.AutoScroll = true;
            txtCameraPanDuration.BackColor = SystemColors.Window;
            txtCameraPanDuration.BorderColor = Color.FromArgb(66, 124, 244);
            txtCameraPanDuration.BorderFocusColor = Color.HotPink;
            txtCameraPanDuration.BorderSize = 2;
            txtCameraPanDuration.Enabled = false;
            txtCameraPanDuration.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCameraPanDuration.ForeColor = Color.Black;
            txtCameraPanDuration.Location = new Point(197, 198);
            txtCameraPanDuration.Margin = new Padding(4);
            txtCameraPanDuration.Multiline = false;
            txtCameraPanDuration.Name = "txtCameraPanDuration";
            txtCameraPanDuration.Padding = new Padding(7);
            txtCameraPanDuration.PasswordChar = false;
            txtCameraPanDuration.ReadOnly = false;
            txtCameraPanDuration.Size = new Size(63, 31);
            txtCameraPanDuration.TabIndex = 39;
            txtCameraPanDuration.Texts = "";
            txtCameraPanDuration.UnderlinedStyle = false;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Font = new Font("Microsoft Sans Serif", 9F);
            lblDuration.ForeColor = SystemColors.ControlText;
            lblDuration.Location = new Point(6, 205);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(60, 15);
            lblDuration.TabIndex = 38;
            lblDuration.Text = "[Duration]";
            lblDuration.TextResourceKey = "CameraStepPanningDurationLabel";
            // 
            // chkCameraPan
            // 
            chkCameraPan.AutoSize = true;
            chkCameraPan.Font = new Font("Microsoft Sans Serif", 9F);
            chkCameraPan.Location = new Point(6, 177);
            chkCameraPan.Name = "chkCameraPan";
            chkCameraPan.Size = new Size(98, 19);
            chkCameraPan.TabIndex = 37;
            chkCameraPan.Text = "[CameraPan]";
            chkCameraPan.TextResourceKey = "CameraStepCameraPanLabel";
            chkCameraPan.UseVisualStyleBackColor = true;
            chkCameraPan.CheckedChanged += chkCameraPan_CheckedChanged;
            // 
            // txtDistance
            // 
            txtDistance.AutoScroll = true;
            txtDistance.BackColor = SystemColors.Window;
            txtDistance.BorderColor = Color.FromArgb(66, 124, 244);
            txtDistance.BorderFocusColor = Color.HotPink;
            txtDistance.BorderSize = 2;
            txtDistance.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDistance.ForeColor = Color.Black;
            txtDistance.Location = new Point(197, 139);
            txtDistance.Margin = new Padding(4);
            txtDistance.Multiline = false;
            txtDistance.Name = "txtDistance";
            txtDistance.Padding = new Padding(7);
            txtDistance.PasswordChar = false;
            txtDistance.ReadOnly = false;
            txtDistance.Size = new Size(63, 31);
            txtDistance.TabIndex = 36;
            txtDistance.Texts = "";
            txtDistance.UnderlinedStyle = false;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Microsoft Sans Serif", 9F);
            lblDistance.ForeColor = SystemColors.ControlText;
            lblDistance.Location = new Point(6, 146);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(61, 15);
            lblDistance.TabIndex = 35;
            lblDistance.Text = "[Distance]";
            lblDistance.TextResourceKey = "CameraStepDistanceLabel";
            // 
            // txtAroundAngles
            // 
            txtAroundAngles.AutoScroll = true;
            txtAroundAngles.BackColor = SystemColors.Window;
            txtAroundAngles.BorderColor = Color.FromArgb(66, 124, 244);
            txtAroundAngles.BorderFocusColor = Color.HotPink;
            txtAroundAngles.BorderSize = 2;
            txtAroundAngles.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAroundAngles.ForeColor = Color.Black;
            txtAroundAngles.Location = new Point(116, 100);
            txtAroundAngles.Margin = new Padding(4);
            txtAroundAngles.Multiline = false;
            txtAroundAngles.Name = "txtAroundAngles";
            txtAroundAngles.Padding = new Padding(7);
            txtAroundAngles.PasswordChar = false;
            txtAroundAngles.ReadOnly = false;
            txtAroundAngles.Size = new Size(144, 31);
            txtAroundAngles.TabIndex = 34;
            txtAroundAngles.Texts = "";
            txtAroundAngles.UnderlinedStyle = false;
            // 
            // lblAroundAngle
            // 
            lblAroundAngle.AutoSize = true;
            lblAroundAngle.Font = new Font("Microsoft Sans Serif", 9F);
            lblAroundAngle.ForeColor = SystemColors.ControlText;
            lblAroundAngle.Location = new Point(6, 107);
            lblAroundAngle.Name = "lblAroundAngle";
            lblAroundAngle.Size = new Size(44, 15);
            lblAroundAngle.TabIndex = 33;
            lblAroundAngle.Text = "[Angle]";
            lblAroundAngle.TextResourceKey = "CameraStepAroundAngleLabel";
            // 
            // txtTargetPosition
            // 
            txtTargetPosition.AutoScroll = true;
            txtTargetPosition.BackColor = SystemColors.Window;
            txtTargetPosition.BorderColor = Color.FromArgb(66, 124, 244);
            txtTargetPosition.BorderFocusColor = Color.HotPink;
            txtTargetPosition.BorderSize = 2;
            txtTargetPosition.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTargetPosition.ForeColor = Color.Black;
            txtTargetPosition.Location = new Point(116, 61);
            txtTargetPosition.Margin = new Padding(4);
            txtTargetPosition.Multiline = false;
            txtTargetPosition.Name = "txtTargetPosition";
            txtTargetPosition.Padding = new Padding(7);
            txtTargetPosition.PasswordChar = false;
            txtTargetPosition.ReadOnly = false;
            txtTargetPosition.Size = new Size(144, 31);
            txtTargetPosition.TabIndex = 32;
            txtTargetPosition.Texts = "";
            txtTargetPosition.UnderlinedStyle = false;
            // 
            // lblTargetPosition
            // 
            lblTargetPosition.AutoSize = true;
            lblTargetPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblTargetPosition.ForeColor = SystemColors.ControlText;
            lblTargetPosition.Location = new Point(6, 68);
            lblTargetPosition.Name = "lblTargetPosition";
            lblTargetPosition.Size = new Size(92, 15);
            lblTargetPosition.TabIndex = 31;
            lblTargetPosition.Text = "[TargetPosition]";
            lblTargetPosition.TextResourceKey = "CameraStepTargetPositionLabel";
            // 
            // txtPosString
            // 
            txtPosString.AutoScroll = true;
            txtPosString.BackColor = SystemColors.Window;
            txtPosString.BorderColor = Color.FromArgb(66, 124, 244);
            txtPosString.BorderFocusColor = Color.HotPink;
            txtPosString.BorderSize = 2;
            txtPosString.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPosString.ForeColor = Color.Black;
            txtPosString.Location = new Point(116, 22);
            txtPosString.Margin = new Padding(4);
            txtPosString.Multiline = false;
            txtPosString.Name = "txtPosString";
            txtPosString.Padding = new Padding(7);
            txtPosString.PasswordChar = false;
            txtPosString.ReadOnly = false;
            txtPosString.Size = new Size(144, 31);
            txtPosString.TabIndex = 30;
            txtPosString.Texts = "";
            txtPosString.UnderlinedStyle = false;
            // 
            // lblPosString
            // 
            lblPosString.AutoSize = true;
            lblPosString.Font = new Font("Microsoft Sans Serif", 9F);
            lblPosString.ForeColor = SystemColors.ControlText;
            lblPosString.Location = new Point(6, 29);
            lblPosString.Name = "lblPosString";
            lblPosString.Size = new Size(57, 15);
            lblPosString.TabIndex = 23;
            lblPosString.Text = "[Position]";
            lblPosString.TextResourceKey = "CameraStepPosStringLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbCamera);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 712);
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
            // CameraStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "CameraStep";
            Size = new Size(324, 1043);
            gbCamera.ResumeLayout(false);
            gbCamera.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
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
        private ExtendedGroupBox gbCamera;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private CustomControls.RJControls.RJTextBox txtPosString;
        private ExtendedLabel lblPosString;
        private ExtendedLabel lblTargetPosition;
        private CustomControls.RJControls.RJTextBox txtTargetPosition;
        private CustomControls.RJControls.RJTextBox txtAroundAngles;
        private ExtendedLabel lblAroundAngle;
        private CustomControls.RJControls.RJTextBox txtDistance;
        private ExtendedLabel lblDistance;
        private ExtendedCheckBox chkCameraPan;
        private CustomControls.RJControls.RJTextBox txtCameraPanDuration;
        private ExtendedLabel lblDuration;
        private ExtendedLabel lblLockCamera;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedRadioButton rbLockCameraNoChange;
        private ExtendedRadioButton rbLockCameraLocked;
        private ExtendedRadioButton rbLockCameraUnlocked;
        private ExtendedLabel lblBlur;
        private FlowLayoutPanel flowLayoutPanel2;
        private ExtendedRadioButton rbBlurCameraNoChange;
        private ExtendedRadioButton rbBlurCameraBlur;
        private ExtendedRadioButton rbBlurCameraUnblur;
        private ExtendedLabel lblCameraDataParser;
        private CustomControls.RJControls.RJTextBox txtCameraDataToParse;
        private ExtendedButton btnParser;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panel1;
    }
}
