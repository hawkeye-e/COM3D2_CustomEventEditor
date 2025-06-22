namespace COM3D2_CustomEventEditor.CustomControl
{
    partial class PersonalityList
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            cbPure = new ExtendedCheckBox();
            cbTsudere = new ExtendedCheckBox();
            cbKuudere = new ExtendedCheckBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cbPure);
            flowLayoutPanel1.Controls.Add(cbTsudere);
            flowLayoutPanel1.Controls.Add(cbKuudere);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(220, 150);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // cbPure
            // 
            cbPure.AutoSize = true;
            cbPure.FlatStyle = FlatStyle.Flat;
            cbPure.Location = new Point(3, 3);
            cbPure.Name = "cbPure";
            cbPure.Size = new Size(56, 19);
            cbPure.TabIndex = 0;
            cbPure.Text = "[Pure]";
            cbPure.TextResourceKey = "PersonalityPure";
            cbPure.UseVisualStyleBackColor = true;
            // 
            // cbTsudere
            // 
            cbTsudere.AutoSize = true;
            cbTsudere.FlatStyle = FlatStyle.Flat;
            cbTsudere.Location = new Point(65, 3);
            cbTsudere.Name = "cbTsudere";
            cbTsudere.Size = new Size(76, 19);
            cbTsudere.TabIndex = 1;
            cbTsudere.Text = "[Tsudere]";
            cbTsudere.TextResourceKey = "PersonalityPride";
            cbTsudere.UseVisualStyleBackColor = true;
            // 
            // cbKuudere
            // 
            cbKuudere.AutoSize = true;
            cbKuudere.FlatStyle = FlatStyle.Flat;
            cbKuudere.Location = new Point(3, 28);
            cbKuudere.Name = "cbKuudere";
            cbKuudere.Size = new Size(78, 19);
            cbKuudere.TabIndex = 2;
            cbKuudere.Text = "[Kuudere]";
            cbKuudere.TextResourceKey = "PersonalityCool";
            cbKuudere.UseVisualStyleBackColor = true;
            // 
            // PersonalityList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(flowLayoutPanel1);
            Name = "PersonalityList";
            Size = new Size(220, 150);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ExtendedCheckBox cbPure;
        private ExtendedCheckBox cbTsudere;
        private ExtendedCheckBox cbKuudere;
    }
}
