namespace COM3D2_CustomEventEditor
{
    partial class StepItem
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
            lblStepName = new Label();
            pbTypeIcon = new PictureBox();
            rbStepLink = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pbTypeIcon).BeginInit();
            SuspendLayout();
            // 
            // lblStepName
            // 
            lblStepName.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold);
            lblStepName.Location = new Point(27, 0);
            lblStepName.Name = "lblStepName";
            lblStepName.Size = new Size(150, 34);
            lblStepName.TabIndex = 0;
            lblStepName.Text = "some random text";
            lblStepName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbTypeIcon
            // 
            pbTypeIcon.BackgroundImage = Properties.Resources.person_black;
            pbTypeIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pbTypeIcon.Location = new Point(3, 4);
            pbTypeIcon.Name = "pbTypeIcon";
            pbTypeIcon.Size = new Size(24, 24);
            pbTypeIcon.TabIndex = 2;
            pbTypeIcon.TabStop = false;
            // 
            // rbStepLink
            // 
            rbStepLink.AutoSize = true;
            rbStepLink.FlatStyle = FlatStyle.Flat;
            rbStepLink.Location = new Point(83, 46);
            rbStepLink.Name = "rbStepLink";
            rbStepLink.Size = new Size(13, 12);
            rbStepLink.TabIndex = 3;
            rbStepLink.TabStop = true;
            rbStepLink.UseVisualStyleBackColor = false;
            rbStepLink.MouseUp += rbStepLink_MouseUp;
            // 
            // StepItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(rbStepLink);
            Controls.Add(pbTypeIcon);
            Controls.Add(lblStepName);
            Name = "StepItem";
            Size = new Size(180, 62);
            Load += StepItem_Load;
            ((System.ComponentModel.ISupportInitialize)pbTypeIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStepName;
        private PictureBox pbTypeIcon;
        private RadioButton rbStepLink;
    }
}
