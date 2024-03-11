namespace traveloka
{
    partial class CustomButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomButton));
            this.button = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.AutoSize = false;
            this.button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.button.Depth = 0;
            this.button.HighEmphasis = true;
            this.button.Icon = null;
            this.button.Location = new System.Drawing.Point(5, 5);
            this.button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button.MouseState = MaterialSkin.MouseState.HOVER;
            this.button.Name = "button";
            this.button.NoAccentTextColor = System.Drawing.Color.Empty;
            this.button.Size = new System.Drawing.Size(50, 50);
            this.button.TabIndex = 0;
            this.button.Text = "1";
            this.button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.button.UseAccentColor = false;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(60, 60);
            this.Controls.Add(this.button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomButton";
            this.Text = "CustomButton";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton button;
    }
}