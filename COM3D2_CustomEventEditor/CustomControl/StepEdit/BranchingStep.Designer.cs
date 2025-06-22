namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class BranchingStep
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
            gbBranching = new ExtendedGroupBox();
            lblBranchCountValue = new ExtendedLabel();
            btnEditBranch = new ExtendedButton();
            lblBranchCount = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbBranching.SuspendLayout();
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
            lblHeader.TextResourceKey = "BranchingStepHeader";
            // 
            // gbBranching
            // 
            gbBranching.AutoSize = true;
            gbBranching.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbBranching.Controls.Add(lblBranchCountValue);
            gbBranching.Controls.Add(btnEditBranch);
            gbBranching.Controls.Add(lblBranchCount);
            gbBranching.FlatStyle = FlatStyle.Flat;
            gbBranching.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbBranching.Location = new Point(3, 213);
            gbBranching.MinimumSize = new Size(267, 0);
            gbBranching.Name = "gbBranching";
            gbBranching.Size = new Size(267, 70);
            gbBranching.TabIndex = 3;
            gbBranching.TabStop = false;
            gbBranching.Text = "[ShowOption]";
            gbBranching.TextResourceKey = "BranchingStepGroupLabel";
            // 
            // lblBranchCountValue
            // 
            lblBranchCountValue.AutoSize = true;
            lblBranchCountValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblBranchCountValue.ForeColor = SystemColors.ControlText;
            lblBranchCountValue.Location = new Point(150, 29);
            lblBranchCountValue.Name = "lblBranchCountValue";
            lblBranchCountValue.Size = new Size(14, 15);
            lblBranchCountValue.TabIndex = 35;
            lblBranchCountValue.Text = "0";
            lblBranchCountValue.TextAlign = ContentAlignment.TopRight;
            lblBranchCountValue.TextResourceKey = "";
            // 
            // btnEditBranch
            // 
            btnEditBranch.FlatStyle = FlatStyle.Flat;
            btnEditBranch.Font = new Font("Microsoft Sans Serif", 8F);
            btnEditBranch.Location = new Point(186, 26);
            btnEditBranch.Name = "btnEditBranch";
            btnEditBranch.Size = new Size(75, 23);
            btnEditBranch.TabIndex = 33;
            btnEditBranch.Text = "[Edit]";
            btnEditBranch.TextResourceKey = "Edit";
            btnEditBranch.UseVisualStyleBackColor = true;
            btnEditBranch.Click += btnEditBranch_Click;
            // 
            // lblBranchCount
            // 
            lblBranchCount.AutoSize = true;
            lblBranchCount.Font = new Font("Microsoft Sans Serif", 9F);
            lblBranchCount.ForeColor = SystemColors.ControlText;
            lblBranchCount.Location = new Point(6, 29);
            lblBranchCount.Name = "lblBranchCount";
            lblBranchCount.Size = new Size(77, 15);
            lblBranchCount.TabIndex = 34;
            lblBranchCount.Text = "[NoOfOption]";
            lblBranchCount.TextResourceKey = "BranchStepBranchCountLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbBranching);
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
            // BranchingStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "BranchingStep";
            Size = new Size(324, 1043);
            gbBranching.ResumeLayout(false);
            gbBranching.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbBranching;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private ExtendedLabel lblVariableName;
        private ExtendedLabel lblBranchCountValue;
        private ExtendedButton btnEditBranch;
        private ExtendedLabel lblBranchCount;
    }
}
