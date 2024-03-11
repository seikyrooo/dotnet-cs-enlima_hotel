namespace traveloka
{
    partial class FormBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBooking));
            this.flpkamar = new System.Windows.Forms.FlowLayoutPanel();
            this.dcheckin = new System.Windows.Forms.DateTimePicker();
            this.cmalam = new MaterialSkin.Controls.MaterialComboBox();
            this.dcheckout = new System.Windows.Forms.DateTimePicker();
            this.lmalam = new MaterialSkin.Controls.MaterialLabel();
            this.cpelangganid = new MaterialSkin.Controls.MaterialComboBox();
            this.lcheckin = new MaterialSkin.Controls.MaterialLabel();
            this.lcheckout = new MaterialSkin.Controls.MaterialLabel();
            this.icmalam = new FontAwesome.Sharp.IconPictureBox();
            this.ccheckin = new MaterialSkin.Controls.MaterialCheckbox();
            this.csarapan = new MaterialSkin.Controls.MaterialCheckbox();
            this.cjumlahpelanggan = new MaterialSkin.Controls.MaterialComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.icmalam)).BeginInit();
            this.SuspendLayout();
            // 
            // flpkamar
            // 
            this.flpkamar.AutoScroll = true;
            this.flpkamar.Location = new System.Drawing.Point(32, 223);
            this.flpkamar.Name = "flpkamar";
            this.flpkamar.Size = new System.Drawing.Size(1040, 410);
            this.flpkamar.TabIndex = 0;
            // 
            // dcheckin
            // 
            this.dcheckin.Location = new System.Drawing.Point(32, 128);
            this.dcheckin.Name = "dcheckin";
            this.dcheckin.Size = new System.Drawing.Size(283, 26);
            this.dcheckin.TabIndex = 1;
            this.dcheckin.ValueChanged += new System.EventHandler(this.dcheckin_ValueChanged);
            // 
            // cmalam
            // 
            this.cmalam.AutoResize = false;
            this.cmalam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmalam.Depth = 0;
            this.cmalam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmalam.DropDownHeight = 174;
            this.cmalam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmalam.DropDownWidth = 121;
            this.cmalam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmalam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmalam.FormattingEnabled = true;
            this.cmalam.IntegralHeight = false;
            this.cmalam.ItemHeight = 43;
            this.cmalam.Location = new System.Drawing.Point(32, 160);
            this.cmalam.MaxDropDownItems = 4;
            this.cmalam.MouseState = MaterialSkin.MouseState.OUT;
            this.cmalam.Name = "cmalam";
            this.cmalam.Size = new System.Drawing.Size(159, 49);
            this.cmalam.StartIndex = 0;
            this.cmalam.TabIndex = 2;
            this.cmalam.SelectedIndexChanged += new System.EventHandler(this.cmalam_SelectedIndexChanged);
            // 
            // dcheckout
            // 
            this.dcheckout.Enabled = false;
            this.dcheckout.Location = new System.Drawing.Point(321, 128);
            this.dcheckout.Name = "dcheckout";
            this.dcheckout.Size = new System.Drawing.Size(276, 26);
            this.dcheckout.TabIndex = 3;
            // 
            // lmalam
            // 
            this.lmalam.AutoSize = true;
            this.lmalam.Depth = 0;
            this.lmalam.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lmalam.Location = new System.Drawing.Point(253, 175);
            this.lmalam.MouseState = MaterialSkin.MouseState.HOVER;
            this.lmalam.Name = "lmalam";
            this.lmalam.Size = new System.Drawing.Size(51, 19);
            this.lmalam.TabIndex = 5;
            this.lmalam.Text = "Malam";
            // 
            // cpelangganid
            // 
            this.cpelangganid.AutoResize = false;
            this.cpelangganid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cpelangganid.Depth = 0;
            this.cpelangganid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cpelangganid.DropDownHeight = 174;
            this.cpelangganid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpelangganid.DropDownWidth = 121;
            this.cpelangganid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cpelangganid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cpelangganid.FormattingEnabled = true;
            this.cpelangganid.Hint = "Nama Pelanggan";
            this.cpelangganid.IntegralHeight = false;
            this.cpelangganid.ItemHeight = 43;
            this.cpelangganid.Location = new System.Drawing.Point(321, 161);
            this.cpelangganid.MaxDropDownItems = 4;
            this.cpelangganid.MouseState = MaterialSkin.MouseState.OUT;
            this.cpelangganid.Name = "cpelangganid";
            this.cpelangganid.Size = new System.Drawing.Size(236, 49);
            this.cpelangganid.StartIndex = 0;
            this.cpelangganid.TabIndex = 6;
            // 
            // lcheckin
            // 
            this.lcheckin.AutoSize = true;
            this.lcheckin.Depth = 0;
            this.lcheckin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lcheckin.Location = new System.Drawing.Point(29, 106);
            this.lcheckin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lcheckin.Name = "lcheckin";
            this.lcheckin.Size = new System.Drawing.Size(98, 19);
            this.lcheckin.TabIndex = 5;
            this.lcheckin.Text = "Check-in Date";
            // 
            // lcheckout
            // 
            this.lcheckout.AutoSize = true;
            this.lcheckout.Depth = 0;
            this.lcheckout.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lcheckout.Location = new System.Drawing.Point(318, 106);
            this.lcheckout.MouseState = MaterialSkin.MouseState.HOVER;
            this.lcheckout.Name = "lcheckout";
            this.lcheckout.Size = new System.Drawing.Size(108, 19);
            this.lcheckout.TabIndex = 5;
            this.lcheckout.Text = "Check-out Date";
            // 
            // icmalam
            // 
            this.icmalam.BackColor = System.Drawing.SystemColors.Control;
            this.icmalam.ForeColor = System.Drawing.SystemColors.ControlText;
            this.icmalam.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.icmalam.IconColor = System.Drawing.SystemColors.ControlText;
            this.icmalam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icmalam.IconSize = 49;
            this.icmalam.Location = new System.Drawing.Point(197, 160);
            this.icmalam.Name = "icmalam";
            this.icmalam.Size = new System.Drawing.Size(50, 49);
            this.icmalam.TabIndex = 4;
            this.icmalam.TabStop = false;
            // 
            // ccheckin
            // 
            this.ccheckin.AutoSize = true;
            this.ccheckin.Depth = 0;
            this.ccheckin.Location = new System.Drawing.Point(826, 126);
            this.ccheckin.Margin = new System.Windows.Forms.Padding(0);
            this.ccheckin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ccheckin.MouseState = MaterialSkin.MouseState.HOVER;
            this.ccheckin.Name = "ccheckin";
            this.ccheckin.ReadOnly = false;
            this.ccheckin.Ripple = true;
            this.ccheckin.Size = new System.Drawing.Size(95, 37);
            this.ccheckin.TabIndex = 8;
            this.ccheckin.Text = "Check-in";
            this.ccheckin.UseVisualStyleBackColor = true;
            // 
            // csarapan
            // 
            this.csarapan.AutoSize = true;
            this.csarapan.Depth = 0;
            this.csarapan.Location = new System.Drawing.Point(600, 126);
            this.csarapan.Margin = new System.Windows.Forms.Padding(0);
            this.csarapan.MouseLocation = new System.Drawing.Point(-1, -1);
            this.csarapan.MouseState = MaterialSkin.MouseState.HOVER;
            this.csarapan.Name = "csarapan";
            this.csarapan.ReadOnly = false;
            this.csarapan.Ripple = true;
            this.csarapan.Size = new System.Drawing.Size(147, 37);
            this.csarapan.TabIndex = 8;
            this.csarapan.Text = "Sarapan (+50K)";
            this.csarapan.UseVisualStyleBackColor = true;
            // 
            // cjumlahpelanggan
            // 
            this.cjumlahpelanggan.AutoResize = false;
            this.cjumlahpelanggan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cjumlahpelanggan.Depth = 0;
            this.cjumlahpelanggan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cjumlahpelanggan.DropDownHeight = 174;
            this.cjumlahpelanggan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cjumlahpelanggan.DropDownWidth = 121;
            this.cjumlahpelanggan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cjumlahpelanggan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cjumlahpelanggan.FormattingEnabled = true;
            this.cjumlahpelanggan.Hint = "Jumlah Pelanggan";
            this.cjumlahpelanggan.IntegralHeight = false;
            this.cjumlahpelanggan.ItemHeight = 43;
            this.cjumlahpelanggan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cjumlahpelanggan.Location = new System.Drawing.Point(591, 161);
            this.cjumlahpelanggan.MaxDropDownItems = 4;
            this.cjumlahpelanggan.MouseState = MaterialSkin.MouseState.OUT;
            this.cjumlahpelanggan.Name = "cjumlahpelanggan";
            this.cjumlahpelanggan.Size = new System.Drawing.Size(184, 49);
            this.cjumlahpelanggan.StartIndex = 0;
            this.cjumlahpelanggan.TabIndex = 9;
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 772);
            this.Controls.Add(this.cjumlahpelanggan);
            this.Controls.Add(this.csarapan);
            this.Controls.Add(this.ccheckin);
            this.Controls.Add(this.cpelangganid);
            this.Controls.Add(this.lcheckout);
            this.Controls.Add(this.lcheckin);
            this.Controls.Add(this.lmalam);
            this.Controls.Add(this.icmalam);
            this.Controls.Add(this.dcheckout);
            this.Controls.Add(this.cmalam);
            this.Controls.Add(this.dcheckin);
            this.Controls.Add(this.flpkamar);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBooking";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.FormBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icmalam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpkamar;
        private FontAwesome.Sharp.IconPictureBox icmalam;
        private MaterialSkin.Controls.MaterialLabel lmalam;
        private MaterialSkin.Controls.MaterialLabel lcheckin;
        private MaterialSkin.Controls.MaterialLabel lcheckout;
        public System.Windows.Forms.DateTimePicker dcheckin;
        public System.Windows.Forms.DateTimePicker dcheckout;
        public MaterialSkin.Controls.MaterialComboBox cpelangganid;
        public MaterialSkin.Controls.MaterialCheckbox ccheckin;
        public MaterialSkin.Controls.MaterialCheckbox csarapan;
        public MaterialSkin.Controls.MaterialComboBox cjumlahpelanggan;
        public MaterialSkin.Controls.MaterialComboBox cmalam;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}