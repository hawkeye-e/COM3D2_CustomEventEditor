using System.Security.Authentication;

namespace COM3D2_CustomEventEditor.CustomControl.StepEdit
{
    partial class ScenarioInfo
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
            lblTitle = new ExtendedLabel();
            txtTitle = new CustomControls.RJControls.RJTextBox();
            txtEventContent = new CustomControls.RJControls.RJTextBox();
            lblEventContent = new ExtendedLabel();
            txtAuthor = new CustomControls.RJControls.RJTextBox();
            lblAuthor = new ExtendedLabel();
            txtLanguage = new CustomControls.RJControls.RJTextBox();
            lblLanguage = new ExtendedLabel();
            lblIcon = new ExtendedLabel();
            rbIconLove = new RadioButton();
            panel1 = new Panel();
            rbIconExtra = new RadioButton();
            rbIconIdol = new RadioButton();
            rbIconNTR = new RadioButton();
            rbIconNPC = new RadioButton();
            lblMaidRequirement = new ExtendedLabel();
            btnMaidRequirement = new ExtendedButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.Location = new Point(3, 12);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(78, 20);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "[Header]";
            lblHeader.TextResourceKey = "ScnInfoHeader";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 9F);
            lblTitle.Location = new Point(3, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(36, 15);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "[Title]";
            lblTitle.TextResourceKey = "ScnInfoTitleLabel";
            // 
            // txtTitle
            // 
            txtTitle.AutoScroll = true;
            txtTitle.BackColor = SystemColors.Window;
            txtTitle.BorderColor = Color.FromArgb(66, 124, 244);
            txtTitle.BorderFocusColor = Color.HotPink;
            txtTitle.BorderSize = 2;
            txtTitle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.Black;
            txtTitle.Location = new Point(4, 70);
            txtTitle.Margin = new Padding(4);
            txtTitle.Multiline = false;
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(7);
            txtTitle.PasswordChar = false;
            txtTitle.Size = new Size(299, 31);
            txtTitle.TabIndex = 4;
            txtTitle.Texts = "";
            txtTitle.UnderlinedStyle = false;
            // 
            // txtEventContent
            // 
            txtEventContent.BackColor = SystemColors.Window;
            txtEventContent.BorderColor = Color.FromArgb(66, 124, 244);
            txtEventContent.BorderFocusColor = Color.HotPink;
            txtEventContent.BorderSize = 2;
            txtEventContent.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEventContent.ForeColor = Color.Black;
            txtEventContent.Location = new Point(4, 133);
            txtEventContent.Margin = new Padding(4);
            txtEventContent.Multiline = true;
            txtEventContent.Name = "txtEventContent";
            txtEventContent.Padding = new Padding(7);
            txtEventContent.PasswordChar = false;
            txtEventContent.Size = new Size(299, 151);
            txtEventContent.TabIndex = 5;
            txtEventContent.Texts = "";
            txtEventContent.UnderlinedStyle = false;
            // 
            // lblEventContent
            // 
            lblEventContent.AutoSize = true;
            lblEventContent.Font = new Font("Microsoft Sans Serif", 9F);
            lblEventContent.Location = new Point(4, 114);
            lblEventContent.Name = "lblEventContent";
            lblEventContent.Size = new Size(88, 15);
            lblEventContent.TabIndex = 6;
            lblEventContent.Text = "[Event Content]";
            lblEventContent.TextResourceKey = "ScnInfoEventContentLabel";
            // 
            // txtAuthor
            // 
            txtAuthor.AutoScroll = true;
            txtAuthor.BackColor = SystemColors.Window;
            txtAuthor.BorderColor = Color.FromArgb(66, 124, 244);
            txtAuthor.BorderFocusColor = Color.HotPink;
            txtAuthor.BorderSize = 2;
            txtAuthor.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.ForeColor = Color.Black;
            txtAuthor.Location = new Point(4, 320);
            txtAuthor.Margin = new Padding(4);
            txtAuthor.Multiline = false;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Padding = new Padding(7);
            txtAuthor.PasswordChar = false;
            txtAuthor.Size = new Size(299, 31);
            txtAuthor.TabIndex = 8;
            txtAuthor.Texts = "";
            txtAuthor.UnderlinedStyle = false;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Microsoft Sans Serif", 9F);
            lblAuthor.Location = new Point(3, 301);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(48, 15);
            lblAuthor.TabIndex = 7;
            lblAuthor.Text = "[Author]";
            lblAuthor.TextResourceKey = "ScnInfoAuthorLabel";
            // 
            // txtLanguage
            // 
            txtLanguage.AutoScroll = true;
            txtLanguage.BackColor = SystemColors.Window;
            txtLanguage.BorderColor = Color.FromArgb(66, 124, 244);
            txtLanguage.BorderFocusColor = Color.HotPink;
            txtLanguage.BorderSize = 2;
            txtLanguage.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLanguage.ForeColor = Color.Black;
            txtLanguage.Location = new Point(3, 373);
            txtLanguage.Margin = new Padding(4);
            txtLanguage.Multiline = false;
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Padding = new Padding(7);
            txtLanguage.PasswordChar = false;
            txtLanguage.Size = new Size(300, 31);
            txtLanguage.TabIndex = 10;
            txtLanguage.Texts = "";
            txtLanguage.UnderlinedStyle = false;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Font = new Font("Microsoft Sans Serif", 9F);
            lblLanguage.Location = new Point(2, 354);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(69, 15);
            lblLanguage.TabIndex = 9;
            lblLanguage.Text = "[Language]";
            lblLanguage.TextResourceKey = "ScnInfoLanguageLabel";
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Font = new Font("Microsoft Sans Serif", 9F);
            lblIcon.Location = new Point(4, 420);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(36, 15);
            lblIcon.TabIndex = 12;
            lblIcon.Text = "[Icon]";
            lblIcon.TextResourceKey = "ScnInfoIconLabel";
            // 
            // rbIconLove
            // 
            rbIconLove.Checked = true;
            rbIconLove.FlatStyle = FlatStyle.Flat;
            rbIconLove.Image = Properties.Resources.event_love_icon;
            rbIconLove.Location = new Point(3, 3);
            rbIconLove.Name = "rbIconLove";
            rbIconLove.Size = new Size(74, 61);
            rbIconLove.TabIndex = 13;
            rbIconLove.TabStop = true;
            rbIconLove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbIconExtra);
            panel1.Controls.Add(rbIconIdol);
            panel1.Controls.Add(rbIconNTR);
            panel1.Controls.Add(rbIconNPC);
            panel1.Controls.Add(rbIconLove);
            panel1.Location = new Point(4, 438);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 147);
            panel1.TabIndex = 14;
            // 
            // rbIconExtra
            // 
            rbIconExtra.FlatStyle = FlatStyle.Flat;
            rbIconExtra.Image = Properties.Resources.event_extra_icon;
            rbIconExtra.Location = new Point(93, 70);
            rbIconExtra.Name = "rbIconExtra";
            rbIconExtra.Size = new Size(74, 61);
            rbIconExtra.TabIndex = 17;
            rbIconExtra.UseVisualStyleBackColor = true;
            // 
            // rbIconIdol
            // 
            rbIconIdol.FlatStyle = FlatStyle.Flat;
            rbIconIdol.Image = Properties.Resources.event_idol_icon;
            rbIconIdol.Location = new Point(3, 70);
            rbIconIdol.Name = "rbIconIdol";
            rbIconIdol.Size = new Size(74, 61);
            rbIconIdol.TabIndex = 16;
            rbIconIdol.UseVisualStyleBackColor = true;
            // 
            // rbIconNTR
            // 
            rbIconNTR.FlatStyle = FlatStyle.Flat;
            rbIconNTR.Image = Properties.Resources.event_icon_ntr;
            rbIconNTR.Location = new Point(93, 3);
            rbIconNTR.Name = "rbIconNTR";
            rbIconNTR.Size = new Size(74, 61);
            rbIconNTR.TabIndex = 15;
            rbIconNTR.UseVisualStyleBackColor = true;
            // 
            // rbIconNPC
            // 
            rbIconNPC.FlatStyle = FlatStyle.Flat;
            rbIconNPC.Image = Properties.Resources.event_npc_icon;
            rbIconNPC.Location = new Point(183, 3);
            rbIconNPC.Name = "rbIconNPC";
            rbIconNPC.Size = new Size(74, 61);
            rbIconNPC.TabIndex = 14;
            rbIconNPC.UseVisualStyleBackColor = true;
            // 
            // lblMaidRequirement
            // 
            lblMaidRequirement.AutoSize = true;
            lblMaidRequirement.Font = new Font("Microsoft Sans Serif", 9F);
            lblMaidRequirement.Location = new Point(0, 599);
            lblMaidRequirement.Name = "lblMaidRequirement";
            lblMaidRequirement.Size = new Size(116, 15);
            lblMaidRequirement.TabIndex = 16;
            lblMaidRequirement.Text = "[Maid Requirement]";
            lblMaidRequirement.TextResourceKey = "ScnInfoMaidRequirementLabel";
            // 
            // btnMaidRequirement
            // 
            btnMaidRequirement.FlatStyle = FlatStyle.Flat;
            btnMaidRequirement.Font = new Font("Microsoft Sans Serif", 8F);
            btnMaidRequirement.Location = new Point(4, 630);
            btnMaidRequirement.Name = "btnMaidRequirement";
            btnMaidRequirement.Size = new Size(75, 23);
            btnMaidRequirement.TabIndex = 19;
            btnMaidRequirement.Text = "[Edit]";
            btnMaidRequirement.TextResourceKey = "Edit";
            btnMaidRequirement.UseVisualStyleBackColor = true;
            btnMaidRequirement.Click += btnMaidRequirement_Click;
            // 
            // ScenarioInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            Controls.Add(btnMaidRequirement);
            Controls.Add(lblMaidRequirement);
            Controls.Add(panel1);
            Controls.Add(lblIcon);
            Controls.Add(txtLanguage);
            Controls.Add(lblLanguage);
            Controls.Add(txtAuthor);
            Controls.Add(lblAuthor);
            Controls.Add(lblEventContent);
            Controls.Add(txtEventContent);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblHeader);
            Name = "ScenarioInfo";
            Size = new Size(310, 799);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ExtendedLabel lblHeader;
        private ExtendedLabel lblTitle;
        private CustomControls.RJControls.RJTextBox txtTitle;
        private CustomControls.RJControls.RJTextBox txtEventContent;
        private ExtendedLabel lblEventContent;
        private CustomControls.RJControls.RJTextBox txtAuthor;
        private ExtendedLabel lblAuthor;
        private CustomControls.RJControls.RJTextBox txtLanguage;
        private ExtendedLabel lblLanguage;
        private ExtendedLabel lblIcon;
        private RadioButton rbIconLove;
        private Panel panel1;
        private RadioButton rbIconNPC;
        private RadioButton rbIconExtra;
        private RadioButton rbIconIdol;
        private RadioButton rbIconNTR;
        private ExtendedLabel lblMaidRequirement;
        private ExtendedButton btnMaidRequirement;
    }
}
