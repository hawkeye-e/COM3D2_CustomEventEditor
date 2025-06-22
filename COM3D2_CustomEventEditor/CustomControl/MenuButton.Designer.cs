namespace COM3D2_CustomEventEditor
{
    partial class MenuButton
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
            pbIcon.BackgroundImage = Properties.Resources.menu_new;
            pbIcon.BackgroundImageLayout = ImageLayout.Stretch;
            pbIcon.Location = new Point(34, 9);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(32, 32);
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;
            pbIcon.MouseEnter += AddStepButton_MouseHover;
            pbIcon.MouseLeave += AddStepButton_MouseLeave;
            // 
            // lblText
            // 
            lblText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(0, 44);
            lblText.Name = "lblText";
            lblText.Size = new Size(100, 20);
            lblText.TabIndex = 1;
            lblText.Text = "New";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            lblText.MouseEnter += AddStepButton_MouseHover;
            lblText.MouseLeave += AddStepButton_MouseLeave;
            // 
            // MenuButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 77);
            Controls.Add(pbIcon);
            Controls.Add(lblText);
            Margin = new Padding(0);
            Name = "MenuButton";
            Size = new Size(100, 64);
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
