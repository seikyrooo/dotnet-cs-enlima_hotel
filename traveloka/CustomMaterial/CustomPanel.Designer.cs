namespace traveloka
{
    partial class CustomPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPanel));
            this.lrp = new System.Windows.Forms.Label();
            this.ltitle = new MaterialSkin.Controls.MaterialLabel();
            this.baction = new MaterialSkin.Controls.MaterialButton();
            this.lharga = new System.Windows.Forms.Label();
            this.lsubtitle = new MaterialSkin.Controls.MaterialLabel();
            this.lketharga = new System.Windows.Forms.Label();
            this.bdetail = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.ppicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ppicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lrp
            // 
            this.lrp.AutoSize = true;
            this.lrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lrp.ForeColor = System.Drawing.Color.DarkOrange;
            this.lrp.Location = new System.Drawing.Point(171, 99);
            this.lrp.Name = "lrp";
            this.lrp.Size = new System.Drawing.Size(50, 29);
            this.lrp.TabIndex = 3;
            this.lrp.Text = "Rp.";
            // 
            // ltitle
            // 
            this.ltitle.AutoSize = true;
            this.ltitle.Depth = 0;
            this.ltitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ltitle.Location = new System.Drawing.Point(173, 21);
            this.ltitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.ltitle.Name = "ltitle";
            this.ltitle.Size = new System.Drawing.Size(53, 19);
            this.ltitle.TabIndex = 4;
            this.ltitle.Text = "Label 1";
            // 
            // baction
            // 
            this.baction.AutoSize = false;
            this.baction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.baction.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.baction.Depth = 0;
            this.baction.HighEmphasis = true;
            this.baction.Icon = null;
            this.baction.Location = new System.Drawing.Point(348, 99);
            this.baction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.baction.MouseState = MaterialSkin.MouseState.HOVER;
            this.baction.Name = "baction";
            this.baction.NoAccentTextColor = System.Drawing.Color.Empty;
            this.baction.Size = new System.Drawing.Size(139, 36);
            this.baction.TabIndex = 5;
            this.baction.Text = "Action";
            this.baction.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.baction.UseAccentColor = false;
            this.baction.UseVisualStyleBackColor = true;
            this.baction.Click += new System.EventHandler(this.baction_Click);
            // 
            // lharga
            // 
            this.lharga.AutoSize = true;
            this.lharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lharga.ForeColor = System.Drawing.Color.DarkOrange;
            this.lharga.Location = new System.Drawing.Point(217, 99);
            this.lharga.Name = "lharga";
            this.lharga.Size = new System.Drawing.Size(97, 29);
            this.lharga.TabIndex = 3;
            this.lharga.Text = "000 000";
            // 
            // lsubtitle
            // 
            this.lsubtitle.AutoSize = true;
            this.lsubtitle.Depth = 0;
            this.lsubtitle.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lsubtitle.Location = new System.Drawing.Point(173, 45);
            this.lsubtitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lsubtitle.Name = "lsubtitle";
            this.lsubtitle.Size = new System.Drawing.Size(53, 19);
            this.lsubtitle.TabIndex = 4;
            this.lsubtitle.Text = "Label 1";
            // 
            // lketharga
            // 
            this.lketharga.AutoSize = true;
            this.lketharga.ForeColor = System.Drawing.Color.DarkOrange;
            this.lketharga.Location = new System.Drawing.Point(195, 79);
            this.lketharga.Name = "lketharga";
            this.lketharga.Size = new System.Drawing.Size(90, 20);
            this.lketharga.TabIndex = 7;
            this.lketharga.Text = "Tarif Kamar";
            // 
            // bdetail
            // 
            this.bdetail.Depth = 0;
            this.bdetail.Icon = global::enlimahotel.Properties.Resources.info;
            this.bdetail.Location = new System.Drawing.Point(448, 12);
            this.bdetail.Mini = true;
            this.bdetail.MouseState = MaterialSkin.MouseState.HOVER;
            this.bdetail.Name = "bdetail";
            this.bdetail.Size = new System.Drawing.Size(40, 40);
            this.bdetail.TabIndex = 6;
            this.bdetail.Text = "materialFloatingActionButton1";
            this.bdetail.UseVisualStyleBackColor = true;
            this.bdetail.Click += new System.EventHandler(this.bdetail_Click);
            // 
            // ppicture
            // 
            this.ppicture.BackColor = System.Drawing.Color.Gainsboro;
            this.ppicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.ppicture.Location = new System.Drawing.Point(0, 0);
            this.ppicture.Name = "ppicture";
            this.ppicture.Size = new System.Drawing.Size(150, 150);
            this.ppicture.TabIndex = 1;
            this.ppicture.TabStop = false;
            // 
            // CustomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(500, 150);
            this.Controls.Add(this.lketharga);
            this.Controls.Add(this.bdetail);
            this.Controls.Add(this.baction);
            this.Controls.Add(this.lsubtitle);
            this.Controls.Add(this.ltitle);
            this.Controls.Add(this.lharga);
            this.Controls.Add(this.lrp);
            this.Controls.Add(this.ppicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomPanel";
            this.Text = "Custom Panel";
            ((System.ComponentModel.ISupportInitialize)(this.ppicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ppicture;
        private System.Windows.Forms.Label lrp;
        private MaterialSkin.Controls.MaterialLabel ltitle;
        private MaterialSkin.Controls.MaterialButton baction;
        private System.Windows.Forms.Label lharga;
        private MaterialSkin.Controls.MaterialLabel lsubtitle;
        private MaterialSkin.Controls.MaterialFloatingActionButton bdetail;
        private System.Windows.Forms.Label lketharga;
    }
}