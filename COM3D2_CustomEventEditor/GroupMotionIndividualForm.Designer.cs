namespace COM3D2_CustomEventEditor
{
    partial class GroupMotionIndividualForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupMotionIndividualForm));
            lblIndividualType = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            colorDialog = new ColorDialog();
            gbStatus = new COM3D2_CustomEventEditor.CustomControl.ExtendedGroupBox();
            flowLayoutPanel12 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            chkVisible = new COM3D2_CustomEventEditor.CustomControl.ExtendedCheckBox();
            chkManNude = new COM3D2_CustomEventEditor.CustomControl.ExtendedCheckBox();
            chkOpenMouth = new COM3D2_CustomEventEditor.CustomControl.ExtendedCheckBox();
            pnlFemaleFaceStatus = new Panel();
            lblTearLevelValue = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            lblBlushingLevelValue = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            tbTearLevel = new TrackBar();
            lblTearLevel = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            chkFaceBlend = new COM3D2_CustomEventEditor.CustomControl.ExtendedCheckBox();
            tbBlushing = new TrackBar();
            lblBlushingLevel = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            txtFaceAnim = new CustomControls.RJControls.RJTextBox();
            lblFaceAnim = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            gbCoordinates = new COM3D2_CustomEventEditor.CustomControl.ExtendedGroupBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            pnlCoordinates = new Panel();
            txtCoordinatesRot = new CustomControls.RJControls.RJTextBox();
            lblCoordinatesRot = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            txtCoordinatesPos = new CustomControls.RJControls.RJTextBox();
            lblCoordinatesPos = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            chkCoordinateChange = new COM3D2_CustomEventEditor.CustomControl.ExtendedCheckBox();
            gbEyeSight = new COM3D2_CustomEventEditor.CustomControl.ExtendedGroupBox();
            chkEyeSightUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedCheckBox();
            pnlEyeSightUpdate = new FlowLayoutPanel();
            lblEyeSightType = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            flowLayoutPanel9 = new FlowLayoutPanel();
            rbEyeSightCamera = new COM3D2_CustomEventEditor.CustomControl.ExtendedRadioButton();
            rbEyeSightCharacter = new COM3D2_CustomEventEditor.CustomControl.ExtendedRadioButton();
            pnlEyeSightCamera = new Panel();
            cbEyeSightCameraType = new ComboBox();
            lblEyeSightCameraType = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            pnlEyeSightCharacter = new Panel();
            flowLayoutPanel11 = new FlowLayoutPanel();
            pnlEyeSightCharaPosition = new Panel();
            lblEyeSightCharacterIndexPosition = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            cbEyeSightCharaPosition = new ComboBox();
            pnlEyeSightGroupMember = new Panel();
            lblGroupTarget = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            cbGroupTarget = new ComboBox();
            lblGroupPosition = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            cbGroupIndex = new ComboBox();
            flowLayoutPanel10 = new FlowLayoutPanel();
            cbEyeSightCharacterType = new ComboBox();
            lblEyeSightCharacterType = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gbStatus.SuspendLayout();
            flowLayoutPanel12.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            pnlFemaleFaceStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbTearLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlushing).BeginInit();
            gbCoordinates.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            pnlCoordinates.SuspendLayout();
            gbEyeSight.SuspendLayout();
            pnlEyeSightUpdate.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            pnlEyeSightCamera.SuspendLayout();
            pnlEyeSightCharacter.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            pnlEyeSightCharaPosition.SuspendLayout();
            pnlEyeSightGroupMember.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIndividualType
            // 
            lblIndividualType.AutoSize = true;
            lblIndividualType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblIndividualType.Location = new Point(12, 9);
            lblIndividualType.Name = "lblIndividualType";
            lblIndividualType.Size = new Size(91, 20);
            lblIndividualType.TabIndex = 19;
            lblIndividualType.Text = "[IndvType]";
            lblIndividualType.TextResourceKey = "";
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(477, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // gbStatus
            // 
            gbStatus.AutoSize = true;
            gbStatus.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbStatus.Controls.Add(flowLayoutPanel12);
            gbStatus.FlatStyle = FlatStyle.Flat;
            gbStatus.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbStatus.Location = new Point(3, 3);
            gbStatus.MinimumSize = new Size(267, 0);
            gbStatus.Name = "gbStatus";
            gbStatus.Padding = new Padding(3, 3, 3, 0);
            gbStatus.Size = new Size(267, 238);
            gbStatus.TabIndex = 32;
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
            gbCoordinates.Location = new Point(3, 247);
            gbCoordinates.MinimumSize = new Size(267, 0);
            gbCoordinates.Name = "gbCoordinates";
            gbCoordinates.Size = new Size(267, 154);
            gbCoordinates.TabIndex = 28;
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
            flowLayoutPanel5.Size = new Size(255, 86);
            flowLayoutPanel5.TabIndex = 29;
            // 
            // pnlCoordinates
            // 
            pnlCoordinates.Controls.Add(txtCoordinatesRot);
            pnlCoordinates.Controls.Add(lblCoordinatesRot);
            pnlCoordinates.Controls.Add(txtCoordinatesPos);
            pnlCoordinates.Controls.Add(lblCoordinatesPos);
            pnlCoordinates.Location = new Point(3, 3);
            pnlCoordinates.Name = "pnlCoordinates";
            pnlCoordinates.Size = new Size(249, 80);
            pnlCoordinates.TabIndex = 0;
            pnlCoordinates.Visible = false;
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
            // gbEyeSight
            // 
            gbEyeSight.AutoSize = true;
            gbEyeSight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbEyeSight.Controls.Add(chkEyeSightUpdate);
            gbEyeSight.Controls.Add(pnlEyeSightUpdate);
            gbEyeSight.FlatStyle = FlatStyle.Flat;
            gbEyeSight.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbEyeSight.Location = new Point(291, 35);
            gbEyeSight.MinimumSize = new Size(267, 0);
            gbEyeSight.Name = "gbEyeSight";
            gbEyeSight.Padding = new Padding(3, 3, 3, 0);
            gbEyeSight.Size = new Size(267, 350);
            gbEyeSight.TabIndex = 33;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(gbStatus);
            flowLayoutPanel1.Controls.Add(gbCoordinates);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(273, 404);
            flowLayoutPanel1.TabIndex = 34;
            // 
            // GroupMotionIndividualForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(576, 443);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(gbEyeSight);
            Controls.Add(lblIndividualType);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GroupMotionIndividualForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "NPC Settings";
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControl.ExtendedLabel lblIndividualType;
        private CustomControl.ExtendedButton btnUpdate;
        private ColorDialog colorDialog;
        private CustomControl.ExtendedGroupBox gbStatus;
        private FlowLayoutPanel flowLayoutPanel12;
        private FlowLayoutPanel flowLayoutPanel4;
        private CustomControl.ExtendedCheckBox chkVisible;
        private CustomControl.ExtendedCheckBox chkManNude;
        private CustomControl.ExtendedCheckBox chkOpenMouth;
        private Panel pnlFemaleFaceStatus;
        private CustomControl.ExtendedLabel lblTearLevelValue;
        private CustomControl.ExtendedLabel lblBlushingLevelValue;
        private TrackBar tbTearLevel;
        private CustomControl.ExtendedLabel lblTearLevel;
        private CustomControl.ExtendedCheckBox chkFaceBlend;
        private TrackBar tbBlushing;
        private CustomControl.ExtendedLabel lblBlushingLevel;
        private CustomControls.RJControls.RJTextBox txtFaceAnim;
        private CustomControl.ExtendedLabel lblFaceAnim;
        private CustomControl.ExtendedGroupBox gbCoordinates;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel pnlCoordinates;
        private CustomControls.RJControls.RJTextBox txtCoordinatesRot;
        private CustomControl.ExtendedLabel lblCoordinatesRot;
        private CustomControls.RJControls.RJTextBox txtCoordinatesPos;
        private CustomControl.ExtendedLabel lblCoordinatesPos;
        private FlowLayoutPanel flowLayoutPanel2;
        private CustomControl.ExtendedCheckBox chkCoordinateChange;
        private CustomControl.ExtendedGroupBox gbEyeSight;
        private CustomControl.ExtendedCheckBox chkEyeSightUpdate;
        private FlowLayoutPanel pnlEyeSightUpdate;
        private CustomControl.ExtendedLabel lblEyeSightType;
        private FlowLayoutPanel flowLayoutPanel9;
        private CustomControl.ExtendedRadioButton rbEyeSightCamera;
        private CustomControl.ExtendedRadioButton rbEyeSightCharacter;
        private Panel pnlEyeSightCamera;
        private ComboBox cbEyeSightCameraType;
        private CustomControl.ExtendedLabel lblEyeSightCameraType;
        private Panel pnlEyeSightCharacter;
        private FlowLayoutPanel flowLayoutPanel11;
        private Panel pnlEyeSightCharaPosition;
        private CustomControl.ExtendedLabel lblEyeSightCharacterIndexPosition;
        private ComboBox cbEyeSightCharaPosition;
        private Panel pnlEyeSightGroupMember;
        private CustomControl.ExtendedLabel lblGroupTarget;
        private ComboBox cbGroupTarget;
        private CustomControl.ExtendedLabel lblGroupPosition;
        private ComboBox cbGroupIndex;
        private FlowLayoutPanel flowLayoutPanel10;
        private ComboBox cbEyeSightCharacterType;
        private CustomControl.ExtendedLabel lblEyeSightCharacterType;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}