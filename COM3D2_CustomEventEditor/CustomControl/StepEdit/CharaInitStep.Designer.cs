namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class CharaInitStep
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
            gbManSetting = new ExtendedGroupBox();
            chkManTypeShota = new ExtendedCheckBox();
            chkManTypeOtaku = new ExtendedCheckBox();
            chkManTypeMiddleAged = new ExtendedCheckBox();
            chkManTypeYanki = new ExtendedCheckBox();
            chkManTypeYoungMan = new ExtendedCheckBox();
            lblManCount = new ExtendedLabel();
            cbManCount = new ComboBox();
            gbNPC = new ExtendedGroupBox();
            btnEditNPCMale = new ExtendedButton();
            lblMaleNPCCount = new ExtendedLabel();
            lblMaleNPC = new ExtendedLabel();
            lblFemaleNPCCount = new ExtendedLabel();
            btnEditNPCFemale = new ExtendedButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblFemaleNPC = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbManSetting.SuspendLayout();
            gbNPC.SuspendLayout();
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
            lblHeader.TextResourceKey = "CharaInitStepHeader";
            // 
            // gbManSetting
            // 
            gbManSetting.AutoSize = true;
            gbManSetting.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbManSetting.Controls.Add(chkManTypeShota);
            gbManSetting.Controls.Add(chkManTypeOtaku);
            gbManSetting.Controls.Add(chkManTypeMiddleAged);
            gbManSetting.Controls.Add(chkManTypeYanki);
            gbManSetting.Controls.Add(chkManTypeYoungMan);
            gbManSetting.Controls.Add(lblManCount);
            gbManSetting.Controls.Add(cbManCount);
            gbManSetting.FlatStyle = FlatStyle.Flat;
            gbManSetting.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbManSetting.Location = new Point(3, 213);
            gbManSetting.Name = "gbManSetting";
            gbManSetting.Size = new Size(267, 180);
            gbManSetting.TabIndex = 3;
            gbManSetting.TabStop = false;
            gbManSetting.Text = "[Man Setting]";
            gbManSetting.TextResourceKey = "CharaInitStepManSettingGroupLabel";
            // 
            // chkManTypeShota
            // 
            chkManTypeShota.AutoSize = true;
            chkManTypeShota.Font = new Font("Microsoft Sans Serif", 9F);
            chkManTypeShota.Location = new Point(6, 140);
            chkManTypeShota.Name = "chkManTypeShota";
            chkManTypeShota.Size = new Size(64, 19);
            chkManTypeShota.TabIndex = 29;
            chkManTypeShota.Text = "[Shota]";
            chkManTypeShota.TextResourceKey = "CharaInitStepManTypeShota";
            chkManTypeShota.UseVisualStyleBackColor = true;
            // 
            // chkManTypeOtaku
            // 
            chkManTypeOtaku.AutoSize = true;
            chkManTypeOtaku.Font = new Font("Microsoft Sans Serif", 9F);
            chkManTypeOtaku.Location = new Point(6, 119);
            chkManTypeOtaku.Name = "chkManTypeOtaku";
            chkManTypeOtaku.Size = new Size(64, 19);
            chkManTypeOtaku.TabIndex = 28;
            chkManTypeOtaku.Text = "[Otaku]";
            chkManTypeOtaku.TextResourceKey = "CharaInitStepManTypeOtaku";
            chkManTypeOtaku.UseVisualStyleBackColor = true;
            // 
            // chkManTypeMiddleAged
            // 
            chkManTypeMiddleAged.AutoSize = true;
            chkManTypeMiddleAged.Font = new Font("Microsoft Sans Serif", 9F);
            chkManTypeMiddleAged.Location = new Point(6, 98);
            chkManTypeMiddleAged.Name = "chkManTypeMiddleAged";
            chkManTypeMiddleAged.Size = new Size(98, 19);
            chkManTypeMiddleAged.TabIndex = 27;
            chkManTypeMiddleAged.Text = "[MiddleAged]";
            chkManTypeMiddleAged.TextResourceKey = "CharaInitStepManTypeMiddleAged";
            chkManTypeMiddleAged.UseVisualStyleBackColor = true;
            // 
            // chkManTypeYanki
            // 
            chkManTypeYanki.AutoSize = true;
            chkManTypeYanki.Font = new Font("Microsoft Sans Serif", 9F);
            chkManTypeYanki.Location = new Point(6, 77);
            chkManTypeYanki.Name = "chkManTypeYanki";
            chkManTypeYanki.Size = new Size(62, 19);
            chkManTypeYanki.TabIndex = 26;
            chkManTypeYanki.Text = "[Yanki]";
            chkManTypeYanki.TextResourceKey = "CharaInitStepManTypeYanki";
            chkManTypeYanki.UseVisualStyleBackColor = true;
            // 
            // chkManTypeYoungMan
            // 
            chkManTypeYoungMan.AutoSize = true;
            chkManTypeYoungMan.Font = new Font("Microsoft Sans Serif", 9F);
            chkManTypeYoungMan.Location = new Point(6, 56);
            chkManTypeYoungMan.Name = "chkManTypeYoungMan";
            chkManTypeYoungMan.Size = new Size(92, 19);
            chkManTypeYoungMan.TabIndex = 25;
            chkManTypeYoungMan.Text = "[YoungMan]";
            chkManTypeYoungMan.TextResourceKey = "CharaInitStepManTypeYoungMan";
            chkManTypeYoungMan.UseVisualStyleBackColor = true;
            // 
            // lblManCount
            // 
            lblManCount.AutoSize = true;
            lblManCount.Font = new Font("Microsoft Sans Serif", 9F);
            lblManCount.ForeColor = SystemColors.ControlText;
            lblManCount.Location = new Point(6, 29);
            lblManCount.Name = "lblManCount";
            lblManCount.Size = new Size(73, 15);
            lblManCount.TabIndex = 22;
            lblManCount.Text = "[Man Count]";
            lblManCount.TextResourceKey = "CharaInitManCountLabel";
            // 
            // cbManCount
            // 
            cbManCount.DropDownStyle = ComboBoxStyle.DropDownList;
            cbManCount.FlatStyle = FlatStyle.Flat;
            cbManCount.Font = new Font("Microsoft Sans Serif", 9F);
            cbManCount.FormattingEnabled = true;
            cbManCount.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbManCount.Location = new Point(150, 26);
            cbManCount.Name = "cbManCount";
            cbManCount.Size = new Size(111, 23);
            cbManCount.TabIndex = 20;
            // 
            // gbNPC
            // 
            gbNPC.Controls.Add(btnEditNPCMale);
            gbNPC.Controls.Add(lblMaleNPCCount);
            gbNPC.Controls.Add(lblMaleNPC);
            gbNPC.Controls.Add(lblFemaleNPCCount);
            gbNPC.Controls.Add(btnEditNPCFemale);
            gbNPC.Controls.Add(flowLayoutPanel2);
            gbNPC.Controls.Add(lblFemaleNPC);
            gbNPC.FlatStyle = FlatStyle.Flat;
            gbNPC.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbNPC.Location = new Point(3, 399);
            gbNPC.Name = "gbNPC";
            gbNPC.Size = new Size(267, 120);
            gbNPC.TabIndex = 4;
            gbNPC.TabStop = false;
            gbNPC.Text = "[NPC]";
            gbNPC.TextResourceKey = "CharaInitStepNPCGroupLabel";
            // 
            // btnEditNPCMale
            // 
            btnEditNPCMale.FlatStyle = FlatStyle.Flat;
            btnEditNPCMale.Font = new Font("Microsoft Sans Serif", 8F);
            btnEditNPCMale.Location = new Point(186, 47);
            btnEditNPCMale.Name = "btnEditNPCMale";
            btnEditNPCMale.Size = new Size(75, 23);
            btnEditNPCMale.TabIndex = 35;
            btnEditNPCMale.Text = "[Edit]";
            btnEditNPCMale.TextResourceKey = "Edit";
            btnEditNPCMale.UseVisualStyleBackColor = true;
            btnEditNPCMale.Click += btnEditNPCMale_Click;
            // 
            // lblMaleNPCCount
            // 
            lblMaleNPCCount.AutoSize = true;
            lblMaleNPCCount.Font = new Font("Microsoft Sans Serif", 9F);
            lblMaleNPCCount.ForeColor = SystemColors.ControlText;
            lblMaleNPCCount.Location = new Point(150, 50);
            lblMaleNPCCount.Name = "lblMaleNPCCount";
            lblMaleNPCCount.Size = new Size(14, 15);
            lblMaleNPCCount.TabIndex = 34;
            lblMaleNPCCount.Text = "0";
            lblMaleNPCCount.TextAlign = ContentAlignment.TopRight;
            lblMaleNPCCount.TextResourceKey = "";
            // 
            // lblMaleNPC
            // 
            lblMaleNPC.AutoSize = true;
            lblMaleNPC.Font = new Font("Microsoft Sans Serif", 9F);
            lblMaleNPC.ForeColor = SystemColors.ControlText;
            lblMaleNPC.Location = new Point(6, 50);
            lblMaleNPC.Name = "lblMaleNPC";
            lblMaleNPC.Size = new Size(94, 15);
            lblMaleNPC.TabIndex = 33;
            lblMaleNPC.Text = "[NoOfMaleNPC]";
            lblMaleNPC.TextResourceKey = "CharaInitMaleNPCCountLabel";
            // 
            // lblFemaleNPCCount
            // 
            lblFemaleNPCCount.AutoSize = true;
            lblFemaleNPCCount.Font = new Font("Microsoft Sans Serif", 9F);
            lblFemaleNPCCount.ForeColor = SystemColors.ControlText;
            lblFemaleNPCCount.Location = new Point(150, 21);
            lblFemaleNPCCount.Name = "lblFemaleNPCCount";
            lblFemaleNPCCount.Size = new Size(14, 15);
            lblFemaleNPCCount.TabIndex = 32;
            lblFemaleNPCCount.Text = "0";
            lblFemaleNPCCount.TextAlign = ContentAlignment.TopRight;
            lblFemaleNPCCount.TextResourceKey = "";
            // 
            // btnEditNPCFemale
            // 
            btnEditNPCFemale.FlatStyle = FlatStyle.Flat;
            btnEditNPCFemale.Font = new Font("Microsoft Sans Serif", 8F);
            btnEditNPCFemale.Location = new Point(186, 18);
            btnEditNPCFemale.Name = "btnEditNPCFemale";
            btnEditNPCFemale.Size = new Size(75, 23);
            btnEditNPCFemale.TabIndex = 30;
            btnEditNPCFemale.Text = "[Edit]";
            btnEditNPCFemale.TextResourceKey = "Edit";
            btnEditNPCFemale.UseVisualStyleBackColor = true;
            btnEditNPCFemale.Click += btnEditNPC_Click;
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
            // lblFemaleNPC
            // 
            lblFemaleNPC.AutoSize = true;
            lblFemaleNPC.Font = new Font("Microsoft Sans Serif", 9F);
            lblFemaleNPC.ForeColor = SystemColors.ControlText;
            lblFemaleNPC.Location = new Point(6, 21);
            lblFemaleNPC.Name = "lblFemaleNPC";
            lblFemaleNPC.Size = new Size(108, 15);
            lblFemaleNPC.TabIndex = 31;
            lblFemaleNPC.Text = "[NoOfFemaleNPC]";
            lblFemaleNPC.TextResourceKey = "CharaInitFemaleNPCCountLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbManSetting);
            flowLayoutPanel3.Controls.Add(gbNPC);
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
            // CharaInitStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "CharaInitStep";
            Size = new Size(324, 1043);
            gbManSetting.ResumeLayout(false);
            gbManSetting.PerformLayout();
            gbNPC.ResumeLayout(false);
            gbNPC.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbManSetting;
        private ComboBox cbSpeakerType;
        private ComboBox cbManCount;
        private ExtendedLabel lblManCount;
        private ExtendedGroupBox gbNPC;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private ExtendedButton btnEditNPCFemale;
        private BasicStepInfo ucBasicStepInfo;
        private ExtendedCheckBox chkManTypeYoungMan;
        private ExtendedCheckBox chkManTypeYanki;
        private ExtendedCheckBox chkManTypeMiddleAged;
        private ExtendedCheckBox chkManTypeOtaku;
        private ExtendedCheckBox chkManTypeShota;
        private ExtendedLabel lblFemaleNPCCount;
        private ExtendedLabel lblFemaleNPC;
        private ExtendedLabel lblMaleNPC;
        private ExtendedLabel lblMaleNPCCount;
        private ExtendedButton btnEditNPCMale;
    }
}
