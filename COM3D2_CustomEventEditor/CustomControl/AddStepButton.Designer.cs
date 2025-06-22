namespace COM3D2_CustomEventEditor
{
    partial class AddStepButton
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
            pbIcon = new PictureBox();
            lblText = new Label();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            SuspendLayout();
            // 
            // pbIcon
            // 
            pbIcon.BackgroundImage = Properties.Resources.person;
            pbIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pbIcon.Location = new Point(18, 9);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(24, 24);
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            pbIcon.MouseEnter += AddStepButton_MouseHover;
            pbIcon.MouseLeave += AddStepButton_MouseLeave;
            // 
            // lblText
            // 
            lblText.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(57, -1);
            lblText.Name = "lblText";
            lblText.Size = new Size(154, 42);
            lblText.TabIndex = 1;
            lblText.Text = "Character Step";
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.MouseEnter += AddStepButton_MouseHover;
            lblText.MouseLeave += AddStepButton_MouseLeave;
            // 
            // AddStepButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 77);
            Controls.Add(pbIcon);
            Controls.Add(lblText);
            Name = "AddStepButton";
            Size = new Size(212, 42);
            MouseEnter += AddStepButton_MouseHover;
            MouseLeave += AddStepButton_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbIcon;
        private Label lblText;
    }
}
