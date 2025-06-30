namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class CharaStep
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
            gbStatus = new ExtendedGroupBox();
            flowLayoutPanel12 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            chkVisible = new ExtendedCheckBox();
            chkManNude = new ExtendedCheckBox();
            chkOpenMouth = new ExtendedCheckBox();
            pnlFemaleFaceStatus = new Panel();
            lblTearLevelValue = new ExtendedLabel();
            lblBlushingLevelValue = new ExtendedLabel();
            tbTearLevel = new TrackBar();
            lblTearLevel = new ExtendedLabel();
            chkFaceBlend = new ExtendedCheckBox();
            tbBlushing = new TrackBar();
            lblBlushingLevel = new ExtendedLabel();
            txtFaceAnim = new CustomControls.RJControls.RJTextBox();
            lblFaceAnim = new ExtendedLabel();
            gbCoordinates = new ExtendedGroupBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            pnlCoordinates = new Panel();
            lblSmoothMovementDuration = new ExtendedLabel();
            txtSmoothMovementDuration = new CustomControls.RJControls.RJTextBox();
            chkSmoothMovement = new ExtendedCheckBox();
            txtCoordinatesRot = new CustomControls.RJControls.RJTextBox();
            lblCoordinatesRot = new ExtendedLabel();
            txtCoordinatesPos = new CustomControls.RJControls.RJTextBox();
            lblCoordinatesPos = new ExtendedLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            chkCoordinateChange = new ExtendedCheckBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbTarget = new ExtendedGroupBox();
            cbTargetType = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlPosition = new Panel();
            chkUseBranchIndex = new ExtendedCheckBox();
            lblPosition = new ExtendedLabel();
            cbListIndex = new ComboBox();
            lblTarget = new ExtendedLabel();
            gbMotion = new ExtendedGroupBox();
            chkMotionUpdate = new ExtendedCheckBox();
            pnlMotionUpdate = new FlowLayoutPanel();
            lblMotionType = new ExtendedLabel();
            flowLayoutPanel7 = new FlowLayoutPanel();
            rbMotionScript = new ExtendedRadioButton();
            rbAnimationFile = new ExtendedRadioButton();
            rbCustomAnimation = new ExtendedRadioButton();
            pnlMotionScript = new Panel();
            txtScriptLabel = new CustomControls.RJControls.RJTextBox();
            lblMotionScriptLabel = new ExtendedLabel();
            txtScriptFile = new CustomControls.RJControls.RJTextBox();
            lblScriptFile = new ExtendedLabel();
            pnlMotionAnimation = new Panel();
            txtAnimationFile = new CustomControls.RJControls.RJTextBox();
            lblAnimationFile = new ExtendedLabel();
            pnlCustomAnimination = new Panel();
            txtMotionCustomAnimation = new CustomControls.RJControls.RJTextBox();
            lblCustomAnimation = new ExtendedLabel();
            chkLoopMotion = new ExtendedCheckBox();
            chkSmoothMotionTransition = new ExtendedCheckBox();
            gbEyeSight = new ExtendedGroupBox();
            chkEyeSightUpdate = new ExtendedCheckBox();
            pnlEyeSightUpdate = new FlowLayoutPanel();
            lblEyeSightType = new ExtendedLabel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            rbEyeSightCamera = new ExtendedRadioButton();
            rbEyeSightCharacter = new ExtendedRadioButton();
            pnlEyeSightCamera = new Panel();
            cbEyeSightCameraType = new ComboBox();
            lblEyeSightCameraType = new ExtendedLabel();
            pnlEyeSightCharacter = new Panel();
            flowLayoutPanel11 = new FlowLayoutPanel();
            pnlEyeSightCharaPosition = new Panel();
            lblEyeSightCharacterIndexPosition = new ExtendedLabel();
            cbEyeSightCharaPosition = new ComboBox();
            pnlEyeSightGroupMember = new Panel();
            lblGroupTarget = new ExtendedLabel();
            cbGroupTarget = new ComboBox();
            lblGroupPosition = new ExtendedLabel();
            cbGroupIndex = new ComboBox();
            flowLayoutPanel10 = new FlowLayoutPanel();
            cbEyeSightCharacterType = new ComboBox();
            lblEyeSightCharacterType = new ExtendedLabel();
            gbStatus.SuspendLayout();
            flowLayoutPanel12.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            pnlFemaleFaceStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTearLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlushing).BeginInit();
            gbCoordinates.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            pnlCoordinates.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            gbTarget.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlPosition.SuspendLayout();
            gbMotion.SuspendLayout();
            pnlMotionUpdate.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            pnlMotionScript.SuspendLayout();
            pnlMotionAnimation.SuspendLayout();
            pnlCustomAnimination.SuspendLayout();
            gbEyeSight.SuspendLayout();
            pnlEyeSightUpdate.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            pnlEyeSightCamera.SuspendLayout();
            pnlEyeSightCharacter.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            pnlEyeSightCharaPosition.SuspendLayout();
            pnlEyeSightGroupMember.SuspendLayout();
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
            lblHeader.TextResourceKey = "CharaStepHeader";
            // 
            // gbStatus
            // 
            gbStatus.AutoSize = true;
            gbStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbStatus.Controls.Add(flowLayoutPanel12);
            gbStatus.FlatStyle = FlatStyle.Flat;
            gbStatus.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbStatus.Location = new Point(3, 375);
            gbStatus.MinimumSize = new Size(267, 0);
            gbStatus.Name = "gbStatus";
            gbStatus.Padding = new Padding(3, 3, 3, 0);
            gbStatus.Size = new Size(267, 238);
            gbStatus.TabIndex = 3;
            gbStatus.TabStop = false;
            gbStatus.Text = "[Status]";
            gbStatus.TextResourceKey = "CharaStepStatusGroupLabel";
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.AutoSize = true;
            flowLayoutPanel12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel12.Controls.Add(flowLayoutPanel4);
            flowLayoutPanel12.Controls.Add(pnlFemaleFaceStatus);
            flowLayoutPanel12.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel12.Location = new Point(3, 21);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Size = new Size(255, 199);
            flowLayoutPanel12.TabIndex = 29;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(chkVisible);
            flowLayoutPanel4.Controls.Add(chkManNude);
            flowLayoutPanel4.Controls.Add(chkOpenMouth);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(249, 60);
            flowLayoutPanel4.TabIndex = 28;
            // 
            // chkVisible
            // 
            chkVisible.AutoSize = true;
            chkVisible.Checked = true;
            chkVisible.CheckState = CheckState.Checked;
            chkVisible.Font = new Font("Microsoft Sans Serif", 9F);
            chkVisible.Location = new Point(3, 3);
            chkVisible.Name = "chkVisible";
            chkVisible.Size = new Size(68, 19);
            chkVisible.TabIndex = 25;
            chkVisible.Text = "[Visible]";
            chkVisible.TextResourceKey = "CharaStepVisibleLabel";
            chkVisible.UseVisualStyleBackColor = true;
            // 
            // chkManNude
            // 
            chkManNude.AutoSize = true;
            chkManNude.Font = new Font("Microsoft Sans Serif", 9F);
            chkManNude.Location = new Point(3, 28);
            chkManNude.Name = "chkManNude";
            chkManNude.Size = new Size(62, 19);
            chkManNude.TabIndex = 26;
            chkManNude.Text = "[Nude]";
            chkManNude.TextResourceKey = "CharaStepManNudeLabel";
            chkManNude.UseVisualStyleBackColor = true;
            // 
            // chkOpenMouth
            // 
            chkOpenMouth.AutoSize = true;
            chkOpenMouth.Font = new Font("Microsoft Sans Serif", 9F);
            chkOpenMouth.Location = new Point(77, 3);
            chkOpenMouth.Name = "chkOpenMouth";
            chkOpenMouth.Size = new Size(97, 19);
            chkOpenMouth.TabIndex = 27;
            chkOpenMouth.Text = "[OpenMouth]";
            chkOpenMouth.TextResourceKey = "CharaStepOpenMouthLabel";
            chkOpenMouth.UseVisualStyleBackColor = true;
            // 
            // pnlFemaleFaceStatus
            // 
            pnlFemaleFaceStatus.Controls.Add(lblTearLevelValue);
            pnlFemaleFaceStatus.Controls.Add(lblBlushingLevelValue);
            pnlFemaleFaceStatus.Controls.Add(tbTearLevel);
            pnlFemaleFaceStatus.Controls.Add(lblTearLevel);
            pnlFemaleFaceStatus.Controls.Add(chkFaceBlend);
            pnlFemaleFaceStatus.Controls.Add(tbBlushing);
            pnlFemaleFaceStatus.Controls.Add(lblBlushingLevel);
            pnlFemaleFaceStatus.Controls.Add(txtFaceAnim);
            pnlFemaleFaceStatus.Controls.Add(lblFaceAnim);
            pnlFemaleFaceStatus.Location = new Point(3, 69);
            pnlFemaleFaceStatus.Name = "pnlFemaleFaceStatus";
            pnlFemaleFaceStatus.Size = new Size(249, 127);
            pnlFemaleFaceStatus.TabIndex = 29;
            // 
            // lblTearLevelValue
            // 
            lblTearLevelValue.AutoSize = true;
            lblTearLevelValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblTearLevelValue.Location = new Point(202, 79);
            lblTearLevelValue.Name = "lblTearLevelValue";
            lblTearLevelValue.Size = new Size(14, 15);
            lblTearLevelValue.TabIndex = 32;
            lblTearLevelValue.Text = "0";
            lblTearLevelValue.TextResourceKey = "";
            // 
            // lblBlushingLevelValue
            // 
            lblBlushingLevelValue.AutoSize = true;
            lblBlushingLevelValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblBlushingLevelValue.Location = new Point(81, 79);
            lblBlushingLevelValue.Name = "lblBlushingLevelValue";
            lblBlushingLevelValue.Size = new Size(14, 15);
            lblBlushingLevelValue.TabIndex = 31;
            lblBlushingLevelValue.Text = "0";
            lblBlushingLevelValue.TextResourceKey = "";
            // 
            // tbTearLevel
            // 
            tbTearLevel.Enabled = false;
            tbTearLevel.LargeChange = 1;
            tbTearLevel.Location = new Point(125, 79);
            tbTearLevel.Maximum = 3;
            tbTearLevel.Name = "tbTearLevel";
            tbTearLevel.Size = new Size(82, 45);
            tbTearLevel.TabIndex = 30;
            tbTearLevel.ValueChanged += tbTearLevel_ValueChanged;
            // 
            // lblTearLevel
            // 
            lblTearLevel.AutoSize = true;
            lblTearLevel.Font = new Font("Microsoft Sans Serif", 9F);
            lblTearLevel.Location = new Point(125, 61);
            lblTearLevel.Name = "lblTearLevel";
            lblTearLevel.Size = new Size(67, 15);
            lblTearLevel.TabIndex = 29;
            lblTearLevel.Text = "[TearLevel]";
            lblTearLevel.TextResourceKey = "CharaStepTearLevelLabel";
            // 
            // chkFaceBlend
            // 
            chkFaceBlend.AutoSize = true;
            chkFaceBlend.Font = new Font("Microsoft Sans Serif", 9F);
            chkFaceBlend.Location = new Point(3, 42);
            chkFaceBlend.Name = "chkFaceBlend";
            chkFaceBlend.Size = new Size(195, 19);
            chkFaceBlend.TabIndex = 28;
            chkFaceBlend.Text = "[BlushingAndTearLevelUpdate]";
            chkFaceBlend.TextResourceKey = "CharaStepBlushingAndTearChangeLabel";
            chkFaceBlend.UseVisualStyleBackColor = true;
            chkFaceBlend.CheckedChanged += chkFaceBlend_CheckedChanged;
            // 
            // tbBlushing
            // 
            tbBlushing.Enabled = false;
            tbBlushing.LargeChange = 1;
            tbBlushing.Location = new Point(3, 79);
            tbBlushing.Maximum = 3;
            tbBlushing.Name = "tbBlushing";
            tbBlushing.Size = new Size(82, 45);
            tbBlushing.TabIndex = 27;
            tbBlushing.ValueChanged += tbBlushing_ValueChanged;
            // 
            // lblBlushingLevel
            // 
            lblBlushingLevel.AutoSize = true;
            lblBlushingLevel.Font = new Font("Microsoft Sans Serif", 9F);
            lblBlushingLevel.Location = new Point(2, 61);
            lblBlushingLevel.Name = "lblBlushingLevel";
            lblBlushingLevel.Size = new Size(90, 15);
            lblBlushingLevel.TabIndex = 26;
            lblBlushingLevel.Text = "[BlushingLevel]";
            lblBlushingLevel.TextResourceKey = "CharaStepBlushingLevelLabel";
            // 
            // txtFaceAnim
            // 
            txtFaceAnim.AutoScroll = true;
            txtFaceAnim.BackColor = SystemColors.Window;
            txtFaceAnim.BorderColor = Color.FromArgb(66, 124, 244);
            txtFaceAnim.BorderFocusColor = Color.HotPink;
            txtFaceAnim.BorderSize = 2;
            txtFaceAnim.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFaceAnim.ForeColor = Color.Black;
            txtFaceAnim.Location = new Point(125, 4);
            txtFaceAnim.Margin = new Padding(4);
            txtFaceAnim.Multiline = false;
            txtFaceAnim.Name = "txtFaceAnim";
            txtFaceAnim.Padding = new Padding(7);
            txtFaceAnim.PasswordChar = false;
            txtFaceAnim.ReadOnly = false;
            txtFaceAnim.Size = new Size(122, 31);
            txtFaceAnim.TabIndex = 25;
            txtFaceAnim.Texts = "";
            txtFaceAnim.UnderlinedStyle = false;
            // 
            // lblFaceAnim
            // 
            lblFaceAnim.AutoSize = true;
            lblFaceAnim.Font = new Font("Microsoft Sans Serif", 9F);
            lblFaceAnim.Location = new Point(2, 10);
            lblFaceAnim.Name = "lblFaceAnim";
            lblFaceAnim.Size = new Size(68, 15);
            lblFaceAnim.TabIndex = 24;
            lblFaceAnim.Text = "[FaceAnim]";
            lblFaceAnim.TextResourceKey = "CharaStepFaceAnimLabel";
            // 
            // gbCoordinates
            // 
            gbCoordinates.AutoSize = true;
            gbCoordinates.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbCoordinates.Controls.Add(flowLayoutPanel5);
            gbCoordinates.Controls.Add(flowLayoutPanel2);
            gbCoordinates.Controls.Add(chkCoordinateChange);
            gbCoordinates.FlatStyle = FlatStyle.Flat;
            gbCoordinates.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbCoordinates.Location = new Point(3, 619);
            gbCoordinates.MinimumSize = new Size(267, 0);
            gbCoordinates.Name = "gbCoordinates";
            gbCoordinates.Size = new Size(267, 225);
            gbCoordinates.TabIndex = 4;
            gbCoordinates.TabStop = false;
            gbCoordinates.Text = "[Coordinates]";
            gbCoordinates.TextResourceKey = "CharaStepCoordinatesGroupLabel";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(pnlCoordinates);
            flowLayoutPanel5.Location = new Point(6, 47);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(255, 157);
            flowLayoutPanel5.TabIndex = 29;
            // 
            // pnlCoordinates
            // 
            pnlCoordinates.Controls.Add(lblSmoothMovementDuration);
            pnlCoordinates.Controls.Add(txtSmoothMovementDuration);
            pnlCoordinates.Controls.Add(chkSmoothMovement);
            pnlCoordinates.Controls.Add(txtCoordinatesRot);
            pnlCoordinates.Controls.Add(lblCoordinatesRot);
            pnlCoordinates.Controls.Add(txtCoordinatesPos);
            pnlCoordinates.Controls.Add(lblCoordinatesPos);
            pnlCoordinates.Location = new Point(3, 3);
            pnlCoordinates.Name = "pnlCoordinates";
            pnlCoordinates.Size = new Size(249, 151);
            pnlCoordinates.TabIndex = 0;
            pnlCoordinates.Visible = false;
            // 
            // lblSmoothMovementDuration
            // 
            lblSmoothMovementDuration.AutoSize = true;
            lblSmoothMovementDuration.Font = new Font("Microsoft Sans Serif", 9F);
            lblSmoothMovementDuration.Location = new Point(4, 113);
            lblSmoothMovementDuration.Name = "lblSmoothMovementDuration";
            lblSmoothMovementDuration.Size = new Size(60, 15);
            lblSmoothMovementDuration.TabIndex = 32;
            lblSmoothMovementDuration.Text = "[Duration]";
            lblSmoothMovementDuration.TextResourceKey = "CharaStepSmoothMovementDurationLabel";
            // 
            // txtSmoothMovementDuration
            // 
            txtSmoothMovementDuration.AutoScroll = true;
            txtSmoothMovementDuration.BackColor = SystemColors.Window;
            txtSmoothMovementDuration.BorderColor = Color.FromArgb(66, 124, 244);
            txtSmoothMovementDuration.BorderFocusColor = Color.HotPink;
            txtSmoothMovementDuration.BorderSize = 2;
            txtSmoothMovementDuration.Enabled = false;
            txtSmoothMovementDuration.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSmoothMovementDuration.ForeColor = Color.Black;
            txtSmoothMovementDuration.Location = new Point(199, 113);
            txtSmoothMovementDuration.Margin = new Padding(4);
            txtSmoothMovementDuration.Multiline = false;
            txtSmoothMovementDuration.Name = "txtSmoothMovementDuration";
            txtSmoothMovementDuration.Padding = new Padding(7);
            txtSmoothMovementDuration.PasswordChar = false;
            txtSmoothMovementDuration.ReadOnly = false;
            txtSmoothMovementDuration.Size = new Size(50, 31);
            txtSmoothMovementDuration.TabIndex = 31;
            txtSmoothMovementDuration.Texts = "";
            txtSmoothMovementDuration.UnderlinedStyle = false;
            // 
            // chkSmoothMovement
            // 
            chkSmoothMovement.AutoSize = true;
            chkSmoothMovement.Font = new Font("Microsoft Sans Serif", 9F);
            chkSmoothMovement.Location = new Point(0, 81);
            chkSmoothMovement.Name = "chkSmoothMovement";
            chkSmoothMovement.Size = new Size(133, 19);
            chkSmoothMovement.TabIndex = 30;
            chkSmoothMovement.Text = "[SmoothMovement]";
            chkSmoothMovement.TextResourceKey = "CharaStepSmoothMovementLabel";
            chkSmoothMovement.UseVisualStyleBackColor = true;
            chkSmoothMovement.CheckedChanged += chkSmoothMovement_CheckedChanged;
            // 
            // txtCoordinatesRot
            // 
            txtCoordinatesRot.AutoScroll = true;
            txtCoordinatesRot.BackColor = SystemColors.Window;
            txtCoordinatesRot.BorderColor = Color.FromArgb(66, 124, 244);
            txtCoordinatesRot.BorderFocusColor = Color.HotPink;
            txtCoordinatesRot.BorderSize = 2;
            txtCoordinatesRot.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoordinatesRot.ForeColor = Color.Black;
            txtCoordinatesRot.Location = new Point(68, 43);
            txtCoordinatesRot.Margin = new Padding(4);
            txtCoordinatesRot.Multiline = false;
            txtCoordinatesRot.Name = "txtCoordinatesRot";
            txtCoordinatesRot.Padding = new Padding(7);
            txtCoordinatesRot.PasswordChar = false;
            txtCoordinatesRot.ReadOnly = false;
            txtCoordinatesRot.Size = new Size(181, 31);
            txtCoordinatesRot.TabIndex = 25;
            txtCoordinatesRot.Texts = "";
            txtCoordinatesRot.UnderlinedStyle = false;
            // 
            // lblCoordinatesRot
            // 
            lblCoordinatesRot.AutoSize = true;
            lblCoordinatesRot.Font = new Font("Microsoft Sans Serif", 9F);
            lblCoordinatesRot.Location = new Point(4, 51);
            lblCoordinatesRot.Name = "lblCoordinatesRot";
            lblCoordinatesRot.Size = new Size(59, 15);
            lblCoordinatesRot.TabIndex = 24;
            lblCoordinatesRot.Text = "[Rotation]";
            lblCoordinatesRot.TextResourceKey = "Rot";
            // 
            // txtCoordinatesPos
            // 
            txtCoordinatesPos.AutoScroll = true;
            txtCoordinatesPos.BackColor = SystemColors.Window;
            txtCoordinatesPos.BorderColor = Color.FromArgb(66, 124, 244);
            txtCoordinatesPos.BorderFocusColor = Color.HotPink;
            txtCoordinatesPos.BorderSize = 2;
            txtCoordinatesPos.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoordinatesPos.ForeColor = Color.Black;
            txtCoordinatesPos.Location = new Point(68, 4);
            txtCoordinatesPos.Margin = new Padding(4);
            txtCoordinatesPos.Multiline = false;
            txtCoordinatesPos.Name = "txtCoordinatesPos";
            txtCoordinatesPos.Padding = new Padding(7);
            txtCoordinatesPos.PasswordChar = false;
            txtCoordinatesPos.ReadOnly = false;
            txtCoordinatesPos.Size = new Size(181, 31);
            txtCoordinatesPos.TabIndex = 23;
            txtCoordinatesPos.Texts = "";
            txtCoordinatesPos.UnderlinedStyle = false;
            // 
            // lblCoordinatesPos
            // 
            lblCoordinatesPos.AutoSize = true;
            lblCoordinatesPos.Font = new Font("Microsoft Sans Serif", 9F);
            lblCoordinatesPos.Location = new Point(4, 10);
            lblCoordinatesPos.Name = "lblCoordinatesPos";
            lblCoordinatesPos.Size = new Size(57, 15);
            lblCoordinatesPos.TabIndex = 22;
            lblCoordinatesPos.Text = "[Position]";
            lblCoordinatesPos.TextResourceKey = "Pos";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 21);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // chkCoordinateChange
            // 
            chkCoordinateChange.AutoSize = true;
            chkCoordinateChange.Font = new Font("Microsoft Sans Serif", 9F);
            chkCoordinateChange.Location = new Point(9, 21);
            chkCoordinateChange.Name = "chkCoordinateChange";
            chkCoordinateChange.Size = new Size(116, 19);
            chkCoordinateChange.TabIndex = 28;
            chkCoordinateChange.Text = "[RequireUpdate]";
            chkCoordinateChange.TextResourceKey = "RequireUpdate";
            chkCoordinateChange.UseVisualStyleBackColor = true;
            chkCoordinateChange.CheckedChanged += chkCoordinateChange_CheckedChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbTarget);
            flowLayoutPanel3.Controls.Add(gbStatus);
            flowLayoutPanel3.Controls.Add(gbCoordinates);
            flowLayoutPanel3.Controls.Add(gbMotion);
            flowLayoutPanel3.Controls.Add(gbEyeSight);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 1626);
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
            gbTarget.Controls.Add(flowLayoutPanel1);
            gbTarget.Controls.Add(lblTarget);
            gbTarget.FlatStyle = FlatStyle.Flat;
            gbTarget.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbTarget.Location = new Point(3, 213);
            gbTarget.Name = "gbTarget";
            gbTarget.Size = new Size(267, 156);
            gbTarget.TabIndex = 6;
            gbTarget.TabStop = false;
            gbTarget.Text = "[Target]";
            gbTarget.TextResourceKey = "CharaStepTargetGroupLabel";
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(pnlPosition);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 76);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 62);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // pnlPosition
            // 
            pnlPosition.Controls.Add(chkUseBranchIndex);
            pnlPosition.Controls.Add(lblPosition);
            pnlPosition.Controls.Add(cbListIndex);
            pnlPosition.Location = new Point(3, 3);
            pnlPosition.Name = "pnlPosition";
            pnlPosition.Size = new Size(252, 56);
            pnlPosition.TabIndex = 23;
            // 
            // chkUseBranchIndex
            // 
            chkUseBranchIndex.AutoSize = true;
            chkUseBranchIndex.Font = new Font("Microsoft Sans Serif", 9F);
            chkUseBranchIndex.Location = new Point(4, 8);
            chkUseBranchIndex.Name = "chkUseBranchIndex";
            chkUseBranchIndex.Size = new Size(123, 19);
            chkUseBranchIndex.TabIndex = 22;
            chkUseBranchIndex.Text = "[UseBranchIndex]";
            chkUseBranchIndex.TextResourceKey = "TalkStepUseBranchIndexLabel";
            chkUseBranchIndex.UseVisualStyleBackColor = true;
            chkUseBranchIndex.Visible = false;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblPosition.Location = new Point(4, 30);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 15);
            lblPosition.TabIndex = 21;
            lblPosition.Text = "[Position]";
            lblPosition.TextResourceKey = "TalkStepSpeakerListPositionLabel";
            // 
            // cbListIndex
            // 
            cbListIndex.DisplayMember = "Value";
            cbListIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListIndex.FlatStyle = FlatStyle.Flat;
            cbListIndex.Font = new Font("Microsoft Sans Serif", 9F);
            cbListIndex.FormattingEnabled = true;
            cbListIndex.Location = new Point(141, 27);
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
            lblTarget.TextResourceKey = "CharaStepTargetTypeLabel";
            // 
            // gbMotion
            // 
            gbMotion.AutoSize = true;
            gbMotion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbMotion.Controls.Add(chkMotionUpdate);
            gbMotion.Controls.Add(pnlMotionUpdate);
            gbMotion.FlatStyle = FlatStyle.Flat;
            gbMotion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbMotion.Location = new Point(3, 850);
            gbMotion.MinimumSize = new Size(267, 0);
            gbMotion.Name = "gbMotion";
            gbMotion.Padding = new Padding(3, 3, 3, 0);
            gbMotion.Size = new Size(267, 417);
            gbMotion.TabIndex = 6;
            gbMotion.TabStop = false;
            gbMotion.Text = "[Motion]";
            gbMotion.TextResourceKey = "CharaStepMotionGroupLabel";
            // 
            // chkMotionUpdate
            // 
            chkMotionUpdate.AutoSize = true;
            chkMotionUpdate.Font = new Font("Microsoft Sans Serif", 9F);
            chkMotionUpdate.Location = new Point(9, 21);
            chkMotionUpdate.Name = "chkMotionUpdate";
            chkMotionUpdate.Size = new Size(116, 19);
            chkMotionUpdate.TabIndex = 29;
            chkMotionUpdate.Text = "[RequireUpdate]";
            chkMotionUpdate.TextResourceKey = "RequireUpdate";
            chkMotionUpdate.UseVisualStyleBackColor = true;
            chkMotionUpdate.CheckedChanged += chkMotionUpdate_CheckedChanged;
            // 
            // pnlMotionUpdate
            // 
            pnlMotionUpdate.AutoSize = true;
            pnlMotionUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlMotionUpdate.Controls.Add(lblMotionType);
            pnlMotionUpdate.Controls.Add(flowLayoutPanel7);
            pnlMotionUpdate.Controls.Add(pnlMotionScript);
            pnlMotionUpdate.Controls.Add(pnlMotionAnimation);
            pnlMotionUpdate.Controls.Add(pnlCustomAnimination);
            pnlMotionUpdate.Controls.Add(chkLoopMotion);
            pnlMotionUpdate.Controls.Add(chkSmoothMotionTransition);
            pnlMotionUpdate.FlowDirection = FlowDirection.TopDown;
            pnlMotionUpdate.Location = new Point(6, 46);
            pnlMotionUpdate.Name = "pnlMotionUpdate";
            pnlMotionUpdate.Size = new Size(255, 353);
            pnlMotionUpdate.TabIndex = 28;
            pnlMotionUpdate.Visible = false;
            // 
            // lblMotionType
            // 
            lblMotionType.AutoSize = true;
            lblMotionType.Font = new Font("Microsoft Sans Serif", 9F);
            lblMotionType.Location = new Point(3, 0);
            lblMotionType.Name = "lblMotionType";
            lblMotionType.Size = new Size(39, 15);
            lblMotionType.TabIndex = 32;
            lblMotionType.Text = "[Type]";
            lblMotionType.TextResourceKey = "CharaStepMotionTypeLabel";
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel7.Controls.Add(rbMotionScript);
            flowLayoutPanel7.Controls.Add(rbAnimationFile);
            flowLayoutPanel7.Controls.Add(rbCustomAnimation);
            flowLayoutPanel7.Location = new Point(3, 18);
            flowLayoutPanel7.MaximumSize = new Size(270, 300);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(160, 50);
            flowLayoutPanel7.TabIndex = 31;
            // 
            // rbMotionScript
            // 
            rbMotionScript.AutoSize = true;
            rbMotionScript.Checked = true;
            rbMotionScript.Font = new Font("Microsoft Sans Serif", 9F);
            rbMotionScript.Location = new Point(3, 3);
            rbMotionScript.Name = "rbMotionScript";
            rbMotionScript.Size = new Size(62, 19);
            rbMotionScript.TabIndex = 29;
            rbMotionScript.TabStop = true;
            rbMotionScript.Text = "[Script]";
            rbMotionScript.TextResourceKey = "CharaStepMotionScriptLabel";
            rbMotionScript.UseVisualStyleBackColor = true;
            rbMotionScript.CheckedChanged += rbMotionScript_CheckedChanged;
            // 
            // rbAnimationFile
            // 
            rbAnimationFile.AutoSize = true;
            rbAnimationFile.Font = new Font("Microsoft Sans Serif", 9F);
            rbAnimationFile.Location = new Point(71, 3);
            rbAnimationFile.Name = "rbAnimationFile";
            rbAnimationFile.Size = new Size(86, 19);
            rbAnimationFile.TabIndex = 30;
            rbAnimationFile.Text = "[Animation]";
            rbAnimationFile.TextResourceKey = "CharaStepMotionAnimationLabel";
            rbAnimationFile.UseVisualStyleBackColor = true;
            rbAnimationFile.CheckedChanged += rbAnimationFile_CheckedChanged;
            // 
            // rbCustomAnimation
            // 
            rbCustomAnimation.AutoSize = true;
            rbCustomAnimation.Font = new Font("Microsoft Sans Serif", 9F);
            rbCustomAnimation.Location = new Point(3, 28);
            rbCustomAnimation.Name = "rbCustomAnimation";
            rbCustomAnimation.Size = new Size(128, 19);
            rbCustomAnimation.TabIndex = 0;
            rbCustomAnimation.Text = "[CustomAnimation]";
            rbCustomAnimation.TextResourceKey = "CharaStepMotionCustomAnimationLabel";
            rbCustomAnimation.UseVisualStyleBackColor = true;
            rbCustomAnimation.CheckedChanged += rbCustomAnimation_CheckedChanged;
            // 
            // pnlMotionScript
            // 
            pnlMotionScript.Controls.Add(txtScriptLabel);
            pnlMotionScript.Controls.Add(lblMotionScriptLabel);
            pnlMotionScript.Controls.Add(txtScriptFile);
            pnlMotionScript.Controls.Add(lblScriptFile);
            pnlMotionScript.Location = new Point(3, 74);
            pnlMotionScript.Name = "pnlMotionScript";
            pnlMotionScript.Size = new Size(249, 100);
            pnlMotionScript.TabIndex = 28;
            // 
            // txtScriptLabel
            // 
            txtScriptLabel.AutoScroll = true;
            txtScriptLabel.BackColor = SystemColors.Window;
            txtScriptLabel.BorderColor = Color.FromArgb(66, 124, 244);
            txtScriptLabel.BorderFocusColor = Color.HotPink;
            txtScriptLabel.BorderSize = 2;
            txtScriptLabel.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScriptLabel.ForeColor = Color.Black;
            txtScriptLabel.Location = new Point(89, 53);
            txtScriptLabel.Margin = new Padding(4);
            txtScriptLabel.Multiline = false;
            txtScriptLabel.Name = "txtScriptLabel";
            txtScriptLabel.Padding = new Padding(7);
            txtScriptLabel.PasswordChar = false;
            txtScriptLabel.ReadOnly = false;
            txtScriptLabel.Size = new Size(156, 31);
            txtScriptLabel.TabIndex = 29;
            txtScriptLabel.Texts = "";
            txtScriptLabel.UnderlinedStyle = false;
            // 
            // lblMotionScriptLabel
            // 
            lblMotionScriptLabel.AutoSize = true;
            lblMotionScriptLabel.Font = new Font("Microsoft Sans Serif", 9F);
            lblMotionScriptLabel.Location = new Point(4, 61);
            lblMotionScriptLabel.Name = "lblMotionScriptLabel";
            lblMotionScriptLabel.Size = new Size(78, 15);
            lblMotionScriptLabel.TabIndex = 28;
            lblMotionScriptLabel.Text = "[Script Label]";
            lblMotionScriptLabel.TextResourceKey = "ScriptLabelLabel";
            // 
            // txtScriptFile
            // 
            txtScriptFile.AutoScroll = true;
            txtScriptFile.BackColor = SystemColors.Window;
            txtScriptFile.BorderColor = Color.FromArgb(66, 124, 244);
            txtScriptFile.BorderFocusColor = Color.HotPink;
            txtScriptFile.BorderSize = 2;
            txtScriptFile.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtScriptFile.ForeColor = Color.Black;
            txtScriptFile.Location = new Point(89, 14);
            txtScriptFile.Margin = new Padding(4);
            txtScriptFile.Multiline = false;
            txtScriptFile.Name = "txtScriptFile";
            txtScriptFile.Padding = new Padding(7);
            txtScriptFile.PasswordChar = false;
            txtScriptFile.ReadOnly = false;
            txtScriptFile.Size = new Size(156, 31);
            txtScriptFile.TabIndex = 27;
            txtScriptFile.Texts = "";
            txtScriptFile.UnderlinedStyle = false;
            // 
            // lblScriptFile
            // 
            lblScriptFile.AutoSize = true;
            lblScriptFile.Font = new Font("Microsoft Sans Serif", 9F);
            lblScriptFile.Location = new Point(4, 20);
            lblScriptFile.Name = "lblScriptFile";
            lblScriptFile.Size = new Size(64, 15);
            lblScriptFile.TabIndex = 26;
            lblScriptFile.Text = "[ScriptFile]";
            lblScriptFile.TextResourceKey = "ScriptFileLabel";
            // 
            // pnlMotionAnimation
            // 
            pnlMotionAnimation.Controls.Add(txtAnimationFile);
            pnlMotionAnimation.Controls.Add(lblAnimationFile);
            pnlMotionAnimation.Location = new Point(3, 180);
            pnlMotionAnimation.Name = "pnlMotionAnimation";
            pnlMotionAnimation.Size = new Size(249, 56);
            pnlMotionAnimation.TabIndex = 33;
            // 
            // txtAnimationFile
            // 
            txtAnimationFile.AutoScroll = true;
            txtAnimationFile.BackColor = SystemColors.Window;
            txtAnimationFile.BorderColor = Color.FromArgb(66, 124, 244);
            txtAnimationFile.BorderFocusColor = Color.HotPink;
            txtAnimationFile.BorderSize = 2;
            txtAnimationFile.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnimationFile.ForeColor = Color.Black;
            txtAnimationFile.Location = new Point(89, 14);
            txtAnimationFile.Margin = new Padding(4);
            txtAnimationFile.Multiline = false;
            txtAnimationFile.Name = "txtAnimationFile";
            txtAnimationFile.Padding = new Padding(7);
            txtAnimationFile.PasswordChar = false;
            txtAnimationFile.ReadOnly = false;
            txtAnimationFile.Size = new Size(156, 31);
            txtAnimationFile.TabIndex = 27;
            txtAnimationFile.Texts = "";
            txtAnimationFile.UnderlinedStyle = false;
            // 
            // lblAnimationFile
            // 
            lblAnimationFile.AutoSize = true;
            lblAnimationFile.Font = new Font("Microsoft Sans Serif", 9F);
            lblAnimationFile.Location = new Point(4, 20);
            lblAnimationFile.Name = "lblAnimationFile";
            lblAnimationFile.Size = new Size(61, 15);
            lblAnimationFile.TabIndex = 26;
            lblAnimationFile.Text = "[AnimFile]";
            lblAnimationFile.TextResourceKey = "CharaStepMotionAnimationFileLabel";
            // 
            // pnlCustomAnimination
            // 
            pnlCustomAnimination.Controls.Add(txtMotionCustomAnimation);
            pnlCustomAnimination.Controls.Add(lblCustomAnimation);
            pnlCustomAnimination.Location = new Point(3, 242);
            pnlCustomAnimination.Name = "pnlCustomAnimination";
            pnlCustomAnimination.Size = new Size(249, 58);
            pnlCustomAnimination.TabIndex = 34;
            // 
            // txtMotionCustomAnimation
            // 
            txtMotionCustomAnimation.AutoScroll = true;
            txtMotionCustomAnimation.BackColor = SystemColors.Window;
            txtMotionCustomAnimation.BorderColor = Color.FromArgb(66, 124, 244);
            txtMotionCustomAnimation.BorderFocusColor = Color.HotPink;
            txtMotionCustomAnimation.BorderSize = 2;
            txtMotionCustomAnimation.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMotionCustomAnimation.ForeColor = Color.Black;
            txtMotionCustomAnimation.Location = new Point(89, 14);
            txtMotionCustomAnimation.Margin = new Padding(4);
            txtMotionCustomAnimation.Multiline = false;
            txtMotionCustomAnimation.Name = "txtMotionCustomAnimation";
            txtMotionCustomAnimation.Padding = new Padding(7);
            txtMotionCustomAnimation.PasswordChar = false;
            txtMotionCustomAnimation.ReadOnly = false;
            txtMotionCustomAnimation.Size = new Size(156, 31);
            txtMotionCustomAnimation.TabIndex = 27;
            txtMotionCustomAnimation.Texts = "";
            txtMotionCustomAnimation.UnderlinedStyle = false;
            // 
            // lblCustomAnimation
            // 
            lblCustomAnimation.Font = new Font("Microsoft Sans Serif", 9F);
            lblCustomAnimation.Location = new Point(4, 14);
            lblCustomAnimation.Name = "lblCustomAnimation";
            lblCustomAnimation.Size = new Size(78, 31);
            lblCustomAnimation.TabIndex = 26;
            lblCustomAnimation.Text = "[CustomAnimFile]";
            lblCustomAnimation.TextResourceKey = "CharaStepMotionCustomAnimationFileLabel";
            // 
            // chkLoopMotion
            // 
            chkLoopMotion.AutoSize = true;
            chkLoopMotion.Font = new Font("Microsoft Sans Serif", 9F);
            chkLoopMotion.Location = new Point(3, 306);
            chkLoopMotion.Name = "chkLoopMotion";
            chkLoopMotion.Size = new Size(98, 19);
            chkLoopMotion.TabIndex = 30;
            chkLoopMotion.Text = "[LoopMotion]";
            chkLoopMotion.TextResourceKey = "CharaStepMotionLoopMotionLabel";
            chkLoopMotion.UseVisualStyleBackColor = true;
            // 
            // chkSmoothMotionTransition
            // 
            chkSmoothMotionTransition.AutoSize = true;
            chkSmoothMotionTransition.Font = new Font("Microsoft Sans Serif", 9F);
            chkSmoothMotionTransition.Location = new Point(3, 331);
            chkSmoothMotionTransition.Name = "chkSmoothMotionTransition";
            chkSmoothMotionTransition.Size = new Size(167, 19);
            chkSmoothMotionTransition.TabIndex = 35;
            chkSmoothMotionTransition.Text = "[SmoothMotionTransition]";
            chkSmoothMotionTransition.TextResourceKey = "CharaStepMotionSmoothMotionTransitionLabel";
            chkSmoothMotionTransition.UseVisualStyleBackColor = true;
            // 
            // gbEyeSight
            // 
            gbEyeSight.AutoSize = true;
            gbEyeSight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbEyeSight.Controls.Add(chkEyeSightUpdate);
            gbEyeSight.Controls.Add(pnlEyeSightUpdate);
            gbEyeSight.FlatStyle = FlatStyle.Flat;
            gbEyeSight.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbEyeSight.Location = new Point(3, 1273);
            gbEyeSight.MinimumSize = new Size(267, 0);
            gbEyeSight.Name = "gbEyeSight";
            gbEyeSight.Padding = new Padding(3, 3, 3, 0);
            gbEyeSight.Size = new Size(267, 350);
            gbEyeSight.TabIndex = 7;
            gbEyeSight.TabStop = false;
            gbEyeSight.Text = "[EyeSight]";
            gbEyeSight.TextResourceKey = "CharaStepEyeSightGroupLabel";
            // 
            // chkEyeSightUpdate
            // 
            chkEyeSightUpdate.AutoSize = true;
            chkEyeSightUpdate.Font = new Font("Microsoft Sans Serif", 9F);
            chkEyeSightUpdate.Location = new Point(9, 21);
            chkEyeSightUpdate.Name = "chkEyeSightUpdate";
            chkEyeSightUpdate.Size = new Size(116, 19);
            chkEyeSightUpdate.TabIndex = 30;
            chkEyeSightUpdate.Text = "[RequireUpdate]";
            chkEyeSightUpdate.TextResourceKey = "RequireUpdate";
            chkEyeSightUpdate.UseVisualStyleBackColor = true;
            chkEyeSightUpdate.CheckedChanged += chkEyeSightUpdate_CheckedChanged;
            // 
            // pnlEyeSightUpdate
            // 
            pnlEyeSightUpdate.AutoSize = true;
            pnlEyeSightUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlEyeSightUpdate.Controls.Add(lblEyeSightType);
            pnlEyeSightUpdate.Controls.Add(flowLayoutPanel9);
            pnlEyeSightUpdate.Controls.Add(pnlEyeSightCamera);
            pnlEyeSightUpdate.Controls.Add(pnlEyeSightCharacter);
            pnlEyeSightUpdate.FlowDirection = FlowDirection.TopDown;
            pnlEyeSightUpdate.Location = new Point(6, 46);
            pnlEyeSightUpdate.Name = "pnlEyeSightUpdate";
            pnlEyeSightUpdate.Size = new Size(255, 286);
            pnlEyeSightUpdate.TabIndex = 28;
            pnlEyeSightUpdate.Visible = false;
            // 
            // lblEyeSightType
            // 
            lblEyeSightType.AutoSize = true;
            lblEyeSightType.Font = new Font("Microsoft Sans Serif", 9F);
            lblEyeSightType.Location = new Point(3, 0);
            lblEyeSightType.Name = "lblEyeSightType";
            lblEyeSightType.Size = new Size(39, 15);
            lblEyeSightType.TabIndex = 32;
            lblEyeSightType.Text = "[Type]";
            lblEyeSightType.TextResourceKey = "CharaStepEyeSightTypeLabel";
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.AutoSize = true;
            flowLayoutPanel9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel9.Controls.Add(rbEyeSightCamera);
            flowLayoutPanel9.Controls.Add(rbEyeSightCharacter);
            flowLayoutPanel9.Location = new Point(3, 18);
            flowLayoutPanel9.MaximumSize = new Size(270, 300);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Size = new Size(171, 25);
            flowLayoutPanel9.TabIndex = 31;
            // 
            // rbEyeSightCamera
            // 
            rbEyeSightCamera.AutoSize = true;
            rbEyeSightCamera.Checked = true;
            rbEyeSightCamera.Font = new Font("Microsoft Sans Serif", 9F);
            rbEyeSightCamera.Location = new Point(3, 3);
            rbEyeSightCamera.Name = "rbEyeSightCamera";
            rbEyeSightCamera.Size = new Size(75, 19);
            rbEyeSightCamera.TabIndex = 29;
            rbEyeSightCamera.TabStop = true;
            rbEyeSightCamera.Text = "[Camera]";
            rbEyeSightCamera.TextResourceKey = "CharaStepEyeSightCameraLabel";
            rbEyeSightCamera.UseVisualStyleBackColor = true;
            rbEyeSightCamera.CheckedChanged += rbEyeSightCamera_CheckedChanged;
            // 
            // rbEyeSightCharacter
            // 
            rbEyeSightCharacter.AutoSize = true;
            rbEyeSightCharacter.Font = new Font("Microsoft Sans Serif", 9F);
            rbEyeSightCharacter.Location = new Point(84, 3);
            rbEyeSightCharacter.Name = "rbEyeSightCharacter";
            rbEyeSightCharacter.Size = new Size(84, 19);
            rbEyeSightCharacter.TabIndex = 30;
            rbEyeSightCharacter.Text = "[Character]";
            rbEyeSightCharacter.TextResourceKey = "CharaStepEyeSightCharacterLabel";
            rbEyeSightCharacter.UseVisualStyleBackColor = true;
            rbEyeSightCharacter.CheckedChanged += rbEyeSightCharacter_CheckedChanged;
            // 
            // pnlEyeSightCamera
            // 
            pnlEyeSightCamera.Controls.Add(cbEyeSightCameraType);
            pnlEyeSightCamera.Controls.Add(lblEyeSightCameraType);
            pnlEyeSightCamera.Location = new Point(3, 49);
            pnlEyeSightCamera.Name = "pnlEyeSightCamera";
            pnlEyeSightCamera.Size = new Size(249, 74);
            pnlEyeSightCamera.TabIndex = 28;
            // 
            // cbEyeSightCameraType
            // 
            cbEyeSightCameraType.DisplayMember = "DisplayText";
            cbEyeSightCameraType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEyeSightCameraType.FlatStyle = FlatStyle.Flat;
            cbEyeSightCameraType.Font = new Font("Microsoft Sans Serif", 9F);
            cbEyeSightCameraType.FormattingEnabled = true;
            cbEyeSightCameraType.Location = new Point(3, 37);
            cbEyeSightCameraType.Name = "cbEyeSightCameraType";
            cbEyeSightCameraType.Size = new Size(239, 23);
            cbEyeSightCameraType.TabIndex = 27;
            cbEyeSightCameraType.ValueMember = "DataKey";
            // 
            // lblEyeSightCameraType
            // 
            lblEyeSightCameraType.Font = new Font("Microsoft Sans Serif", 9F);
            lblEyeSightCameraType.Location = new Point(4, 0);
            lblEyeSightCameraType.Name = "lblEyeSightCameraType";
            lblEyeSightCameraType.Size = new Size(238, 34);
            lblEyeSightCameraType.TabIndex = 26;
            lblEyeSightCameraType.Text = "[Camera Type]";
            lblEyeSightCameraType.TextResourceKey = "CharaStepEyeSightCameraTypeLabel";
            // 
            // pnlEyeSightCharacter
            // 
            pnlEyeSightCharacter.AutoSize = true;
            pnlEyeSightCharacter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlEyeSightCharacter.Controls.Add(flowLayoutPanel11);
            pnlEyeSightCharacter.Controls.Add(flowLayoutPanel10);
            pnlEyeSightCharacter.Controls.Add(cbEyeSightCharacterType);
            pnlEyeSightCharacter.Controls.Add(lblEyeSightCharacterType);
            pnlEyeSightCharacter.Location = new Point(3, 129);
            pnlEyeSightCharacter.Name = "pnlEyeSightCharacter";
            pnlEyeSightCharacter.Size = new Size(249, 154);
            pnlEyeSightCharacter.TabIndex = 33;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.AutoSize = true;
            flowLayoutPanel11.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel11.Controls.Add(pnlEyeSightCharaPosition);
            flowLayoutPanel11.Controls.Add(pnlEyeSightGroupMember);
            flowLayoutPanel11.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel11.Location = new Point(0, 47);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Size = new Size(246, 104);
            flowLayoutPanel11.TabIndex = 32;
            // 
            // pnlEyeSightCharaPosition
            // 
            pnlEyeSightCharaPosition.Controls.Add(lblEyeSightCharacterIndexPosition);
            pnlEyeSightCharaPosition.Controls.Add(cbEyeSightCharaPosition);
            pnlEyeSightCharaPosition.Location = new Point(3, 3);
            pnlEyeSightCharaPosition.Name = "pnlEyeSightCharaPosition";
            pnlEyeSightCharaPosition.Size = new Size(240, 36);
            pnlEyeSightCharaPosition.TabIndex = 23;
            // 
            // lblEyeSightCharacterIndexPosition
            // 
            lblEyeSightCharacterIndexPosition.AutoSize = true;
            lblEyeSightCharacterIndexPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblEyeSightCharacterIndexPosition.Location = new Point(3, 5);
            lblEyeSightCharacterIndexPosition.Name = "lblEyeSightCharacterIndexPosition";
            lblEyeSightCharacterIndexPosition.Size = new Size(57, 15);
            lblEyeSightCharacterIndexPosition.TabIndex = 21;
            lblEyeSightCharacterIndexPosition.Text = "[Position]";
            lblEyeSightCharacterIndexPosition.TextResourceKey = "CharaStepEyeSightCharaPositionLabel";
            // 
            // cbEyeSightCharaPosition
            // 
            cbEyeSightCharaPosition.DisplayMember = "Value";
            cbEyeSightCharaPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEyeSightCharaPosition.FlatStyle = FlatStyle.Flat;
            cbEyeSightCharaPosition.Font = new Font("Microsoft Sans Serif", 9F);
            cbEyeSightCharaPosition.FormattingEnabled = true;
            cbEyeSightCharaPosition.Location = new Point(133, 3);
            cbEyeSightCharaPosition.Name = "cbEyeSightCharaPosition";
            cbEyeSightCharaPosition.Size = new Size(106, 23);
            cbEyeSightCharaPosition.TabIndex = 20;
            cbEyeSightCharaPosition.ValueMember = "Key";
            // 
            // pnlEyeSightGroupMember
            // 
            pnlEyeSightGroupMember.Controls.Add(lblGroupTarget);
            pnlEyeSightGroupMember.Controls.Add(cbGroupTarget);
            pnlEyeSightGroupMember.Controls.Add(lblGroupPosition);
            pnlEyeSightGroupMember.Controls.Add(cbGroupIndex);
            pnlEyeSightGroupMember.Location = new Point(3, 45);
            pnlEyeSightGroupMember.Name = "pnlEyeSightGroupMember";
            pnlEyeSightGroupMember.Size = new Size(240, 56);
            pnlEyeSightGroupMember.TabIndex = 31;
            // 
            // lblGroupTarget
            // 
            lblGroupTarget.AutoSize = true;
            lblGroupTarget.Font = new Font("Microsoft Sans Serif", 9F);
            lblGroupTarget.Location = new Point(3, 32);
            lblGroupTarget.Name = "lblGroupTarget";
            lblGroupTarget.Size = new Size(48, 15);
            lblGroupTarget.TabIndex = 23;
            lblGroupTarget.Text = "[Target]";
            lblGroupTarget.TextResourceKey = "CharaStepEyeSightGroupTargetLabel";
            // 
            // cbGroupTarget
            // 
            cbGroupTarget.DisplayMember = "DisplayText";
            cbGroupTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroupTarget.FlatStyle = FlatStyle.Flat;
            cbGroupTarget.Font = new Font("Microsoft Sans Serif", 9F);
            cbGroupTarget.FormattingEnabled = true;
            cbGroupTarget.Location = new Point(133, 30);
            cbGroupTarget.Name = "cbGroupTarget";
            cbGroupTarget.Size = new Size(106, 23);
            cbGroupTarget.TabIndex = 22;
            cbGroupTarget.ValueMember = "DataKey";
            // 
            // lblGroupPosition
            // 
            lblGroupPosition.AutoSize = true;
            lblGroupPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblGroupPosition.Location = new Point(3, 5);
            lblGroupPosition.Name = "lblGroupPosition";
            lblGroupPosition.Size = new Size(57, 15);
            lblGroupPosition.TabIndex = 21;
            lblGroupPosition.Text = "[Position]";
            lblGroupPosition.TextResourceKey = "CharaStepEyeSightGroupPositionLabel";
            // 
            // cbGroupIndex
            // 
            cbGroupIndex.DisplayMember = "Value";
            cbGroupIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroupIndex.FlatStyle = FlatStyle.Flat;
            cbGroupIndex.Font = new Font("Microsoft Sans Serif", 9F);
            cbGroupIndex.FormattingEnabled = true;
            cbGroupIndex.Location = new Point(133, 3);
            cbGroupIndex.Name = "cbGroupIndex";
            cbGroupIndex.Size = new Size(106, 23);
            cbGroupIndex.TabIndex = 20;
            cbGroupIndex.ValueMember = "Key";
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.AutoSize = true;
            flowLayoutPanel10.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel10.Location = new Point(-2, 41);
            flowLayoutPanel10.Margin = new Padding(0);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(0, 0);
            flowLayoutPanel10.TabIndex = 30;
            // 
            // cbEyeSightCharacterType
            // 
            cbEyeSightCharacterType.DisplayMember = "DisplayText";
            cbEyeSightCharacterType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEyeSightCharacterType.FlatStyle = FlatStyle.Flat;
            cbEyeSightCharacterType.Font = new Font("Microsoft Sans Serif", 9F);
            cbEyeSightCharacterType.FormattingEnabled = true;
            cbEyeSightCharacterType.Location = new Point(4, 18);
            cbEyeSightCharacterType.Name = "cbEyeSightCharacterType";
            cbEyeSightCharacterType.Size = new Size(238, 23);
            cbEyeSightCharacterType.TabIndex = 29;
            cbEyeSightCharacterType.ValueMember = "DataKey";
            cbEyeSightCharacterType.SelectedIndexChanged += cbEyeSightCharacterType_SelectedIndexChanged;
            // 
            // lblEyeSightCharacterType
            // 
            lblEyeSightCharacterType.AutoSize = true;
            lblEyeSightCharacterType.Font = new Font("Microsoft Sans Serif", 9F);
            lblEyeSightCharacterType.Location = new Point(4, 0);
            lblEyeSightCharacterType.Name = "lblEyeSightCharacterType";
            lblEyeSightCharacterType.Size = new Size(95, 15);
            lblEyeSightCharacterType.TabIndex = 28;
            lblEyeSightCharacterType.Text = "[Character Type]";
            lblEyeSightCharacterType.TextResourceKey = "CharaStepEyeSightCharacterTypeLabel";
            // 
            // CharaStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "CharaStep";
            Size = new Size(326, 1700);
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            flowLayoutPanel12.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            pnlFemaleFaceStatus.ResumeLayout(false);
            pnlFemaleFaceStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbTearLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlushing).EndInit();
            gbCoordinates.ResumeLayout(false);
            gbCoordinates.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            pnlCoordinates.ResumeLayout(false);
            pnlCoordinates.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            gbTarget.ResumeLayout(false);
            gbTarget.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            pnlPosition.ResumeLayout(false);
            pnlPosition.PerformLayout();
            gbMotion.ResumeLayout(false);
            gbMotion.PerformLayout();
            pnlMotionUpdate.ResumeLayout(false);
            pnlMotionUpdate.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            pnlMotionScript.ResumeLayout(false);
            pnlMotionScript.PerformLayout();
            pnlMotionAnimation.ResumeLayout(false);
            pnlMotionAnimation.PerformLayout();
            pnlCustomAnimination.ResumeLayout(false);
            gbEyeSight.ResumeLayout(false);
            gbEyeSight.PerformLayout();
            pnlEyeSightUpdate.ResumeLayout(false);
            pnlEyeSightUpdate.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            pnlEyeSightCamera.ResumeLayout(false);
            pnlEyeSightCharacter.ResumeLayout(false);
            pnlEyeSightCharacter.PerformLayout();
            flowLayoutPanel11.ResumeLayout(false);
            pnlEyeSightCharaPosition.ResumeLayout(false);
            pnlEyeSightCharaPosition.PerformLayout();
            pnlEyeSightGroupMember.ResumeLayout(false);
            pnlEyeSightGroupMember.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedGroupBox gbStatus;
        private ExtendedGroupBox gbCoordinates;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private ExtendedCheckBox chkVisible;
        private ExtendedCheckBox chkManNude;
        private ExtendedCheckBox chkOpenMouth;
        private ExtendedGroupBox gbTarget;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlPosition;
        private ExtendedCheckBox chkUseBranchIndex;
        private ExtendedLabel lblPosition;
        private ComboBox cbListIndex;
        private ComboBox cbTargetType;
        private ExtendedLabel lblTarget;
        private FlowLayoutPanel flowLayoutPanel4;
        private ExtendedCheckBox chkCoordinateChange;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel pnlCoordinates;
        private ExtendedLabel lblCoordinatesPos;
        private CustomControls.RJControls.RJTextBox txtCoordinatesPos;
        private CustomControls.RJControls.RJTextBox txtCoordinatesRot;
        private ExtendedLabel lblCoordinatesRot;
        private ExtendedCheckBox chkSmoothMovement;
        private CustomControls.RJControls.RJTextBox txtSmoothMovementDuration;
        private ExtendedLabel lblSmoothMovementDuration;
        private ExtendedGroupBox gbMotion;
        private FlowLayoutPanel pnlMotionUpdate;
        private Panel pnlMotionScript;
        private ExtendedRadioButton rbCustomAnimation;
        private FlowLayoutPanel flowLayoutPanel7;
        private ExtendedRadioButton rbMotionScript;
        private ExtendedRadioButton rbAnimationFile;
        private ExtendedLabel lblMotionType;
        private CustomControls.RJControls.RJTextBox txtScriptLabel;
        private ExtendedLabel lblMotionScriptLabel;
        private CustomControls.RJControls.RJTextBox txtScriptFile;
        private ExtendedLabel lblScriptFile;
        private Panel pnlMotionAnimation;
        private CustomControls.RJControls.RJTextBox txtAnimationFile;
        private ExtendedLabel lblAnimationFile;
        private Panel pnlCustomAnimination;
        private CustomControls.RJControls.RJTextBox txtMotionCustomAnimation;
        private ExtendedLabel lblCustomAnimation;
        private ExtendedGroupBox gbEyeSight;
        private FlowLayoutPanel pnlEyeSightUpdate;
        private ExtendedLabel lblEyeSightType;
        private FlowLayoutPanel flowLayoutPanel9;
        private ExtendedRadioButton rbEyeSightCamera;
        private ExtendedRadioButton rbEyeSightCharacter;
        private Panel pnlEyeSightCamera;
        private ExtendedLabel lblEyeSightCameraType;
        private Panel pnlEyeSightCharacter;
        private ComboBox cbEyeSightCameraType;
        private ExtendedLabel lblEyeSightCharacterType;
        private ComboBox cbEyeSightCharacterType;
        private FlowLayoutPanel flowLayoutPanel10;
        private Panel pnlEyeSightCharaPosition;
        private ExtendedLabel lblEyeSightCharacterIndexPosition;
        private ComboBox cbEyeSightCharaPosition;
        private Panel pnlEyeSightGroupMember;
        private ExtendedLabel lblGroupPosition;
        private ComboBox cbGroupIndex;
        private FlowLayoutPanel flowLayoutPanel11;
        private FlowLayoutPanel flowLayoutPanel12;
        private Panel pnlFemaleFaceStatus;
        private CustomControls.RJControls.RJTextBox txtFaceAnim;
        private ExtendedLabel lblFaceAnim;
        private ExtendedLabel lblBlushingLevel;
        private TrackBar tbBlushing;
        private ExtendedCheckBox chkFaceBlend;
        private ExtendedLabel lblTearLevel;
        private TrackBar tbTearLevel;
        private ExtendedLabel lblTearLevelValue;
        private ExtendedLabel lblBlushingLevelValue;
        private ExtendedCheckBox chkMotionUpdate;
        private ExtendedCheckBox chkLoopMotion;
        private ExtendedCheckBox chkSmoothMotionTransition;
        private ExtendedCheckBox chkEyeSightUpdate;
        private ExtendedLabel lblGroupTarget;
        private ComboBox cbGroupTarget;
    }
}
