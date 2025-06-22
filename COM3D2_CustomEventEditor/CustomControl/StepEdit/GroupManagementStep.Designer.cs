namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class GroupManagementStep
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
            lblGroupMgmtType = new ExtendedLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbMakeGroup = new ExtendedRadioButton();
            rbDismissGroup = new ExtendedRadioButton();
            pnlMakeGroup = new Panel();
            lblMakeGroupCountValue = new ExtendedLabel();
            btnMakeGroup = new ExtendedButton();
            lblMakeGroupCount = new ExtendedLabel();
            pnlDismissGroup = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            rbDismissAll = new ExtendedRadioButton();
            rbDismissByGroupIndex = new ExtendedRadioButton();
            lblDismissGroupLabel = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            pnlByIndex = new Panel();
            lblPosition = new ExtendedLabel();
            cbListIndex = new ComboBox();
            gbFading.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlMakeGroup.SuspendLayout();
            pnlDismissGroup.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            pnlByIndex.SuspendLayout();
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
            lblHeader.TextResourceKey = "GroupManagementStepHeader";
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
            gbFading.Size = new Size(267, 302);
            gbFading.TabIndex = 3;
            gbFading.TabStop = false;
            gbFading.Text = "[GroupMgmt]";
            gbFading.TextResourceKey = "GroupManagementStepGroupLabel";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(lblGroupMgmtType);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.Controls.Add(pnlMakeGroup);
            flowLayoutPanel4.Controls.Add(pnlDismissGroup);
            flowLayoutPanel4.Controls.Add(pnlByIndex);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(6, 21);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(253, 260);
            flowLayoutPanel4.TabIndex = 48;
            // 
            // lblGroupMgmtType
            // 
            lblGroupMgmtType.AutoSize = true;
            lblGroupMgmtType.Font = new Font("Microsoft Sans Serif", 9F);
            lblGroupMgmtType.ForeColor = SystemColors.ControlText;
            lblGroupMgmtType.Location = new Point(3, 0);
            lblGroupMgmtType.Name = "lblGroupMgmtType";
            lblGroupMgmtType.Size = new Size(39, 15);
            lblGroupMgmtType.TabIndex = 40;
            lblGroupMgmtType.Text = "[Type]";
            lblGroupMgmtType.TextResourceKey = "GroupManagementStepTypeLabel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(rbMakeGroup);
            flowLayoutPanel1.Controls.Add(rbDismissGroup);
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.MaximumSize = new Size(254, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(217, 25);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // rbMakeGroup
            // 
            rbMakeGroup.AutoSize = true;
            rbMakeGroup.Checked = true;
            rbMakeGroup.Font = new Font("Microsoft Sans Serif", 9F);
            rbMakeGroup.Location = new Point(3, 3);
            rbMakeGroup.Name = "rbMakeGroup";
            rbMakeGroup.Size = new Size(96, 19);
            rbMakeGroup.TabIndex = 30;
            rbMakeGroup.TabStop = true;
            rbMakeGroup.Text = "[MakeGroup]";
            rbMakeGroup.TextResourceKey = "GroupManagementStepMakeGroupLabel";
            rbMakeGroup.UseVisualStyleBackColor = true;
            rbMakeGroup.CheckedChanged += rbMakeGroup_CheckedChanged;
            // 
            // rbDismissGroup
            // 
            rbDismissGroup.AutoSize = true;
            rbDismissGroup.Font = new Font("Microsoft Sans Serif", 9F);
            rbDismissGroup.Location = new Point(105, 3);
            rbDismissGroup.Name = "rbDismissGroup";
            rbDismissGroup.Size = new Size(109, 19);
            rbDismissGroup.TabIndex = 31;
            rbDismissGroup.Text = "[DismissGroup]";
            rbDismissGroup.TextResourceKey = "GroupManagementStepDismissGroupLabel";
            rbDismissGroup.UseVisualStyleBackColor = true;
            rbDismissGroup.CheckedChanged += rbDismissGroup_CheckedChanged;
            // 
            // pnlMakeGroup
            // 
            pnlMakeGroup.Controls.Add(lblMakeGroupCountValue);
            pnlMakeGroup.Controls.Add(btnMakeGroup);
            pnlMakeGroup.Controls.Add(lblMakeGroupCount);
            pnlMakeGroup.Location = new Point(3, 49);
            pnlMakeGroup.Name = "pnlMakeGroup";
            pnlMakeGroup.Size = new Size(247, 39);
            pnlMakeGroup.TabIndex = 45;
            // 
            // lblMakeGroupCountValue
            // 
            lblMakeGroupCountValue.AutoSize = true;
            lblMakeGroupCountValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblMakeGroupCountValue.ForeColor = SystemColors.ControlText;
            lblMakeGroupCountValue.Location = new Point(149, 11);
            lblMakeGroupCountValue.Name = "lblMakeGroupCountValue";
            lblMakeGroupCountValue.Size = new Size(14, 15);
            lblMakeGroupCountValue.TabIndex = 49;
            lblMakeGroupCountValue.Text = "0";
            lblMakeGroupCountValue.TextResourceKey = "";
            // 
            // btnMakeGroup
            // 
            btnMakeGroup.FlatStyle = FlatStyle.Flat;
            btnMakeGroup.Font = new Font("Microsoft Sans Serif", 8F);
            btnMakeGroup.Location = new Point(169, 8);
            btnMakeGroup.Name = "btnMakeGroup";
            btnMakeGroup.Size = new Size(75, 23);
            btnMakeGroup.TabIndex = 48;
            btnMakeGroup.Text = "[Edit]";
            btnMakeGroup.TextResourceKey = "Edit";
            btnMakeGroup.UseVisualStyleBackColor = true;
            btnMakeGroup.Click += btnMakeGroup_Click;
            // 
            // lblMakeGroupCount
            // 
            lblMakeGroupCount.AutoSize = true;
            lblMakeGroupCount.Font = new Font("Microsoft Sans Serif", 9F);
            lblMakeGroupCount.ForeColor = SystemColors.ControlText;
            lblMakeGroupCount.Location = new Point(3, 11);
            lblMakeGroupCount.Name = "lblMakeGroupCount";
            lblMakeGroupCount.Size = new Size(110, 15);
            lblMakeGroupCount.TabIndex = 42;
            lblMakeGroupCount.Text = "[NumberOfGroups]";
            lblMakeGroupCount.TextResourceKey = "GroupManagementStepMakeGroupCountLabel";
            // 
            // pnlDismissGroup
            // 
            pnlDismissGroup.AutoSize = true;
            pnlDismissGroup.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlDismissGroup.Controls.Add(flowLayoutPanel2);
            pnlDismissGroup.Controls.Add(lblDismissGroupLabel);
            pnlDismissGroup.Location = new Point(3, 94);
            pnlDismissGroup.Name = "pnlDismissGroup";
            pnlDismissGroup.Size = new Size(170, 57);
            pnlDismissGroup.TabIndex = 44;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(rbDismissAll);
            flowLayoutPanel2.Controls.Add(rbDismissByGroupIndex);
            flowLayoutPanel2.Location = new Point(3, 29);
            flowLayoutPanel2.MaximumSize = new Size(254, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(164, 25);
            flowLayoutPanel2.TabIndex = 51;
            // 
            // rbDismissAll
            // 
            rbDismissAll.AutoSize = true;
            rbDismissAll.Checked = true;
            rbDismissAll.Font = new Font("Microsoft Sans Serif", 9F);
            rbDismissAll.Location = new Point(3, 3);
            rbDismissAll.Name = "rbDismissAll";
            rbDismissAll.Size = new Size(44, 19);
            rbDismissAll.TabIndex = 32;
            rbDismissAll.TabStop = true;
            rbDismissAll.Text = "[All]";
            rbDismissAll.TextResourceKey = "GroupManagementStepDismissAllLabel";
            rbDismissAll.UseVisualStyleBackColor = true;
            rbDismissAll.CheckedChanged += rbDismissAll_CheckedChanged;
            // 
            // rbDismissByGroupIndex
            // 
            rbDismissByGroupIndex.AutoSize = true;
            rbDismissByGroupIndex.Font = new Font("Microsoft Sans Serif", 9F);
            rbDismissByGroupIndex.Location = new Point(53, 3);
            rbDismissByGroupIndex.Name = "rbDismissByGroupIndex";
            rbDismissByGroupIndex.Size = new Size(108, 19);
            rbDismissByGroupIndex.TabIndex = 31;
            rbDismissByGroupIndex.Text = "[ByGroupIndex]";
            rbDismissByGroupIndex.TextResourceKey = "GroupManagementStepDismissGroupByIndexLabel";
            rbDismissByGroupIndex.UseVisualStyleBackColor = true;
            rbDismissByGroupIndex.CheckedChanged += rbDismissByGroupIndex_CheckedChanged;
            // 
            // lblDismissGroupLabel
            // 
            lblDismissGroupLabel.AutoSize = true;
            lblDismissGroupLabel.Font = new Font("Microsoft Sans Serif", 9F);
            lblDismissGroupLabel.ForeColor = SystemColors.ControlText;
            lblDismissGroupLabel.Location = new Point(3, 11);
            lblDismissGroupLabel.Name = "lblDismissGroupLabel";
            lblDismissGroupLabel.Size = new Size(91, 15);
            lblDismissGroupLabel.TabIndex = 44;
            lblDismissGroupLabel.Text = "[DismissGroup]";
            lblDismissGroupLabel.TextResourceKey = "GroupManagementStepDismissGroupTypeLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbFading);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 658);
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
            // pnlByIndex
            // 
            pnlByIndex.Controls.Add(lblPosition);
            pnlByIndex.Controls.Add(cbListIndex);
            pnlByIndex.Location = new Point(3, 157);
            pnlByIndex.Name = "pnlByIndex";
            pnlByIndex.Size = new Size(244, 100);
            pnlByIndex.TabIndex = 46;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Microsoft Sans Serif", 9F);
            lblPosition.Location = new Point(3, 6);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(57, 15);
            lblPosition.TabIndex = 23;
            lblPosition.Text = "[Position]";
            lblPosition.TextResourceKey = "GroupManagementStepListPositionLabel";
            // 
            // cbListIndex
            // 
            cbListIndex.DisplayMember = "Value";
            cbListIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListIndex.FlatStyle = FlatStyle.Flat;
            cbListIndex.Font = new Font("Microsoft Sans Serif", 9F);
            cbListIndex.FormattingEnabled = true;
            cbListIndex.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            cbListIndex.Location = new Point(130, 3);
            cbListIndex.Name = "cbListIndex";
            cbListIndex.Size = new Size(111, 23);
            cbListIndex.TabIndex = 22;
            cbListIndex.ValueMember = "Key";
            // 
            // GroupManagementStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "GroupManagementStep";
            Size = new Size(324, 1043);
            gbFading.ResumeLayout(false);
            gbFading.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlMakeGroup.ResumeLayout(false);
            pnlMakeGroup.PerformLayout();
            pnlDismissGroup.ResumeLayout(false);
            pnlDismissGroup.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            pnlByIndex.ResumeLayout(false);
            pnlByIndex.PerformLayout();
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
        private ExtendedLabel lblGroupMgmtType;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedRadioButton rbMakeGroup;
        private ExtendedRadioButton rbDismissGroup;
        private ExtendedLabel lblMakeGroupCount;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnlDismissGroup;
        private ExtendedLabel lblDismissGroupLabel;
        private ExtendedButton btnMakeGroup;
        private Panel pnlMakeGroup;
        private ExtendedLabel lblMakeGroupCountValue;
        private ExtendedRadioButton rbDismissAll;
        private ExtendedRadioButton rbDismissByGroupIndex;
        private Panel pnlByIndex;
        private ExtendedLabel lblPosition;
        private ComboBox cbListIndex;
    }
}
