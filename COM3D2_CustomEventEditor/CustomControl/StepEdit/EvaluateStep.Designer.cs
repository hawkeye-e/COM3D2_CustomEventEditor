namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class EvaluateStep
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
            flowLayoutPanel3 = new FlowLayoutPanel();
            ucBasicStepInfo = new BasicStepInfo();
            gbOperation = new ExtendedGroupBox();
            txtResultVariable = new CustomControls.RJControls.RJTextBox();
            lblResultVariable = new ExtendedLabel();
            cbOperation = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lblOperationType = new ExtendedLabel();
            ucInput1 = new EvaluateInput();
            ucInput2 = new EvaluateInput();
            flowLayoutPanel3.SuspendLayout();
            gbOperation.SuspendLayout();
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
            lblHeader.TextResourceKey = "EvaluateStepHeader";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel3.Controls.Add(ucBasicStepInfo);
            flowLayoutPanel3.Controls.Add(gbOperation);
            flowLayoutPanel3.Controls.Add(ucInput1);
            flowLayoutPanel3.Controls.Add(ucInput2);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(3, 46);
            flowLayoutPanel3.Margin = new Padding(3, 3, 3, 13);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(284, 1260);
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
            // gbOperation
            // 
            gbOperation.AutoSize = true;
            gbOperation.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbOperation.Controls.Add(txtResultVariable);
            gbOperation.Controls.Add(lblResultVariable);
            gbOperation.Controls.Add(cbOperation);
            gbOperation.Controls.Add(flowLayoutPanel2);
            gbOperation.Controls.Add(lblOperationType);
            gbOperation.FlatStyle = FlatStyle.Flat;
            gbOperation.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Bold);
            gbOperation.Location = new Point(3, 213);
            gbOperation.Name = "gbOperation";
            gbOperation.Size = new Size(268, 134);
            gbOperation.TabIndex = 49;
            gbOperation.TabStop = false;
            gbOperation.Text = "[Operation]";
            gbOperation.TextResourceKey = "EvaluateStepOperationGroupLabel";
            // 
            // txtResultVariable
            // 
            txtResultVariable.AutoScroll = true;
            txtResultVariable.BackColor = SystemColors.Window;
            txtResultVariable.BorderColor = Color.FromArgb(66, 124, 244);
            txtResultVariable.BorderFocusColor = Color.HotPink;
            txtResultVariable.BorderSize = 2;
            txtResultVariable.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResultVariable.ForeColor = Color.Black;
            txtResultVariable.Location = new Point(13, 81);
            txtResultVariable.Margin = new Padding(4);
            txtResultVariable.Multiline = false;
            txtResultVariable.Name = "txtResultVariable";
            txtResultVariable.Padding = new Padding(7);
            txtResultVariable.PasswordChar = false;
            txtResultVariable.ReadOnly = false;
            txtResultVariable.Size = new Size(248, 31);
            txtResultVariable.TabIndex = 26;
            txtResultVariable.Texts = "";
            txtResultVariable.UnderlinedStyle = false;
            // 
            // lblResultVariable
            // 
            lblResultVariable.AutoSize = true;
            lblResultVariable.Font = new Font("Microsoft Sans Serif", 9F);
            lblResultVariable.Location = new Point(13, 62);
            lblResultVariable.Name = "lblResultVariable";
            lblResultVariable.Size = new Size(127, 15);
            lblResultVariable.TabIndex = 22;
            lblResultVariable.Text = "[ResultVariableName]";
            lblResultVariable.TextResourceKey = "EvaluateStepResultVariableLabel";
            // 
            // cbOperation
            // 
            cbOperation.DisplayMember = "DisplayText";
            cbOperation.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOperation.FlatStyle = FlatStyle.Flat;
            cbOperation.Font = new Font("Microsoft Sans Serif", 9F);
            cbOperation.FormattingEnabled = true;
            cbOperation.Location = new Point(13, 36);
            cbOperation.Name = "cbOperation";
            cbOperation.Size = new Size(248, 23);
            cbOperation.TabIndex = 21;
            cbOperation.ValueMember = "DataKey";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(6, 76);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(0, 0);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // lblOperationType
            // 
            lblOperationType.AutoSize = true;
            lblOperationType.Font = new Font("Microsoft Sans Serif", 9F);
            lblOperationType.Location = new Point(13, 18);
            lblOperationType.Name = "lblOperationType";
            lblOperationType.Size = new Size(39, 15);
            lblOperationType.TabIndex = 20;
            lblOperationType.Text = "[Type]";
            lblOperationType.TextResourceKey = "EvaluateStepOperationTypeLabel";
            // 
            // ucInput1
            // 
            ucInput1.AutoSize = true;
            ucInput1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucInput1.Location = new Point(3, 353);
            ucInput1.Name = "ucInput1";
            ucInput1.Size = new Size(270, 449);
            ucInput1.TabIndex = 50;
            // 
            // ucInput2
            // 
            ucInput2.AutoSize = true;
            ucInput2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucInput2.Location = new Point(3, 808);
            ucInput2.Name = "ucInput2";
            ucInput2.Size = new Size(270, 449);
            ucInput2.TabIndex = 51;
            // 
            // EvaluateStep
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(flowLayoutPanel3);
            Controls.Add(lblHeader);
            Name = "EvaluateStep";
            Size = new Size(506, 1319);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            gbOperation.ResumeLayout(false);
            gbOperation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblSpeaker;
        private ComboBox cbSpeakerType;
        private FlowLayoutPanel flowLayoutPanel3;
        private BasicStepInfo ucBasicStepInfo;
        private FlowLayoutPanel flowLayoutPanel2;
        private ExtendedLabel lblRemoveObjectInstructionLabel;
        private ExtendedGroupBox gbOperation;
        private ComboBox cbOperation;
        private ExtendedLabel lblOperationType;
        private ExtendedLabel lblResultVariable;
        private CustomControls.RJControls.RJTextBox txtResultVariable;
        private EvaluateInput ucInput1;
        private EvaluateInput ucInput2;
    }
}
