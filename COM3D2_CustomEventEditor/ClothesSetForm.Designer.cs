namespace COM3D2_CustomEventEditor
{
    partial class ClothesSetForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClothesSetForm));
            dgClothesSet = new DataGridView();
            btnUpdate = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            txtParse = new CustomControls.RJControls.RJTextBox();
            lblParse = new COM3D2_CustomEventEditor.CustomControl.ExtendedLabel();
            btnParse = new COM3D2_CustomEventEditor.CustomControl.ExtendedButton();
            colKey = new DataGridViewTextBoxColumn();
            colHat = new DataGridViewTextBoxColumn();
            colHeadDress = new DataGridViewTextBoxColumn();
            colTop = new DataGridViewTextBoxColumn();
            colBottom = new DataGridViewTextBoxColumn();
            colOnePiece = new DataGridViewTextBoxColumn();
            colSwimsuit = new DataGridViewTextBoxColumn();
            colBra = new DataGridViewTextBoxColumn();
            colPanties = new DataGridViewTextBoxColumn();
            colSocks = new DataGridViewTextBoxColumn();
            colShoes = new DataGridViewTextBoxColumn();
            colBangs = new DataGridViewTextBoxColumn();
            colGlasses = new DataGridViewTextBoxColumn();
            colEyeMask = new DataGridViewTextBoxColumn();
            colNose = new DataGridViewTextBoxColumn();
            colEars = new DataGridViewTextBoxColumn();
            colGloves = new DataGridViewTextBoxColumn();
            colNecklace = new DataGridViewTextBoxColumn();
            colChoker = new DataGridViewTextBoxColumn();
            colRibbon = new DataGridViewTextBoxColumn();
            colNipple = new DataGridViewTextBoxColumn();
            colArm = new DataGridViewTextBoxColumn();
            colBellyButton = new DataGridViewTextBoxColumn();
            colAnkle = new DataGridViewTextBoxColumn();
            colBack = new DataGridViewTextBoxColumn();
            colTail = new DataGridViewTextBoxColumn();
            colVagina = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgClothesSet).BeginInit();
            SuspendLayout();
            // 
            // dgClothesSet
            // 
            dgClothesSet.AllowUserToResizeColumns = false;
            dgClothesSet.AllowUserToResizeRows = false;
            dgClothesSet.BackgroundColor = Color.FromArgb(207, 221, 238);
            dgClothesSet.BorderStyle = BorderStyle.None;
            dgClothesSet.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgClothesSet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgClothesSet.Columns.AddRange(new DataGridViewColumn[] { colKey, colHat, colHeadDress, colTop, colBottom, colOnePiece, colSwimsuit, colBra, colPanties, colSocks, colShoes, colBangs, colGlasses, colEyeMask, colNose, colEars, colGloves, colNecklace, colChoker, colRibbon, colNipple, colArm, colBellyButton, colAnkle, colBack, colTail, colVagina, colDelete });
            dgClothesSet.GridColor = Color.FromArgb(128, 128, 255);
            dgClothesSet.Location = new Point(12, 66);
            dgClothesSet.MultiSelect = false;
            dgClothesSet.Name = "dgClothesSet";
            dgClothesSet.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgClothesSet.Size = new Size(740, 468);
            dgClothesSet.TabIndex = 0;
            dgClothesSet.CellContentClick += dgClothesSet_CellContentClick;
            dgClothesSet.CellValueChanged += dgClothesSet_CellValueChanged;
            dgClothesSet.CurrentCellDirtyStateChanged += dgClothesSet_CurrentCellDirtyStateChanged;
            dgClothesSet.DataError += dgClothesSet_DataError;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 8F);
            btnUpdate.Location = new Point(677, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "[Update]";
            btnUpdate.TextResourceKey = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtParse
            // 
            txtParse.AutoScroll = true;
            txtParse.BackColor = SystemColors.Window;
            txtParse.BorderColor = Color.FromArgb(66, 124, 244);
            txtParse.BorderFocusColor = Color.HotPink;
            txtParse.BorderSize = 2;
            txtParse.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParse.ForeColor = Color.Black;
            txtParse.Location = new Point(12, 28);
            txtParse.Margin = new Padding(4);
            txtParse.Multiline = false;
            txtParse.Name = "txtParse";
            txtParse.Padding = new Padding(7);
            txtParse.PasswordChar = false;
            txtParse.ReadOnly = false;
            txtParse.Size = new Size(401, 31);
            txtParse.TabIndex = 35;
            txtParse.Texts = "";
            txtParse.UnderlinedStyle = false;
            // 
            // lblParse
            // 
            lblParse.AutoSize = true;
            lblParse.Font = new Font("Microsoft Sans Serif", 9F);
            lblParse.Location = new Point(11, 9);
            lblParse.Name = "lblParse";
            lblParse.Size = new Size(144, 15);
            lblParse.TabIndex = 34;
            lblParse.Text = "[ClothesSetDataToParse]";
            lblParse.TextResourceKey = "ClothesSetFormParseDataLabel";
            // 
            // btnParse
            // 
            btnParse.FlatStyle = FlatStyle.Flat;
            btnParse.Font = new Font("Microsoft Sans Serif", 8F);
            btnParse.Location = new Point(420, 32);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(75, 23);
            btnParse.TabIndex = 36;
            btnParse.Text = "[Parse]";
            btnParse.TextResourceKey = "Parse";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // colKey
            // 
            colKey.DataPropertyName = "key";
            colKey.Frozen = true;
            colKey.HeaderText = "[Key]";
            colKey.Name = "colKey";
            colKey.Width = 160;
            // 
            // colHat
            // 
            colHat.DataPropertyName = "acchat";
            colHat.HeaderText = "[Hat]";
            colHat.Name = "colHat";
            colHat.Width = 200;
            // 
            // colHeadDress
            // 
            colHeadDress.DataPropertyName = "headset";
            colHeadDress.HeaderText = "[HeadDress]";
            colHeadDress.Name = "colHeadDress";
            colHeadDress.Width = 200;
            // 
            // colTop
            // 
            colTop.DataPropertyName = "wear";
            colTop.HeaderText = "[Top]";
            colTop.Name = "colTop";
            colTop.Width = 200;
            // 
            // colBottom
            // 
            colBottom.DataPropertyName = "skirt";
            colBottom.HeaderText = "[Bottom]";
            colBottom.Name = "colBottom";
            colBottom.Width = 200;
            // 
            // colOnePiece
            // 
            colOnePiece.DataPropertyName = "onepiece";
            colOnePiece.HeaderText = "[OnePiece]";
            colOnePiece.Name = "colOnePiece";
            colOnePiece.Width = 200;
            // 
            // colSwimsuit
            // 
            colSwimsuit.DataPropertyName = "mizugi";
            colSwimsuit.HeaderText = "[Swimsuit]";
            colSwimsuit.Name = "colSwimsuit";
            colSwimsuit.Width = 200;
            // 
            // colBra
            // 
            colBra.DataPropertyName = "bra";
            colBra.HeaderText = "[Bra]";
            colBra.Name = "colBra";
            colBra.Width = 200;
            // 
            // colPanties
            // 
            colPanties.DataPropertyName = "panz";
            colPanties.HeaderText = "[Panties]";
            colPanties.Name = "colPanties";
            colPanties.Width = 200;
            // 
            // colSocks
            // 
            colSocks.DataPropertyName = "stkg";
            colSocks.HeaderText = "[Socks]";
            colSocks.Name = "colSocks";
            colSocks.Width = 200;
            // 
            // colShoes
            // 
            colShoes.DataPropertyName = "shoes";
            colShoes.HeaderText = "[Shoes]";
            colShoes.Name = "colShoes";
            colShoes.Width = 200;
            // 
            // colBangs
            // 
            colBangs.DataPropertyName = "acckami";
            colBangs.HeaderText = "[Bangs]";
            colBangs.Name = "colBangs";
            colBangs.Width = 200;
            // 
            // colGlasses
            // 
            colGlasses.DataPropertyName = "megane";
            colGlasses.HeaderText = "[Glasses]";
            colGlasses.Name = "colGlasses";
            colGlasses.Width = 200;
            // 
            // colEyeMask
            // 
            colEyeMask.DataPropertyName = "acchead";
            colEyeMask.HeaderText = "[EyeMask]";
            colEyeMask.Name = "colEyeMask";
            colEyeMask.Width = 200;
            // 
            // colNose
            // 
            colNose.DataPropertyName = "acchana";
            colNose.HeaderText = "[Nose]";
            colNose.Name = "colNose";
            colNose.Width = 200;
            // 
            // colEars
            // 
            colEars.DataPropertyName = "accmimi";
            colEars.HeaderText = "[Ears]";
            colEars.Name = "colEars";
            colEars.Width = 200;
            // 
            // colGloves
            // 
            colGloves.DataPropertyName = "glove";
            colGloves.HeaderText = "[Gloves]";
            colGloves.Name = "colGloves";
            colGloves.Width = 200;
            // 
            // colNecklace
            // 
            colNecklace.DataPropertyName = "acckubi";
            colNecklace.HeaderText = "[Necklace]";
            colNecklace.Name = "colNecklace";
            colNecklace.Width = 200;
            // 
            // colChoker
            // 
            colChoker.DataPropertyName = "acckubiwa";
            colChoker.HeaderText = "[Choker]";
            colChoker.Name = "colChoker";
            colChoker.Width = 200;
            // 
            // colRibbon
            // 
            colRibbon.DataPropertyName = "acckamisub";
            colRibbon.HeaderText = "[Ribbon]";
            colRibbon.Name = "colRibbon";
            colRibbon.Width = 200;
            // 
            // colNipple
            // 
            colNipple.DataPropertyName = "accnip";
            colNipple.HeaderText = "[Nipple]";
            colNipple.Name = "colNipple";
            colNipple.Width = 200;
            // 
            // colArm
            // 
            colArm.DataPropertyName = "accude";
            colArm.HeaderText = "[Arm]";
            colArm.Name = "colArm";
            colArm.Width = 200;
            // 
            // colBellyButton
            // 
            colBellyButton.DataPropertyName = "accheso";
            colBellyButton.HeaderText = "[BellyButton]";
            colBellyButton.Name = "colBellyButton";
            colBellyButton.Width = 200;
            // 
            // colAnkle
            // 
            colAnkle.DataPropertyName = "accashi";
            colAnkle.HeaderText = "[Ankle]";
            colAnkle.Name = "colAnkle";
            colAnkle.Width = 200;
            // 
            // colBack
            // 
            colBack.DataPropertyName = "accsenaka";
            colBack.HeaderText = "[Back]";
            colBack.Name = "colBack";
            colBack.Width = 200;
            // 
            // colTail
            // 
            colTail.DataPropertyName = "accshippo";
            colTail.HeaderText = "[Tail]";
            colTail.Name = "colTail";
            colTail.Width = 200;
            // 
            // colVagina
            // 
            colVagina.DataPropertyName = "accxxx";
            colVagina.HeaderText = "[Vagina]";
            colVagina.Name = "colVagina";
            colVagina.Width = 200;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "";
            colDelete.Name = "colDelete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 80;
            // 
            // ClothesSetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 221, 238);
            ClientSize = new Size(764, 561);
            Controls.Add(btnParse);
            Controls.Add(txtParse);
            Controls.Add(lblParse);
            Controls.Add(btnUpdate);
            Controls.Add(dgClothesSet);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClothesSetForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Clothes Set Settings";
            ((System.ComponentModel.ISupportInitialize)dgClothesSet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgClothesSet;
        private CustomControl.ExtendedButton btnUpdate;
        private CustomControls.RJControls.RJTextBox txtParse;
        private CustomControl.ExtendedLabel lblParse;
        private CustomControl.ExtendedButton btnParse;
        private DataGridViewTextBoxColumn colKey;
        private DataGridViewTextBoxColumn colHat;
        private DataGridViewTextBoxColumn colHeadDress;
        private DataGridViewTextBoxColumn colTop;
        private DataGridViewTextBoxColumn colBottom;
        private DataGridViewTextBoxColumn colOnePiece;
        private DataGridViewTextBoxColumn colSwimsuit;
        private DataGridViewTextBoxColumn colBra;
        private DataGridViewTextBoxColumn colPanties;
        private DataGridViewTextBoxColumn colSocks;
        private DataGridViewTextBoxColumn colShoes;
        private DataGridViewTextBoxColumn colBangs;
        private DataGridViewTextBoxColumn colGlasses;
        private DataGridViewTextBoxColumn colEyeMask;
        private DataGridViewTextBoxColumn colNose;
        private DataGridViewTextBoxColumn colEars;
        private DataGridViewTextBoxColumn colGloves;
        private DataGridViewTextBoxColumn colNecklace;
        private DataGridViewTextBoxColumn colChoker;
        private DataGridViewTextBoxColumn colRibbon;
        private DataGridViewTextBoxColumn colNipple;
        private DataGridViewTextBoxColumn colArm;
        private DataGridViewTextBoxColumn colBellyButton;
        private DataGridViewTextBoxColumn colAnkle;
        private DataGridViewTextBoxColumn colBack;
        private DataGridViewTextBoxColumn colTail;
        private DataGridViewTextBoxColumn colVagina;
        private DataGridViewButtonColumn colDelete;
    }
}