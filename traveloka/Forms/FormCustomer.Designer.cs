namespace traveloka
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.tnama = new MaterialSkin.Controls.MaterialTextBox();
            this.temail = new MaterialSkin.Controls.MaterialTextBox();
            this.tnomortelepon = new MaterialSkin.Controls.MaterialTextBox();
            this.bsimpan = new MaterialSkin.Controls.MaterialButton();
            this.tjenisidentitas = new MaterialSkin.Controls.MaterialTextBox();
            this.tnoidentitas = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // tnama
            // 
            this.tnama.AnimateReadOnly = false;
            this.tnama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnama.Depth = 0;
            this.tnama.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnama.Hint = "Nama";
            this.tnama.LeadingIcon = null;
            this.tnama.Location = new System.Drawing.Point(45, 145);
            this.tnama.MaxLength = 50;
            this.tnama.MouseState = MaterialSkin.MouseState.OUT;
            this.tnama.Multiline = false;
            this.tnama.Name = "tnama";
            this.tnama.Size = new System.Drawing.Size(440, 50);
            this.tnama.TabIndex = 0;
            this.tnama.Text = "";
            this.tnama.TrailingIcon = null;
            // 
            // temail
            // 
            this.temail.AnimateReadOnly = false;
            this.temail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temail.Depth = 0;
            this.temail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.temail.Hint = "Email";
            this.temail.LeadingIcon = null;
            this.temail.Location = new System.Drawing.Point(45, 209);
            this.temail.MaxLength = 50;
            this.temail.MouseState = MaterialSkin.MouseState.OUT;
            this.temail.Multiline = false;
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(440, 50);
            this.temail.TabIndex = 0;
            this.temail.Text = "";
            this.temail.TrailingIcon = null;
            // 
            // tnomortelepon
            // 
            this.tnomortelepon.AnimateReadOnly = false;
            this.tnomortelepon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnomortelepon.Depth = 0;
            this.tnomortelepon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnomortelepon.Hint = "No Telepon";
            this.tnomortelepon.LeadingIcon = null;
            this.tnomortelepon.Location = new System.Drawing.Point(45, 270);
            this.tnomortelepon.MaxLength = 50;
            this.tnomortelepon.MouseState = MaterialSkin.MouseState.OUT;
            this.tnomortelepon.Multiline = false;
            this.tnomortelepon.Name = "tnomortelepon";
            this.tnomortelepon.Size = new System.Drawing.Size(440, 50);
            this.tnomortelepon.TabIndex = 0;
            this.tnomortelepon.Text = "";
            this.tnomortelepon.TrailingIcon = null;
            this.tnomortelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tnomortelepon_KeyPress);
            // 
            // bsimpan
            // 
            this.bsimpan.AutoSize = false;
            this.bsimpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bsimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bsimpan.Depth = 0;
            this.bsimpan.HighEmphasis = true;
            this.bsimpan.Icon = null;
            this.bsimpan.Location = new System.Drawing.Point(45, 457);
            this.bsimpan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bsimpan.MouseState = MaterialSkin.MouseState.HOVER;
            this.bsimpan.Name = "bsimpan";
            this.bsimpan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bsimpan.Size = new System.Drawing.Size(440, 47);
            this.bsimpan.TabIndex = 1;
            this.bsimpan.Text = "Simpan";
            this.bsimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bsimpan.UseAccentColor = false;
            this.bsimpan.UseVisualStyleBackColor = true;
            this.bsimpan.Click += new System.EventHandler(this.bsimpan_Click);
            // 
            // tjenisidentitas
            // 
            this.tjenisidentitas.AnimateReadOnly = false;
            this.tjenisidentitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tjenisidentitas.Depth = 0;
            this.tjenisidentitas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tjenisidentitas.Hint = "Jenis Kartu Identitas";
            this.tjenisidentitas.LeadingIcon = null;
            this.tjenisidentitas.Location = new System.Drawing.Point(45, 335);
            this.tjenisidentitas.MaxLength = 50;
            this.tjenisidentitas.MouseState = MaterialSkin.MouseState.OUT;
            this.tjenisidentitas.Multiline = false;
            this.tjenisidentitas.Name = "tjenisidentitas";
            this.tjenisidentitas.Size = new System.Drawing.Size(440, 50);
            this.tjenisidentitas.TabIndex = 0;
            this.tjenisidentitas.Text = "";
            this.tjenisidentitas.TrailingIcon = null;
            // 
            // tnoidentitas
            // 
            this.tnoidentitas.AnimateReadOnly = false;
            this.tnoidentitas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnoidentitas.Depth = 0;
            this.tnoidentitas.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnoidentitas.Hint = "No Identitas";
            this.tnoidentitas.LeadingIcon = null;
            this.tnoidentitas.Location = new System.Drawing.Point(45, 398);
            this.tnoidentitas.MaxLength = 50;
            this.tnoidentitas.MouseState = MaterialSkin.MouseState.OUT;
            this.tnoidentitas.Multiline = false;
            this.tnoidentitas.Name = "tnoidentitas";
            this.tnoidentitas.Size = new System.Drawing.Size(440, 50);
            this.tnoidentitas.TabIndex = 0;
            this.tnoidentitas.Text = "";
            this.tnoidentitas.TrailingIcon = null;
            this.tnoidentitas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tnoidentitas_KeyPress);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 538);
            this.Controls.Add(this.bsimpan);
            this.Controls.Add(this.tnoidentitas);
            this.Controls.Add(this.tjenisidentitas);
            this.Controls.Add(this.tnomortelepon);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.tnama);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCustomer";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tnama;
        private MaterialSkin.Controls.MaterialTextBox temail;
        private MaterialSkin.Controls.MaterialTextBox tnomortelepon;
        private MaterialSkin.Controls.MaterialButton bsimpan;
        private MaterialSkin.Controls.MaterialTextBox tjenisidentitas;
        private MaterialSkin.Controls.MaterialTextBox tnoidentitas;
    }
}