namespace traveloka
{
    partial class FormNoKamar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoKamar));
            this.flpnokamar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpnokamar
            // 
            this.flpnokamar.Location = new System.Drawing.Point(28, 119);
            this.flpnokamar.Name = "flpnokamar";
            this.flpnokamar.Size = new System.Drawing.Size(640, 541);
            this.flpnokamar.TabIndex = 0;
            // 
            // FormNoKamar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 697);
            this.Controls.Add(this.flpnokamar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNoKamar";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilih No Kamar";
            this.Load += new System.EventHandler(this.FormNoKamar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpnokamar;
    }
}