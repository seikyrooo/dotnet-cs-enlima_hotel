namespace enlimahotel.Forms
{
    partial class FormPelayanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelayanan));
            this.bsimpan = new MaterialSkin.Controls.MaterialButton();
            this.tharga = new MaterialSkin.Controls.MaterialTextBox();
            this.tnamapelayanan = new MaterialSkin.Controls.MaterialTextBox();
            this.ckategori = new MaterialSkin.Controls.MaterialComboBox();
            this.SuspendLayout();
            // 
            // bsimpan
            // 
            this.bsimpan.AutoSize = false;
            this.bsimpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bsimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bsimpan.Depth = 0;
            this.bsimpan.HighEmphasis = true;
            this.bsimpan.Icon = null;
            this.bsimpan.Location = new System.Drawing.Point(43, 305);
            this.bsimpan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bsimpan.MouseState = MaterialSkin.MouseState.HOVER;
            this.bsimpan.Name = "bsimpan";
            this.bsimpan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bsimpan.Size = new System.Drawing.Size(440, 47);
            this.bsimpan.TabIndex = 7;
            this.bsimpan.Text = "Simpan";
            this.bsimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bsimpan.UseAccentColor = false;
            this.bsimpan.UseVisualStyleBackColor = true;
            this.bsimpan.Click += new System.EventHandler(this.bsimpan_Click);
            // 
            // tharga
            // 
            this.tharga.AnimateReadOnly = false;
            this.tharga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tharga.Depth = 0;
            this.tharga.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tharga.Hint = "Harga Pelayanan";
            this.tharga.LeadingIcon = null;
            this.tharga.Location = new System.Drawing.Point(43, 178);
            this.tharga.MaxLength = 50;
            this.tharga.MouseState = MaterialSkin.MouseState.OUT;
            this.tharga.Multiline = false;
            this.tharga.Name = "tharga";
            this.tharga.Size = new System.Drawing.Size(440, 50);
            this.tharga.TabIndex = 5;
            this.tharga.Text = "";
            this.tharga.TrailingIcon = null;
            this.tharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tharga_KeyPress);
            // 
            // tnamapelayanan
            // 
            this.tnamapelayanan.AnimateReadOnly = false;
            this.tnamapelayanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnamapelayanan.Depth = 0;
            this.tnamapelayanan.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnamapelayanan.Hint = "Pelayanan";
            this.tnamapelayanan.LeadingIcon = null;
            this.tnamapelayanan.Location = new System.Drawing.Point(43, 114);
            this.tnamapelayanan.MaxLength = 50;
            this.tnamapelayanan.MouseState = MaterialSkin.MouseState.OUT;
            this.tnamapelayanan.Multiline = false;
            this.tnamapelayanan.Name = "tnamapelayanan";
            this.tnamapelayanan.Size = new System.Drawing.Size(440, 50);
            this.tnamapelayanan.TabIndex = 6;
            this.tnamapelayanan.Text = "";
            this.tnamapelayanan.TrailingIcon = null;
            // 
            // ckategori
            // 
            this.ckategori.AutoResize = false;
            this.ckategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ckategori.Depth = 0;
            this.ckategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ckategori.DropDownHeight = 174;
            this.ckategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ckategori.DropDownWidth = 121;
            this.ckategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ckategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ckategori.FormattingEnabled = true;
            this.ckategori.Hint = "Kategori";
            this.ckategori.IntegralHeight = false;
            this.ckategori.ItemHeight = 43;
            this.ckategori.Items.AddRange(new object[] {
            "Bed",
            "Makanan",
            "Lain-lain"});
            this.ckategori.Location = new System.Drawing.Point(43, 240);
            this.ckategori.MaxDropDownItems = 4;
            this.ckategori.MouseState = MaterialSkin.MouseState.OUT;
            this.ckategori.Name = "ckategori";
            this.ckategori.Size = new System.Drawing.Size(440, 49);
            this.ckategori.StartIndex = 0;
            this.ckategori.TabIndex = 8;
            // 
            // FormPelayanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 393);
            this.Controls.Add(this.ckategori);
            this.Controls.Add(this.bsimpan);
            this.Controls.Add(this.tharga);
            this.Controls.Add(this.tnamapelayanan);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPelayanan";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelayanan";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton bsimpan;
        private MaterialSkin.Controls.MaterialTextBox tharga;
        private MaterialSkin.Controls.MaterialTextBox tnamapelayanan;
        private MaterialSkin.Controls.MaterialComboBox ckategori;
    }
}