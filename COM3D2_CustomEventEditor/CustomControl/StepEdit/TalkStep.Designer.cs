namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class TalkStep
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
            lblSpeaker = new ExtendedLabel();
            gbSpeaker = new ExtendedGroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlPosition = new Panel();
            chkUseBranchIndex = new ExtendedCheckBox();
            lblPosition = new ExtendedLabel();
            cbListIndex = new ComboBox();
            pnlInputName = new Panel();
            lblSpeakerName = new ExtendedLabel();
            txtSpeakerName = new CustomControls.RJControls.RJTextBox();
            cbSpeakerType = new ComboBox();
            gbVoice = new ExtendedGroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pnlIndividualVoice = new Panel();
            cbPersonality = new ComboBox();
            lblTalkStepVoicePersonality = new ExtendedLabel();
            lblVolumeValue = new Label();
            tbVolume = new TrackBar();
            lblVolume = new ExtendedLabel();
            txtAudioEnd = new CustomControls.RJControls.RJTextBox();
            lblAudioEnd = new ExtendedLabel();
            lblAudioStart = new ExtendedLabel();
            txtAudioStart = new CustomControls.RJControls.RJTextBox();
            lblAudioCropping = new ExtendedLabel();
            lblVoiceFile = new ExtendedLabel();
            txtVoiceFile = new CustomControls.RJControls.RJTextBox();
            pnlAllVoice = new Panel();
            btnAllVoice = new ExtendedButton();
            lvlAllVoice = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbDialogueText = new ExtendedGroupBox();
            txtTalkText = new CustomControls.RJControls.RJTextBox();
            gbSpeaker.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlPosition.SuspendLayout();
            pnlInputName.SuspendLayout();
            gbVoice.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            pnlIndividualVoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbVolume).BeginInit();
            pnlAllVoice.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            gbDialogueText.SuspendLayout();
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
            lblHeader.TextResourceKey = "TalkStepHeader";
            // 
            // lblSpeaker
            // 
            lblSpeaker.AutoSize = true;
            lblSpeaker.Font = new Font("Microsoft Sans Serif", 9F);
            lblSpeaker.Location = new Point(13, 29);
            lblSpeaker.Name = "lblSpeaker";
            lblSpeaker.Size = new Size(39, 15);
            lblSpeaker.TabIndex = 2;
            lblSpeaker.Text = "[Type]";
            lblSpeaker.TextResourceKey = "TalkStepSpeakerTypeLabel";
            // 
            // gbSpeaker
            // 
            gbSpeaker.AutoSize = true;
            gbSpeaker.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbSpeaker.Controls.Add(flowLayoutPanel1);
            gbSpeaker.Controls.Add(cbSpeakerType);
            gbSpeaker.Controls.Add(lblSpeaker);
            gbSpeaker.FlatStyle = FlatStyle.Flat;
            gbSpeaker.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbSpeaker.Location = new Point(3, 213);
            gbSpeaker.Name = "gbSpeaker";
            gbSpeaker.Size = new Size(267, 218);
            gbSpeaker.TabIndex = 3;
            gbSpeaker.TabStop = false;
            gbSpeaker.Text = "[Speaker]";
            gbSpeaker.TextResourceKey = "TalkStepSpeakerGroupLabel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(pnlPosition);
            flowLayoutPanel1.Controls.Add(pnlInputName);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(6, 76);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 124);
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
            chkUseBranchIndex.CheckedChanged += chkUseBranchIndex_CheckedChanged;
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
            // pnlInputName
            // 
            pnlInputName.Controls.Add(lblSpeakerName);
            pnlInputName.Controls.Add(txtSpeakerName);
            pnlInputName.Location = new Point(3, 65);
            pnlInputName.Name = "pnlInputName";
            pnlInputName.Size = new Size(252, 56);
            pnlInputName.TabIndex = 24;
            // 
            // lblSpeakerName
            // 
            lblSpeakerName.AutoSize = true;
            lblSpeakerName.Font = new Font("Microsoft Sans Serif", 9F);
            lblSpeakerName.ForeColor = SystemColors.ControlText;
            lblSpeakerName.Location = new Point(4, 0);
            lblSpeakerName.Name = "lblSpeakerName";
            lblSpeakerName.Size = new Size(93, 15);
            lblSpeakerName.TabIndex = 22;
            lblSpeakerName.Text = "[SpeakerName]";
            lblSpeakerName.TextResourceKey = "TalkStepSpeakerNameLabel";
            // 
            // txtSpeakerName
            // 
            txtSpeakerName.AutoScroll = true;
            txtSpeakerName.BackColor = SystemColors.Window;
            txtSpeakerName.BorderColor = Color.FromArgb(66, 124, 244);
            txtSpeakerName.BorderFocusColor = Color.HotPink;
            txtSpeakerName.BorderSize = 2;
            txtSpeakerName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSpeakerName.ForeColor = Color.Black;
            txtSpeakerName.Location = new Point(4, 19);
            txtSpeakerName.Margin = new Padding(4);
            txtSpeakerName.Multiline = false;
            txtSpeakerName.Name = "txtSpeakerName";
            txtSpeakerName.Padding = new Padding(7);
            txtSpeakerName.PasswordChar = false;
            txtSpeakerName.ReadOnly = false;
            txtSpeakerName.Size = new Size(248, 31);
            txtSpeakerName.TabIndex = 9;
            txtSpeakerName.Texts = "";
            txtSpeakerName.UnderlinedStyle = false;
            // 
            // cbSpeakerType
            // 
            cbSpeakerType.DisplayMember = "DisplayText";
            cbSpeakerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSpeakerType.FlatStyle = FlatStyle.Flat;
            cbSpeakerType.Font = new Font("Microsoft Sans Serif", 9F);
            cbSpeakerType.FormattingEnabled = true;
            cbSpeakerType.Location = new Point(13, 47);
            cbSpeakerType.Name = "cbSpeakerType";
            cbSpeakerType.Size = new Size(248, 23);
            cbSpeakerType.TabIndex = 19;
            cbSpeakerType.ValueMember = "DataKey";
            cbSpeakerType.SelectedIndexChanged += cbSpeakerType_SelectedIndexChanged;
            // 
            // gbVoice
            // 
            gbVoice.AutoSize = true;
            gbVoice.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbVoice.Controls.Add(flowLayoutPanel2);
            gbVoice.FlatStyle = FlatStyle.Flat;
            gbVoice.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbVoice.Location = new Point(3, 639);
            gbVoice.Name = "gbVoice";
            gbVoice.Size = new Size(270, 352);
            gbVoice.TabIndex = 4;
            gbVoice.TabStop = false;
            gbVoice.Text = "[Voice]";
            gbVoice.TextResourceKey = "TalkStepVoiceGroupLabel";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(pnlIndividualVoice);
            flowLayoutPanel2.Controls.Add(pnlAllVoice);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 21);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(264, 313);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // pnlIndividualVoice
            // 
            pnlIndividualVoice.Controls.Add(cbPersonality);
            pnlIndividualVoice.Controls.Add(lblTalkStepVoicePersonality);
            pnlIndividualVoice.Controls.Add(lblVolumeValue);
            pnlIndividualVoice.Controls.Add(tbVolume);
            pnlIndividualVoice.Controls.Add(lblVolume);
            pnlIndividualVoice.Controls.Add(txtAudioEnd);
            pnlIndividualVoice.Controls.Add(lblAudioEnd);
            pnlIndividualVoice.Controls.Add(lblAudioStart);
            pnlIndividualVoice.Controls.Add(txtAudioStart);
            pnlIndividualVoice.Controls.Add(lblAudioCropping);
            pnlIndividualVoice.Controls.Add(lblVoiceFile);
            pnlIndividualVoice.Controls.Add(txtVoiceFile);
            pnlIndividualVoice.Location = new Point(3, 3);
            pnlIndividualVoice.Name = "pnlIndividualVoice";
            pnlIndividualVoice.Size = new Size(258, 245);
            pnlIndividualVoice.TabIndex = 23;
            // 
            // cbPersonality
            // 
            cbPersonality.DisplayMember = "DisplayText";
            cbPersonality.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPersonality.FlatStyle = FlatStyle.Flat;
            cbPersonality.Font = new Font("Microsoft Sans Serif", 9F);
            cbPersonality.FormattingEnabled = true;
            cbPersonality.Location = new Point(7, 22);
            cbPersonality.Name = "cbPersonality";
            cbPersonality.Size = new Size(248, 23);
            cbPersonality.TabIndex = 31;
            cbPersonality.ValueMember = "DataKey";
            // 
            // lblTalkStepVoicePersonality
            // 
            lblTalkStepVoicePersonality.AutoSize = true;
            lblTalkStepVoicePersonality.Font = new Font("Microsoft Sans Serif", 9F);
            lblTalkStepVoicePersonality.Location = new Point(7, 0);
            lblTalkStepVoicePersonality.Name = "lblTalkStepVoicePersonality";
            lblTalkStepVoicePersonality.Size = new Size(73, 15);
            lblTalkStepVoicePersonality.TabIndex = 30;
            lblTalkStepVoicePersonality.Text = "[Personality]";
            lblTalkStepVoicePersonality.TextResourceKey = "TalkStepVoicePersonalityLabel";
            // 
            // lblVolumeValue
            // 
            lblVolumeValue.AutoSize = true;
            lblVolumeValue.Location = new Point(219, 205);
            lblVolumeValue.Name = "lblVolumeValue";
            lblVolumeValue.Size = new Size(31, 16);
            lblVolumeValue.TabIndex = 29;
            lblVolumeValue.Text = "100";
            // 
            // tbVolume
            // 
            tbVolume.Location = new Point(7, 195);
            tbVolume.Maximum = 100;
            tbVolume.Name = "tbVolume";
            tbVolume.Size = new Size(214, 45);
            tbVolume.TabIndex = 28;
            tbVolume.TickFrequency = 10;
            tbVolume.Value = 100;
            tbVolume.Scroll += tbVolume_Scroll;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Microsoft Sans Serif", 9F);
            lblVolume.Location = new Point(7, 176);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(55, 15);
            lblVolume.TabIndex = 27;
            lblVolume.Text = "[Volume]";
            lblVolume.TextResourceKey = "TalkStepAudioVolumeLabel";
            // 
            // txtAudioEnd
            // 
            txtAudioEnd.AutoScroll = true;
            txtAudioEnd.BackColor = SystemColors.Window;
            txtAudioEnd.BorderColor = Color.FromArgb(66, 124, 244);
            txtAudioEnd.BorderFocusColor = Color.HotPink;
            txtAudioEnd.BorderSize = 2;
            txtAudioEnd.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAudioEnd.ForeColor = Color.Black;
            txtAudioEnd.Location = new Point(110, 141);
            txtAudioEnd.Margin = new Padding(4);
            txtAudioEnd.Multiline = false;
            txtAudioEnd.Name = "txtAudioEnd";
            txtAudioEnd.Padding = new Padding(7);
            txtAudioEnd.PasswordChar = false;
            txtAudioEnd.ReadOnly = false;
            txtAudioEnd.Size = new Size(57, 31);
            txtAudioEnd.TabIndex = 26;
            txtAudioEnd.Texts = "";
            txtAudioEnd.UnderlinedStyle = false;
            txtAudioEnd.Validating += txtAudioEnd_Validating;
            // 
            // lblAudioEnd
            // 
            lblAudioEnd.AutoSize = true;
            lblAudioEnd.Font = new Font("Microsoft Sans Serif", 9F);
            lblAudioEnd.Location = new Point(110, 122);
            lblAudioEnd.Name = "lblAudioEnd";
            lblAudioEnd.Size = new Size(94, 15);
            lblAudioEnd.TabIndex = 25;
            lblAudioEnd.Text = "[AudioEndTime]";
            lblAudioEnd.TextResourceKey = "TalkStepAudioEndTimeLabel";
            // 
            // lblAudioStart
            // 
            lblAudioStart.AutoSize = true;
            lblAudioStart.Font = new Font("Microsoft Sans Serif", 9F);
            lblAudioStart.Location = new Point(7, 122);
            lblAudioStart.Name = "lblAudioStart";
            lblAudioStart.Size = new Size(97, 15);
            lblAudioStart.TabIndex = 24;
            lblAudioStart.Text = "[AudioStartTime]";
            lblAudioStart.TextResourceKey = "TalkStepAudioStartTimeLabel";
            // 
            // txtAudioStart
            // 
            txtAudioStart.AutoScroll = true;
            txtAudioStart.BackColor = SystemColors.Window;
            txtAudioStart.BorderColor = Color.FromArgb(66, 124, 244);
            txtAudioStart.BorderFocusColor = Color.HotPink;
            txtAudioStart.BorderSize = 2;
            txtAudioStart.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAudioStart.ForeColor = Color.Black;
            txtAudioStart.Location = new Point(7, 141);
            txtAudioStart.Margin = new Padding(4);
            txtAudioStart.Multiline = false;
            txtAudioStart.Name = "txtAudioStart";
            txtAudioStart.Padding = new Padding(7);
            txtAudioStart.PasswordChar = false;
            txtAudioStart.ReadOnly = false;
            txtAudioStart.Size = new Size(57, 31);
            txtAudioStart.TabIndex = 23;
            txtAudioStart.Texts = "";
            txtAudioStart.UnderlinedStyle = false;
            txtAudioStart.Validating += txtAudioStart_Validating;
            // 
            // lblAudioCropping
            // 
            lblAudioCropping.AutoSize = true;
            lblAudioCropping.Font = new Font("Microsoft Sans Serif", 9F);
            lblAudioCropping.Location = new Point(7, 102);
            lblAudioCropping.Name = "lblAudioCropping";
            lblAudioCropping.Size = new Size(94, 15);
            lblAudioCropping.TabIndex = 22;
            lblAudioCropping.Text = "[AudioCropping]";
            lblAudioCropping.TextResourceKey = "TalkStepAudioCroppingLabel";
            // 
            // lblVoiceFile
            // 
            lblVoiceFile.AutoSize = true;
            lblVoiceFile.Font = new Font("Microsoft Sans Serif", 9F);
            lblVoiceFile.Location = new Point(7, 48);
            lblVoiceFile.Name = "lblVoiceFile";
            lblVoiceFile.Size = new Size(63, 15);
            lblVoiceFile.TabIndex = 21;
            lblVoiceFile.Text = "[VoiceFile]";
            lblVoiceFile.TextResourceKey = "TalkStepVoiceFileLabel";
            // 
            // txtVoiceFile
            // 
            txtVoiceFile.AutoScroll = true;
            txtVoiceFile.BackColor = SystemColors.Window;
            txtVoiceFile.BorderColor = Color.FromArgb(66, 124, 244);
            txtVoiceFile.BorderFocusColor = Color.HotPink;
            txtVoiceFile.BorderSize = 2;
            txtVoiceFile.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVoiceFile.ForeColor = Color.Black;
            txtVoiceFile.Location = new Point(7, 67);
            txtVoiceFile.Margin = new Padding(4);
            txtVoiceFile.Multiline = false;
            txtVoiceFile.Name = "txtVoiceFile";
            txtVoiceFile.Padding = new Padding(7);
            txtVoiceFile.PasswordChar = false;
            txtVoiceFile.ReadOnly = false;
            txtVoiceFile.Size = new Size(248, 31);
            txtVoiceFile.TabIndex = 9;
            txtVoiceFile.Texts = "";
            txtVoiceFile.UnderlinedStyle = false;
            // 
            // pnlAllVoice
            // 
            pnlAllVoice.Controls.Add(btnAllVoice);
            pnlAllVoice.Controls.Add(lvlAllVoice);
            pnlAllVoice.Location = new Point(3, 254);
            pnlAllVoice.Name = "pnlAllVoice";
            pnlAllVoice.Size = new Size(258, 56);
            pnlAllVoice.TabIndex = 24;
            // 
            // btnAllVoice
            // 
            btnAllVoice.FlatStyle = FlatStyle.Flat;
            btnAllVoice.Font = new Font("Microsoft Sans Serif", 8F);
            btnAllVoice.Location = new Point(7, 18);
            btnAllVoice.Name = "btnAllVoice";
            btnAllVoice.Size = new Size(75, 23);
            btnAllVoice.TabIndex = 30;
            btnAllVoice.Text = "[Edit]";
            btnAllVoice.TextResourceKey = "Edit";
            btnAllVoice.UseVisualStyleBackColor = true;
            // 
            // lvlAllVoice
            // 
            lvlAllVoice.AutoSize = true;
            lvlAllVoice.Font = new Font("Microsoft Sans Serif", 9F);
            lvlAllVoice.Location = new Point(4, 0);
            lvlAllVoice.Name = "lvlAllVoice";
            lvlAllVoice.Size = new Size(56, 15);
            lvlAllVoice.TabIndex = 22;
            lvlAllVoice.Text = "[AllVoice]";
            lvlAllVoice.TextResourceKey = "TalkStepVoiceAllFileLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbSpeaker);
            flowLayoutPanel3.Controls.Add(gbDialogueText);
            flowLayoutPanel3.Controls.Add(gbVoice);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 994);
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
            // gbDialogueText
            // 
            gbDialogueText.AutoSize = true;
            gbDialogueText.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbDialogueText.Controls.Add(txtTalkText);
            gbDialogueText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbDialogueText.Location = new Point(3, 437);
            gbDialogueText.Name = "gbDialogueText";
            gbDialogueText.Size = new Size(268, 196);
            gbDialogueText.TabIndex = 25;
            gbDialogueText.TabStop = false;
            gbDialogueText.Text = "[Text]";
            gbDialogueText.TextResourceKey = "TalkStepTalkTextLabel";
            // 
            // txtTalkText
            // 
            txtTalkText.BackColor = SystemColors.Window;
            txtTalkText.BorderColor = Color.FromArgb(66, 124, 244);
            txtTalkText.BorderFocusColor = Color.HotPink;
            txtTalkText.BorderSize = 2;
            txtTalkText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTalkText.ForeColor = Color.Black;
            txtTalkText.Location = new Point(13, 23);
            txtTalkText.Margin = new Padding(16, 4, 4, 4);
            txtTalkText.Multiline = true;
            txtTalkText.Name = "txtTalkText";
            txtTalkText.Padding = new Padding(7);
            txtTalkText.PasswordChar = false;
            txtTalkText.ReadOnly = false;
            txtTalkText.Size = new Size(248, 151);
            txtTalkText.TabIndex = 24;
            txtTalkText.Texts = "";
            txtTalkText.UnderlinedStyle = false;
            // 
            // TalkStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "TalkStep";
            Size = new Size(324, 1043);
            gbSpeaker.ResumeLayout(false);
            gbSpeaker.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            pnlPosition.ResumeLayout(false);
            pnlPosition.PerformLayout();
            pnlInputName.ResumeLayout(false);
            pnlInputName.PerformLayout();
            gbVoice.ResumeLayout(false);
            gbVoice.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            pnlIndividualVoice.ResumeLayout(false);
            pnlIndividualVoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbVolume).EndInit();
            pnlAllVoice.ResumeLayout(false);
            pnlAllVoice.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            gbDialogueText.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbSpeaker;
        private ComboBox cbSpeakerType;
        private ComboBox cbListIndex;
        private ExtendedLabel lblPosition;
        private ExtendedLabel lblSpeakerName;
        private CustomControls.RJControls.RJTextBox txtSpeakerName;
        private Panel pnlInputName;
        private Panel pnlPosition;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedGroupBox gbVoice;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnlIndividualVoice;
        private ExtendedLabel lblVoiceFile;
        private Panel pnlAllVoice;
        private ExtendedLabel lvlAllVoice;
        private CustomControls.RJControls.RJTextBox txtVoiceFile;
        private FlowLayoutPanel flowLayoutPanel3;
        private ExtendedLabel lblAudioCropping;
        private ExtendedLabel lblAudioStart;
        private CustomControls.RJControls.RJTextBox txtAudioStart;
        private ExtendedLabel lblVolume;
        private CustomControls.RJControls.RJTextBox txtAudioEnd;
        private ExtendedLabel lblAudioEnd;
        private TrackBar tbVolume;
        private Label lblVolumeValue;
        private ExtendedButton btnAllVoice;
        private CustomControls.RJControls.RJTextBox txtTalkText;
        private ExtendedGroupBox gbDialogueText;
        private BasicStepInfo ucBasicStepInfo;
        private ExtendedCheckBox chkUseBranchIndex;
        private ExtendedLabel lblTalkStepVoicePersonality;
        private ComboBox cbPersonality;
    }
}
