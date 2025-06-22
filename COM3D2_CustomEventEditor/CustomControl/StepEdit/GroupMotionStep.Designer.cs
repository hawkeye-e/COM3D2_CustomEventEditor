namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class GroupMotionStep
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
            gbCoordinates = new ExtendedGroupBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            pnlCoordinates = new Panel();
            txtCoordinatesRot = new CustomControls.RJControls.RJTextBox();
            lblCoordinatesRot = new ExtendedLabel();
            txtCoordinatesPos = new CustomControls.RJControls.RJTextBox();
            lblCoordinatesPos = new ExtendedLabel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            chkCoordinateChange = new ExtendedCheckBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbTarget = new ExtendedGroupBox();
            lblPosition = new ExtendedLabel();
            cbGroupIndex = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            gbMotion = new ExtendedGroupBox();
            txtScriptLabel = new CustomControls.RJControls.RJTextBox();
            chkBlockClick = new ExtendedCheckBox();
            lblScriptFile = new ExtendedLabel();
            lblMotionScriptLabel = new ExtendedLabel();
            txtScriptFile = new CustomControls.RJControls.RJTextBox();
            gbIndividual = new ExtendedGroupBox();
            lblInstruction = new ExtendedLabel();
            btnMan3Edit = new ExtendedButton();
            chkMan3Detail = new ExtendedCheckBox();
            btnMan2Edit = new ExtendedButton();
            chkMan2Detail = new ExtendedCheckBox();
            btnMan1Edit = new ExtendedButton();
            chkMan1Detail = new ExtendedCheckBox();
            btnMaid2Edit = new ExtendedButton();
            chkMaid2Detail = new ExtendedCheckBox();
            btnMaid1Edit = new ExtendedButton();
            chkMaid1Detail = new ExtendedCheckBox();
            gbCoordinates.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            pnlCoordinates.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            gbTarget.SuspendLayout();
            gbMotion.SuspendLayout();
            gbIndividual.SuspendLayout();
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
            lblHeader.TextResourceKey = "GroupMotionStepHeader";
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
            gbCoordinates.Location = new Point(3, 269);
            gbCoordinates.MinimumSize = new Size(267, 0);
            gbCoordinates.Name = "gbCoordinates";
            gbCoordinates.Size = new Size(267, 157);
            gbCoordinates.TabIndex = 4;
            gbCoordinates.TabStop = false;
            gbCoordinates.Text = "[Coordinates]";
            gbCoordinates.TextResourceKey = "GroupMotionCoordinatesGroupLabel";
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel5.Controls.Add(pnlCoordinates);
            flowLayoutPanel5.Location = new Point(6, 47);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(255, 89);
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
            pnlCoordinates.Size = new Size(249, 83);
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
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbTarget);
            flowLayoutPanel3.Controls.Add(gbCoordinates);
            flowLayoutPanel3.Controls.Add(gbMotion);
            flowLayoutPanel3.Controls.Add(gbIndividual);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 783);
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
            gbTarget.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbTarget.Controls.Add(lblPosition);
            gbTarget.Controls.Add(cbGroupIndex);
            gbTarget.Controls.Add(flowLayoutPanel1);
            gbTarget.FlatStyle = FlatStyle.Flat;
            gbTarget.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbTarget.Location = new Point(3, 213);
            gbTarget.Name = "gbTarget";
            gbTarget.Size = new Size(267, 50);
            gbTarget.TabIndex = 6;
            gbTarget.TabStop = false;
            gbTarget.Text = "[Target]";
            gbTarget.TextResourceKey = "GroupMotionStepTargetGroupLabel";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblPosition.Location = new Point(6, 18);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 15);
            lblPosition.TabIndex = 21;
            lblPosition.Text = "[Position]";
            lblPosition.TextResourceKey = "GroupMotionStepTargetPositionLabel";
            // 
            // cbGroupIndex
            // 
            cbGroupIndex.DisplayMember = "DisplayText";
            cbGroupIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroupIndex.FlatStyle = FlatStyle.Flat;
            cbGroupIndex.Font = new Font("Microsoft Sans Serif", 9F);
            cbGroupIndex.FormattingEnabled = true;
            cbGroupIndex.Location = new Point(143, 15);
            cbGroupIndex.Name = "cbGroupIndex";
            cbGroupIndex.Size = new Size(111, 23);
            cbGroupIndex.TabIndex = 20;
            cbGroupIndex.ValueMember = "DataKey";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 76);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // gbMotion
            // 
            gbMotion.AutoSize = true;
            gbMotion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbMotion.Controls.Add(txtScriptLabel);
            gbMotion.Controls.Add(chkBlockClick);
            gbMotion.Controls.Add(lblScriptFile);
            gbMotion.Controls.Add(lblMotionScriptLabel);
            gbMotion.Controls.Add(txtScriptFile);
            gbMotion.FlatStyle = FlatStyle.Flat;
            gbMotion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbMotion.Location = new Point(3, 432);
            gbMotion.MinimumSize = new Size(267, 0);
            gbMotion.Name = "gbMotion";
            gbMotion.Padding = new Padding(3, 3, 3, 0);
            gbMotion.Size = new Size(267, 136);
            gbMotion.TabIndex = 6;
            gbMotion.TabStop = false;
            gbMotion.Text = "[Motion]";
            gbMotion.TextResourceKey = "GroupMotionStepMotionGroupLabel";
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
            txtScriptLabel.Location = new Point(91, 61);
            txtScriptLabel.Margin = new Padding(4);
            txtScriptLabel.Multiline = false;
            txtScriptLabel.Name = "txtScriptLabel";
            txtScriptLabel.Padding = new Padding(7);
            txtScriptLabel.PasswordChar = false;
            txtScriptLabel.ReadOnly = false;
            txtScriptLabel.Size = new Size(167, 31);
            txtScriptLabel.TabIndex = 29;
            txtScriptLabel.Texts = "";
            txtScriptLabel.UnderlinedStyle = false;
            // 
            // chkBlockClick
            // 
            chkBlockClick.AutoSize = true;
            chkBlockClick.Font = new Font("Microsoft Sans Serif", 9F);
            chkBlockClick.Location = new Point(9, 99);
            chkBlockClick.Name = "chkBlockClick";
            chkBlockClick.Size = new Size(88, 19);
            chkBlockClick.TabIndex = 35;
            chkBlockClick.Text = "[BlockClick]";
            chkBlockClick.TextResourceKey = "GroupMotionStepBlockClickLabel";
            chkBlockClick.UseVisualStyleBackColor = true;
            // 
            // lblScriptFile
            // 
            lblScriptFile.AutoSize = true;
            lblScriptFile.Font = new Font("Microsoft Sans Serif", 9F);
            lblScriptFile.Location = new Point(6, 28);
            lblScriptFile.Name = "lblScriptFile";
            lblScriptFile.Size = new Size(64, 15);
            lblScriptFile.TabIndex = 26;
            lblScriptFile.Text = "[ScriptFile]";
            lblScriptFile.TextResourceKey = "ScriptFileLabel";
            // 
            // lblMotionScriptLabel
            // 
            lblMotionScriptLabel.AutoSize = true;
            lblMotionScriptLabel.Font = new Font("Microsoft Sans Serif", 9F);
            lblMotionScriptLabel.Location = new Point(6, 69);
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
            txtScriptFile.Location = new Point(91, 22);
            txtScriptFile.Margin = new Padding(4);
            txtScriptFile.Multiline = false;
            txtScriptFile.Name = "txtScriptFile";
            txtScriptFile.Padding = new Padding(7);
            txtScriptFile.PasswordChar = false;
            txtScriptFile.ReadOnly = false;
            txtScriptFile.Size = new Size(167, 31);
            txtScriptFile.TabIndex = 27;
            txtScriptFile.Texts = "";
            txtScriptFile.UnderlinedStyle = false;
            // 
            // gbIndividual
            // 
            gbIndividual.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbIndividual.Controls.Add(lblInstruction);
            gbIndividual.Controls.Add(btnMan3Edit);
            gbIndividual.Controls.Add(chkMan3Detail);
            gbIndividual.Controls.Add(btnMan2Edit);
            gbIndividual.Controls.Add(chkMan2Detail);
            gbIndividual.Controls.Add(btnMan1Edit);
            gbIndividual.Controls.Add(chkMan1Detail);
            gbIndividual.Controls.Add(btnMaid2Edit);
            gbIndividual.Controls.Add(chkMaid2Detail);
            gbIndividual.Controls.Add(btnMaid1Edit);
            gbIndividual.Controls.Add(chkMaid1Detail);
            gbIndividual.FlatStyle = FlatStyle.Flat;
            gbIndividual.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbIndividual.Location = new Point(3, 574);
            gbIndividual.MinimumSize = new Size(267, 0);
            gbIndividual.Name = "gbIndividual";
            gbIndividual.Padding = new Padding(3, 3, 3, 0);
            gbIndividual.Size = new Size(267, 206);
            gbIndividual.TabIndex = 7;
            gbIndividual.TabStop = false;
            gbIndividual.Text = "[IndividualSetup]";
            gbIndividual.TextResourceKey = "GroupMotionStepDetailSetupGroupLabel";
            // 
            // lblInstruction
            // 
            lblInstruction.Font = new Font("Microsoft Sans Serif", 9F);
            lblInstruction.Location = new Point(6, 18);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(252, 38);
            lblInstruction.TabIndex = 58;
            lblInstruction.Text = "[Instruction]";
            lblInstruction.TextResourceKey = "GroupMotionStepIndvSetupInstuctionLabel";
            // 
            // btnMan3Edit
            // 
            btnMan3Edit.FlatStyle = FlatStyle.Flat;
            btnMan3Edit.Font = new Font("Microsoft Sans Serif", 8F);
            btnMan3Edit.Location = new Point(183, 175);
            btnMan3Edit.Name = "btnMan3Edit";
            btnMan3Edit.Size = new Size(75, 23);
            btnMan3Edit.TabIndex = 57;
            btnMan3Edit.Text = "[Edit]";
            btnMan3Edit.TextResourceKey = "Edit";
            btnMan3Edit.UseVisualStyleBackColor = true;
            btnMan3Edit.Click += btnMan3Edit_Click;
            // 
            // chkMan3Detail
            // 
            chkMan3Detail.AutoSize = true;
            chkMan3Detail.Font = new Font("Microsoft Sans Serif", 9F);
            chkMan3Detail.Location = new Point(9, 177);
            chkMan3Detail.Name = "chkMan3Detail";
            chkMan3Detail.Size = new Size(64, 19);
            chkMan3Detail.TabIndex = 56;
            chkMan3Detail.Text = "[Man3]";
            chkMan3Detail.TextResourceKey = "GroupMemberTypeMan3";
            chkMan3Detail.UseVisualStyleBackColor = true;
            // 
            // btnMan2Edit
            // 
            btnMan2Edit.FlatStyle = FlatStyle.Flat;
            btnMan2Edit.Font = new Font("Microsoft Sans Serif", 8F);
            btnMan2Edit.Location = new Point(183, 146);
            btnMan2Edit.Name = "btnMan2Edit";
            btnMan2Edit.Size = new Size(75, 23);
            btnMan2Edit.TabIndex = 55;
            btnMan2Edit.Text = "[Edit]";
            btnMan2Edit.TextResourceKey = "Edit";
            btnMan2Edit.UseVisualStyleBackColor = true;
            btnMan2Edit.Click += btnMan2Edit_Click;
            // 
            // chkMan2Detail
            // 
            chkMan2Detail.AutoSize = true;
            chkMan2Detail.Font = new Font("Microsoft Sans Serif", 9F);
            chkMan2Detail.Location = new Point(9, 148);
            chkMan2Detail.Name = "chkMan2Detail";
            chkMan2Detail.Size = new Size(64, 19);
            chkMan2Detail.TabIndex = 54;
            chkMan2Detail.Text = "[Man2]";
            chkMan2Detail.TextResourceKey = "GroupMemberTypeMan2";
            chkMan2Detail.UseVisualStyleBackColor = true;
            // 
            // btnMan1Edit
            // 
            btnMan1Edit.FlatStyle = FlatStyle.Flat;
            btnMan1Edit.Font = new Font("Microsoft Sans Serif", 8F);
            btnMan1Edit.Location = new Point(183, 117);
            btnMan1Edit.Name = "btnMan1Edit";
            btnMan1Edit.Size = new Size(75, 23);
            btnMan1Edit.TabIndex = 53;
            btnMan1Edit.Text = "[Edit]";
            btnMan1Edit.TextResourceKey = "Edit";
            btnMan1Edit.UseVisualStyleBackColor = true;
            btnMan1Edit.Click += btnMan1Edit_Click;
            // 
            // chkMan1Detail
            // 
            chkMan1Detail.AutoSize = true;
            chkMan1Detail.Font = new Font("Microsoft Sans Serif", 9F);
            chkMan1Detail.Location = new Point(9, 119);
            chkMan1Detail.Name = "chkMan1Detail";
            chkMan1Detail.Size = new Size(64, 19);
            chkMan1Detail.TabIndex = 52;
            chkMan1Detail.Text = "[Man1]";
            chkMan1Detail.TextResourceKey = "GroupMemberTypeMan1";
            chkMan1Detail.UseVisualStyleBackColor = true;
            // 
            // btnMaid2Edit
            // 
            btnMaid2Edit.FlatStyle = FlatStyle.Flat;
            btnMaid2Edit.Font = new Font("Microsoft Sans Serif", 8F);
            btnMaid2Edit.Location = new Point(183, 88);
            btnMaid2Edit.Name = "btnMaid2Edit";
            btnMaid2Edit.Size = new Size(75, 23);
            btnMaid2Edit.TabIndex = 51;
            btnMaid2Edit.Text = "[Edit]";
            btnMaid2Edit.TextResourceKey = "Edit";
            btnMaid2Edit.UseVisualStyleBackColor = true;
            btnMaid2Edit.Click += btnMaid2Edit_Click;
            // 
            // chkMaid2Detail
            // 
            chkMaid2Detail.AutoSize = true;
            chkMaid2Detail.Font = new Font("Microsoft Sans Serif", 9F);
            chkMaid2Detail.Location = new Point(9, 90);
            chkMaid2Detail.Name = "chkMaid2Detail";
            chkMaid2Detail.Size = new Size(67, 19);
            chkMaid2Detail.TabIndex = 50;
            chkMaid2Detail.Text = "[Maid2]";
            chkMaid2Detail.TextResourceKey = "GroupMemberTypeMaid2";
            chkMaid2Detail.UseVisualStyleBackColor = true;
            // 
            // btnMaid1Edit
            // 
            btnMaid1Edit.FlatStyle = FlatStyle.Flat;
            btnMaid1Edit.Font = new Font("Microsoft Sans Serif", 8F);
            btnMaid1Edit.Location = new Point(183, 59);
            btnMaid1Edit.Name = "btnMaid1Edit";
            btnMaid1Edit.Size = new Size(75, 23);
            btnMaid1Edit.TabIndex = 49;
            btnMaid1Edit.Text = "[Edit]";
            btnMaid1Edit.TextResourceKey = "Edit";
            btnMaid1Edit.UseVisualStyleBackColor = true;
            btnMaid1Edit.Click += btnMaid1Edit_Click;
            // 
            // chkMaid1Detail
            // 
            chkMaid1Detail.AutoSize = true;
            chkMaid1Detail.Font = new Font("Microsoft Sans Serif", 9F);
            chkMaid1Detail.Location = new Point(9, 61);
            chkMaid1Detail.Name = "chkMaid1Detail";
            chkMaid1Detail.Size = new Size(67, 19);
            chkMaid1Detail.TabIndex = 30;
            chkMaid1Detail.Text = "[Maid1]";
            chkMaid1Detail.TextResourceKey = "GroupMemberTypeMaid1";
            chkMaid1Detail.UseVisualStyleBackColor = true;
            // 
            // GroupMotionStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "GroupMotionStep";
            Size = new Size(326, 1700);
            gbCoordinates.ResumeLayout(false);
            gbCoordinates.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            pnlCoordinates.ResumeLayout(false);
            pnlCoordinates.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            gbTarget.ResumeLayout(false);
            gbTarget.PerformLayout();
            gbMotion.ResumeLayout(false);
            gbMotion.PerformLayout();
            gbIndividual.ResumeLayout(false);
            gbIndividual.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedGroupBox gbCoordinates;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private ExtendedGroupBox gbTarget;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedLabel lblPosition;
        private ComboBox cbGroupIndex;
        private ExtendedCheckBox chkCoordinateChange;
        private FlowLayoutPanel flowLayoutPanel5;
        private Panel pnlCoordinates;
        private ExtendedLabel lblCoordinatesPos;
        private CustomControls.RJControls.RJTextBox txtCoordinatesPos;
        private CustomControls.RJControls.RJTextBox txtCoordinatesRot;
        private ExtendedLabel lblCoordinatesRot;
        private ExtendedGroupBox gbMotion;
        private CustomControls.RJControls.RJTextBox txtScriptLabel;
        private ExtendedLabel lblMotionScriptLabel;
        private CustomControls.RJControls.RJTextBox txtScriptFile;
        private ExtendedLabel lblScriptFile;
        private ExtendedGroupBox gbIndividual;
        private ExtendedCheckBox chkBlockClick;
        private ExtendedCheckBox chkMaid1Detail;
        private ExtendedButton btnMaid1Edit;
        private ExtendedButton btnMan3Edit;
        private ExtendedCheckBox chkMan3Detail;
        private ExtendedButton btnMan2Edit;
        private ExtendedCheckBox chkMan2Detail;
        private ExtendedButton btnMan1Edit;
        private ExtendedCheckBox chkMan1Detail;
        private ExtendedButton btnMaid2Edit;
        private ExtendedCheckBox chkMaid2Detail;
        private ExtendedLabel lblInstruction;
    }
}
