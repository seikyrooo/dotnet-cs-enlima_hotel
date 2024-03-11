namespace traveloka
{
    partial class FormRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoom));
            this.badd = new MaterialSkin.Controls.MaterialButton();
            this.ttarifkamar = new MaterialSkin.Controls.MaterialTextBox();
            this.tjeniskamar = new MaterialSkin.Controls.MaterialTextBox();
            this.cextrabed = new MaterialSkin.Controls.MaterialCheckbox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.bnokamar = new MaterialSkin.Controls.MaterialButton();
            this.pfotokamar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pfotokamar)).BeginInit();
            this.SuspendLayout();
            // 
            // badd
            // 
            this.badd.AutoSize = false;
            this.badd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.badd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.badd.Depth = 0;
            this.badd.HighEmphasis = true;
            this.badd.Icon = null;
            this.badd.Location = new System.Drawing.Point(319, 350);
            this.badd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.badd.MouseState = MaterialSkin.MouseState.HOVER;
            this.badd.Name = "badd";
            this.badd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.badd.Size = new System.Drawing.Size(335, 48);
            this.badd.TabIndex = 16;
            this.badd.Text = "Input";
            this.badd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.badd.UseAccentColor = false;
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // ttarifkamar
            // 
            this.ttarifkamar.AnimateReadOnly = false;
            this.ttarifkamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttarifkamar.Depth = 0;
            this.ttarifkamar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ttarifkamar.Hint = "Tarif Kamar";
            this.ttarifkamar.LeadingIcon = null;
            this.ttarifkamar.Location = new System.Drawing.Point(319, 237);
            this.ttarifkamar.MaxLength = 50;
            this.ttarifkamar.MouseState = MaterialSkin.MouseState.OUT;
            this.ttarifkamar.Multiline = false;
            this.ttarifkamar.Name = "ttarifkamar";
            this.ttarifkamar.Size = new System.Drawing.Size(335, 50);
            this.ttarifkamar.TabIndex = 14;
            this.ttarifkamar.Text = "";
            this.ttarifkamar.TrailingIcon = null;
            this.ttarifkamar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ttarifkamar_KeyPress);
            // 
            // tjeniskamar
            // 
            this.tjeniskamar.AnimateReadOnly = false;
            this.tjeniskamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tjeniskamar.Depth = 0;
            this.tjeniskamar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tjeniskamar.Hint = "Jenis Kamar";
            this.tjeniskamar.LeadingIcon = null;
            this.tjeniskamar.Location = new System.Drawing.Point(319, 170);
            this.tjeniskamar.MaxLength = 50;
            this.tjeniskamar.MouseState = MaterialSkin.MouseState.OUT;
            this.tjeniskamar.Multiline = false;
            this.tjeniskamar.Name = "tjeniskamar";
            this.tjeniskamar.Size = new System.Drawing.Size(335, 50);
            this.tjeniskamar.TabIndex = 15;
            this.tjeniskamar.Text = "";
            this.tjeniskamar.TrailingIcon = null;
            // 
            // cextrabed
            // 
            this.cextrabed.AutoSize = true;
            this.cextrabed.Depth = 0;
            this.cextrabed.Location = new System.Drawing.Point(319, 307);
            this.cextrabed.Margin = new System.Windows.Forms.Padding(0);
            this.cextrabed.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cextrabed.MouseState = MaterialSkin.MouseState.HOVER;
            this.cextrabed.Name = "cextrabed";
            this.cextrabed.ReadOnly = false;
            this.cextrabed.Ripple = true;
            this.cextrabed.Size = new System.Drawing.Size(174, 37);
            this.cextrabed.TabIndex = 18;
            this.cextrabed.Text = "Support Extra Bed ?";
            this.cextrabed.UseVisualStyleBackColor = true;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // bnokamar
            // 
            this.bnokamar.AutoSize = false;
            this.bnokamar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bnokamar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bnokamar.Depth = 0;
            this.bnokamar.HighEmphasis = true;
            this.bnokamar.Icon = null;
            this.bnokamar.Location = new System.Drawing.Point(319, 101);
            this.bnokamar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bnokamar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bnokamar.Name = "bnokamar";
            this.bnokamar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bnokamar.Size = new System.Drawing.Size(335, 48);
            this.bnokamar.TabIndex = 16;
            this.bnokamar.Text = "Pilih No Kamar";
            this.bnokamar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bnokamar.UseAccentColor = false;
            this.bnokamar.UseVisualStyleBackColor = true;
            this.bnokamar.TextChanged += new System.EventHandler(this.bnokamar_TextChanged);
            this.bnokamar.Click += new System.EventHandler(this.bnokamar_Click);
            // 
            // pfotokamar
            // 
            this.pfotokamar.BackColor = System.Drawing.Color.Gainsboro;
            this.pfotokamar.Location = new System.Drawing.Point(51, 101);
            this.pfotokamar.Name = "pfotokamar";
            this.pfotokamar.Size = new System.Drawing.Size(238, 297);
            this.pfotokamar.TabIndex = 12;
            this.pfotokamar.TabStop = false;
            this.pfotokamar.Click += new System.EventHandler(this.pfotokamar_Click);
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 442);
            this.Controls.Add(this.cextrabed);
            this.Controls.Add(this.bnokamar);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.ttarifkamar);
            this.Controls.Add(this.tjeniskamar);
            this.Controls.Add(this.pfotokamar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            ((System.ComponentModel.ISupportInitialize)(this.pfotokamar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton badd;
        private MaterialSkin.Controls.MaterialTextBox ttarifkamar;
        private MaterialSkin.Controls.MaterialTextBox tjeniskamar;
        private System.Windows.Forms.PictureBox pfotokamar;
        private MaterialSkin.Controls.MaterialCheckbox cextrabed;
        private System.Windows.Forms.OpenFileDialog ofd;
        public MaterialSkin.Controls.MaterialButton bnokamar;
    }
}