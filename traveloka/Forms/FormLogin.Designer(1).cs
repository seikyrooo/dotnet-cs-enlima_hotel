namespace traveloka
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.blogin = new MaterialSkin.Controls.MaterialButton();
            this.temail = new MaterialSkin.Controls.MaterialTextBox();
            this.tpassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.cshowpassword = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // blogin
            // 
            this.blogin.AutoSize = false;
            this.blogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.blogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.blogin.Depth = 0;
            this.blogin.HighEmphasis = true;
            this.blogin.Icon = null;
            this.blogin.Location = new System.Drawing.Point(345, 337);
            this.blogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.blogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.blogin.Name = "blogin";
            this.blogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.blogin.Size = new System.Drawing.Size(139, 36);
            this.blogin.TabIndex = 7;
            this.blogin.Text = "Login";
            this.blogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.blogin.UseAccentColor = false;
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // temail
            // 
            this.temail.AnimateReadOnly = false;
            this.temail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temail.Depth = 0;
            this.temail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.temail.Hint = "Email";
            this.temail.LeadingIcon = null;
            this.temail.Location = new System.Drawing.Point(50, 168);
            this.temail.MaxLength = 50;
            this.temail.MouseState = MaterialSkin.MouseState.OUT;
            this.temail.Multiline = false;
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(434, 50);
            this.temail.TabIndex = 5;
            this.temail.Text = "";
            this.temail.TrailingIcon = null;
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
            this.tpassword.Location = new System.Drawing.Point(50, 224);
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
            this.tpassword.Size = new System.Drawing.Size(434, 48);
            this.tpassword.TabIndex = 8;
            this.tpassword.TabStop = false;
            this.tpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tpassword.TrailingIcon = null;
            this.tpassword.UseSystemPasswordChar = false;
            // 
            // cshowpassword
            // 
            this.cshowpassword.AutoSize = true;
            this.cshowpassword.Depth = 0;
            this.cshowpassword.Location = new System.Drawing.Point(50, 275);
            this.cshowpassword.Margin = new System.Windows.Forms.Padding(0);
            this.cshowpassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cshowpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.cshowpassword.Name = "cshowpassword";
            this.cshowpassword.ReadOnly = false;
            this.cshowpassword.Ripple = true;
            this.cshowpassword.Size = new System.Drawing.Size(149, 37);
            this.cshowpassword.TabIndex = 10;
            this.cshowpassword.Text = "Show Password";
            this.cshowpassword.UseVisualStyleBackColor = true;
            this.cshowpassword.CheckedChanged += new System.EventHandler(this.cshowpassword_CheckedChanged);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 398);
            this.Controls.Add(this.cshowpassword);
            this.Controls.Add(this.tpassword);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.temail);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Back";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton blogin;
        private MaterialSkin.Controls.MaterialTextBox temail;
        private MaterialSkin.Controls.MaterialTextBox2 tpassword;
        private MaterialSkin.Controls.MaterialCheckbox cshowpassword;
    }
}