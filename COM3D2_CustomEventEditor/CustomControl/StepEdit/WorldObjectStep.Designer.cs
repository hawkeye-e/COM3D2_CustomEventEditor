namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class WorldObjectStep
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
            gbWorldObject = new ExtendedGroupBox();
            flowLayoutPanel4 = new FlowLayoutPanel();
            lblWorldObjectType = new ExtendedLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbAddObjects = new ExtendedRadioButton();
            rbRemoveObjects = new ExtendedRadioButton();
            pnlAddObjects = new Panel();
            lblAddObjectCountValue = new ExtendedLabel();
            btnAddObjects = new ExtendedButton();
            lblAddObjectCount = new ExtendedLabel();
            pnlRemoveObjects = new Panel();
            txtRemoveObjects = new CustomControls.RJControls.RJTextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblRemoveObjectInstructionLabel = new ExtendedLabel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbWorldObject.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pnlAddObjects.SuspendLayout();
            pnlRemoveObjects.SuspendLayout();
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
            lblHeader.TextResourceKey = "WorldObjectStepHeader";
            // 
            // gbWorldObject
            // 
            gbWorldObject.AutoSize = true;
            gbWorldObject.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbWorldObject.Controls.Add(flowLayoutPanel4);
            gbWorldObject.FlatStyle = FlatStyle.Flat;
            gbWorldObject.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbWorldObject.Location = new Point(3, 213);
            gbWorldObject.MinimumSize = new Size(267, 0);
            gbWorldObject.Name = "gbWorldObject";
            gbWorldObject.Size = new Size(267, 354);
            gbWorldObject.TabIndex = 3;
            gbWorldObject.TabStop = false;
            gbWorldObject.Text = "[GroupMgmt]";
            gbWorldObject.TextResourceKey = "WorldObjectStepGroupLabel";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel4.Controls.Add(lblWorldObjectType);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel1);
            flowLayoutPanel4.Controls.Add(pnlAddObjects);
            flowLayoutPanel4.Controls.Add(pnlRemoveObjects);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(6, 21);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(253, 312);
            flowLayoutPanel4.TabIndex = 48;
            // 
            // lblWorldObjectType
            // 
            lblWorldObjectType.AutoSize = true;
            lblWorldObjectType.Font = new Font("Microsoft Sans Serif", 9F);
            lblWorldObjectType.ForeColor = SystemColors.ControlText;
            lblWorldObjectType.Location = new Point(3, 0);
            lblWorldObjectType.Name = "lblWorldObjectType";
            lblWorldObjectType.Size = new Size(39, 15);
            lblWorldObjectType.TabIndex = 40;
            lblWorldObjectType.Text = "[Type]";
            lblWorldObjectType.TextResourceKey = "WorldObjectStepTypeLabel";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(rbAddObjects);
            flowLayoutPanel1.Controls.Add(rbRemoveObjects);
            flowLayoutPanel1.Location = new Point(3, 18);
            flowLayoutPanel1.MaximumSize = new Size(254, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(223, 25);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // rbAddObjects
            // 
            rbAddObjects.AutoSize = true;
            rbAddObjects.Checked = true;
            rbAddObjects.Font = new Font("Microsoft Sans Serif", 9F);
            rbAddObjects.Location = new Point(3, 3);
            rbAddObjects.Name = "rbAddObjects";
            rbAddObjects.Size = new Size(93, 19);
            rbAddObjects.TabIndex = 30;
            rbAddObjects.TabStop = true;
            rbAddObjects.Text = "[AddObjects]";
            rbAddObjects.TextResourceKey = "WorldObjectStepAddObjectsLabel";
            rbAddObjects.UseVisualStyleBackColor = true;
            rbAddObjects.CheckedChanged += rbAddObjects_CheckedChanged;
            // 
            // rbRemoveObjects
            // 
            rbRemoveObjects.AutoSize = true;
            rbRemoveObjects.Font = new Font("Microsoft Sans Serif", 9F);
            rbRemoveObjects.Location = new Point(102, 3);
            rbRemoveObjects.Name = "rbRemoveObjects";
            rbRemoveObjects.Size = new Size(118, 19);
            rbRemoveObjects.TabIndex = 31;
            rbRemoveObjects.Text = "[RemoveObjects]";
            rbRemoveObjects.TextResourceKey = "WorldObjectStepRemoveObjectsLabel";
            rbRemoveObjects.UseVisualStyleBackColor = true;
            rbRemoveObjects.CheckedChanged += rbRemoveObject_CheckedChanged;
            // 
            // pnlAddObjects
            // 
            pnlAddObjects.Controls.Add(lblAddObjectCountValue);
            pnlAddObjects.Controls.Add(btnAddObjects);
            pnlAddObjects.Controls.Add(lblAddObjectCount);
            pnlAddObjects.Location = new Point(3, 49);
            pnlAddObjects.Name = "pnlAddObjects";
            pnlAddObjects.Size = new Size(247, 39);
            pnlAddObjects.TabIndex = 45;
            // 
            // lblAddObjectCountValue
            // 
            lblAddObjectCountValue.AutoSize = true;
            lblAddObjectCountValue.Font = new Font("Microsoft Sans Serif", 9F);
            lblAddObjectCountValue.ForeColor = SystemColors.ControlText;
            lblAddObjectCountValue.Location = new Point(149, 11);
            lblAddObjectCountValue.Name = "lblAddObjectCountValue";
            lblAddObjectCountValue.Size = new Size(14, 15);
            lblAddObjectCountValue.TabIndex = 49;
            lblAddObjectCountValue.Text = "0";
            lblAddObjectCountValue.TextResourceKey = "";
            // 
            // btnAddObjects
            // 
            btnAddObjects.FlatStyle = FlatStyle.Flat;
            btnAddObjects.Font = new Font("Microsoft Sans Serif", 8F);
            btnAddObjects.Location = new Point(169, 8);
            btnAddObjects.Name = "btnAddObjects";
            btnAddObjects.Size = new Size(75, 23);
            btnAddObjects.TabIndex = 48;
            btnAddObjects.Text = "[Edit]";
            btnAddObjects.TextResourceKey = "Edit";
            btnAddObjects.UseVisualStyleBackColor = true;
            btnAddObjects.Click += btnAddObjects_Click;
            // 
            // lblAddObjectCount
            // 
            lblAddObjectCount.AutoSize = true;
            lblAddObjectCount.Font = new Font("Microsoft Sans Serif", 9F);
            lblAddObjectCount.ForeColor = SystemColors.ControlText;
            lblAddObjectCount.Location = new Point(3, 11);
            lblAddObjectCount.Name = "lblAddObjectCount";
            lblAddObjectCount.Size = new Size(111, 15);
            lblAddObjectCount.TabIndex = 42;
            lblAddObjectCount.Text = "[NumberOfObjects]";
            lblAddObjectCount.TextResourceKey = "WorldObjectStepAddObjectCountLabel";
            // 
            // pnlRemoveObjects
            // 
            pnlRemoveObjects.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlRemoveObjects.Controls.Add(txtRemoveObjects);
            pnlRemoveObjects.Controls.Add(flowLayoutPanel2);
            pnlRemoveObjects.Controls.Add(lblRemoveObjectInstructionLabel);
            pnlRemoveObjects.Location = new Point(3, 94);
            pnlRemoveObjects.Name = "pnlRemoveObjects";
            pnlRemoveObjects.Size = new Size(247, 215);
            pnlRemoveObjects.TabIndex = 44;
            // 
            // txtRemoveObjects
            // 
            txtRemoveObjects.BackColor = SystemColors.Window;
            txtRemoveObjects.BorderColor = Color.FromArgb(66, 124, 244);
            txtRemoveObjects.BorderFocusColor = Color.HotPink;
            txtRemoveObjects.BorderSize = 2;
            txtRemoveObjects.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRemoveObjects.ForeColor = Color.Black;
            txtRemoveObjects.Location = new Point(3, 51);
            txtRemoveObjects.Margin = new Padding(16, 4, 4, 4);
            txtRemoveObjects.Multiline = true;
            txtRemoveObjects.Name = "txtRemoveObjects";
            txtRemoveObjects.Padding = new Padding(7);
            txtRemoveObjects.PasswordChar = false;
            txtRemoveObjects.ReadOnly = false;
            txtRemoveObjects.Size = new Size(240, 151);
            txtRemoveObjects.TabIndex = 52;
            txtRemoveObjects.Texts = "";
            txtRemoveObjects.UnderlinedStyle = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Location = new Point(3, 29);
            flowLayoutPanel2.MaximumSize = new Size(254, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 51;
            // 
            // lblRemoveObjectInstructionLabel
            // 
            lblRemoveObjectInstructionLabel.Font = new Font("Microsoft Sans Serif", 9F);
            lblRemoveObjectInstructionLabel.ForeColor = SystemColors.ControlText;
            lblRemoveObjectInstructionLabel.Location = new Point(3, 11);
            lblRemoveObjectInstructionLabel.Name = "lblRemoveObjectInstructionLabel";
            lblRemoveObjectInstructionLabel.Size = new Size(241, 36);
            lblRemoveObjectInstructionLabel.TabIndex = 44;
            lblRemoveObjectInstructionLabel.Text = "[RemoveObjects]";
            lblRemoveObjectInstructionLabel.TextResourceKey = "WorldObjectStepRemoveObjectInstructionLabel";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbWorldObject);
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
            // WorldObjectStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "WorldObjectStep";
            Size = new Size(324, 1043);
            gbWorldObject.ResumeLayout(false);
            gbWorldObject.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            pnlAddObjects.ResumeLayout(false);
            pnlAddObjects.PerformLayout();
            pnlRemoveObjects.ResumeLayout(false);
            pnlRemoveObjects.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ExtendedGroupBox gbWorldObject;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private FlowLayoutPanel flowLayoutPanel4;
        private ExtendedLabel lblWorldObjectType;
        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedRadioButton rbAddObjects;
        private ExtendedRadioButton rbRemoveObjects;
        private ExtendedLabel lblAddObjectCount;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pnlRemoveObjects;
        private ExtendedLabel lblRemoveObjectInstructionLabel;
        private ExtendedButton btnAddObjects;
        private Panel pnlAddObjects;
        private ExtendedLabel lblAddObjectCountValue;
        private CustomControls.RJControls.RJTextBox txtRemoveObjects;
    }
}
