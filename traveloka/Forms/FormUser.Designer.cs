namespace enlimahotel.Forms
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.bsimpan = new MaterialSkin.Controls.MaterialButton();
            this.tnotelepon = new MaterialSkin.Controls.MaterialTextBox();
            this.tnama = new MaterialSkin.Controls.MaterialTextBox();
            this.pphoto = new System.Windows.Forms.PictureBox();
            this.temail = new MaterialSkin.Controls.MaterialTextBox();
            this.crole = new MaterialSkin.Controls.MaterialComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tpassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.cshowpassword = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.pphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // bsimpan
            // 
            this.bsimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bsimpan.AutoSize = false;
            this.bsimpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bsimpan.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.bsimpan.Depth = 0;
            this.bsimpan.HighEmphasis = true;
            this.bsimpan.Icon = null;
            this.bsimpan.Location = new System.Drawing.Point(45, 442);
            this.bsimpan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bsimpan.MouseState = MaterialSkin.MouseState.HOVER;
            this.bsimpan.Name = "bsimpan";
            this.bsimpan.NoAccentTextColor = System.Drawing.Color.Empty;
            this.bsimpan.Size = new System.Drawing.Size(238, 48);
            this.bsimpan.TabIndex = 16;
            this.bsimpan.Text = "Simpan";
            this.bsimpan.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.bsimpan.UseAccentColor = false;
            this.bsimpan.UseVisualStyleBackColor = true;
            this.bsimpan.Click += new System.EventHandler(this.bsimpan_Click);
            // 
            // tnotelepon
            // 
            this.tnotelepon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tnotelepon.AnimateReadOnly = false;
            this.tnotelepon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnotelepon.Depth = 0;
            this.tnotelepon.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnotelepon.Hint = "No Telepon";
            this.tnotelepon.LeadingIcon = null;
            this.tnotelepon.Location = new System.Drawing.Point(313, 261);
            this.tnotelepon.MaxLength = 50;
            this.tnotelepon.MouseState = MaterialSkin.MouseState.OUT;
            this.tnotelepon.Multiline = false;
            this.tnotelepon.Name = "tnotelepon";
            this.tnotelepon.Size = new System.Drawing.Size(359, 50);
            this.tnotelepon.TabIndex = 13;
            this.tnotelepon.Text = "";
            this.tnotelepon.TrailingIcon = null;
            // 
            // tnama
            // 
            this.tnama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tnama.AnimateReadOnly = false;
            this.tnama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnama.Depth = 0;
            this.tnama.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnama.Hint = "Nama";
            this.tnama.LeadingIcon = null;
            this.tnama.Location = new System.Drawing.Point(313, 149);
            this.tnama.MaxLength = 50;
            this.tnama.MouseState = MaterialSkin.MouseState.OUT;
            this.tnama.Multiline = false;
            this.tnama.Name = "tnama";
            this.tnama.Size = new System.Drawing.Size(359, 50);
            this.tnama.TabIndex = 15;
            this.tnama.Text = "";
            this.tnama.TrailingIcon = null;
            // 
            // pphoto
            // 
            this.pphoto.BackColor = System.Drawing.Color.Gainsboro;
            this.pphoto.Location = new System.Drawing.Point(45, 149);
            this.pphoto.Name = "pphoto";
            this.pphoto.Size = new System.Drawing.Size(238, 274);
            this.pphoto.TabIndex = 11;
            this.pphoto.TabStop = false;
            this.pphoto.Click += new System.EventHandler(this.pphoto_Click);
            // 
            // temail
            // 
            this.temail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.temail.AnimateReadOnly = false;
            this.temail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temail.Depth = 0;
            this.temail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.temail.Hint = "Email";
            this.temail.LeadingIcon = null;
            this.temail.Location = new System.Drawing.Point(313, 317);
            this.temail.MaxLength = 50;
            this.temail.MouseState = MaterialSkin.MouseState.OUT;
            this.temail.Multiline = false;
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(359, 50);
            this.temail.TabIndex = 13;
            this.temail.Text = "";
            this.temail.TrailingIcon = null;
            // 
            // crole
            // 
            this.crole.AutoResize = false;
            this.crole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.crole.Depth = 0;
            this.crole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.crole.DropDownHeight = 174;
            this.crole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crole.DropDownWidth = 121;
            this.crole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.crole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crole.FormattingEnabled = true;
            this.crole.Hint = "Role";
            this.crole.IntegralHeight = false;
            this.crole.ItemHeight = 43;
            this.crole.Items.AddRange(new object[] {
            "admin",
            "operator"});
            this.crole.Location = new System.Drawing.Point(313, 205);
            this.crole.MaxDropDownItems = 4;
            this.crole.MouseState = MaterialSkin.MouseState.OUT;
            this.crole.Name = "crole";
            this.crole.Size = new System.Drawing.Size(359, 49);
            this.crole.StartIndex = 0;
            this.crole.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tpassword
            // 
            this.tpassword.AnimateReadOnly = false;
            this.tpassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tpassword.Depth = 0;
            this.tpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tpassword.HideSelection = true;
            this.tpassword.Hint = "Password";
            this.tpassword.LeadingIcon = null;
            this.tpassword.Location = new System.Drawing.Point(313, 375);
            this.tpassword.MaxLength = 32767;
            this.tpassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tpassword.Name = "tpassword";
            this.tpassword.PasswordChar = '*';
            this.tpassword.PrefixSuffixText = null;
            this.tpassword.ReadOnly = false;
            this.tpassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tpassword.SelectedText = "";
            this.tpassword.SelectionLength = 0;
            this.tpassword.SelectionStart = 0;
            this.tpassword.ShortcutsEnabled = true;
            this.tpassword.Size = new System.Drawing.Size(359, 48);
            this.tpassword.TabIndex = 18;
            this.tpassword.TabStop = false;
            this.tpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpassword.TrailingIcon = null;
            this.tpassword.UseSystemPasswordChar = false;
            // 
            // cshowpassword
            // 
            this.cshowpassword.AutoSize = true;
            this.cshowpassword.Depth = 0;
            this.cshowpassword.Location = new System.Drawing.Point(313, 442);
            this.cshowpassword.Margin = new System.Windows.Forms.Padding(0);
            this.cshowpassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cshowpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.cshowpassword.Name = "cshowpassword";
            this.cshowpassword.ReadOnly = false;
            this.cshowpassword.Ripple = true;
            this.cshowpassword.Size = new System.Drawing.Size(149, 37);
            this.cshowpassword.TabIndex = 19;
            this.cshowpassword.Text = "Show Password";
            this.cshowpassword.UseVisualStyleBackColor = true;
            this.cshowpassword.CheckedChanged += new System.EventHandler(this.cshowpassword_CheckedChanged);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 529);
            this.Controls.Add(this.cshowpassword);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.crole);
            this.Controls.Add(this.bsimpan);
            this.Controls.Add(this.temail);
            this.Controls.Add(this.tnotelepon);
            this.Controls.Add(this.tnama);
            this.Controls.Add(this.pphoto);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUser";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.pphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton bsimpan;
        private MaterialSkin.Controls.MaterialTextBox tnotelepon;
        private MaterialSkin.Controls.MaterialTextBox tnama;
        private System.Windows.Forms.PictureBox pphoto;
        private MaterialSkin.Controls.MaterialTextBox temail;
        private MaterialSkin.Controls.MaterialComboBox crole;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialTextBox2 tpassword;
        private MaterialSkin.Controls.MaterialCheckbox cshowpassword;
    }
}