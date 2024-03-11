namespace traveloka
{
    partial class FormPesan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesan));
            this.tpelangganid = new MaterialSkin.Controls.MaterialTextBox();
            this.dbed = new System.Windows.Forms.DataGridView();
            this.cid1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpelayanan1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charga1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpesan1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tresid = new MaterialSkin.Controls.MaterialTextBox();
            this.lbed = new System.Windows.Forms.Label();
            this.dmakanan = new System.Windows.Forms.DataGridView();
            this.cid2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpelayanan2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charga2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpesan2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lmakanan = new System.Windows.Forms.Label();
            this.dlainlain = new System.Windows.Forms.DataGridView();
            this.cid3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpelayanan3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charga3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpesan3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.llainlain = new System.Windows.Forms.Label();
            this.tnokamar = new MaterialSkin.Controls.MaterialTextBox();
            this.lketharga = new System.Windows.Forms.Label();
            this.ltotalharga = new System.Windows.Forms.Label();
            this.lrp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmakanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlainlain)).BeginInit();
            this.SuspendLayout();
            // 
            // tpelangganid
            // 
            this.tpelangganid.AnimateReadOnly = false;
            this.tpelangganid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tpelangganid.Depth = 0;
            this.tpelangganid.Enabled = false;
            this.tpelangganid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tpelangganid.Hint = "Pelanggan ID";
            this.tpelangganid.LeadingIcon = null;
            this.tpelangganid.Location = new System.Drawing.Point(245, 105);
            this.tpelangganid.MaxLength = 50;
            this.tpelangganid.MouseState = MaterialSkin.MouseState.OUT;
            this.tpelangganid.Multiline = false;
            this.tpelangganid.Name = "tpelangganid";
            this.tpelangganid.Size = new System.Drawing.Size(131, 50);
            this.tpelangganid.TabIndex = 0;
            this.tpelangganid.Text = "";
            this.tpelangganid.TrailingIcon = null;
            // 
            // dbed
            // 
            this.dbed.AllowUserToAddRows = false;
            this.dbed.AllowUserToDeleteRows = false;
            this.dbed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dbed.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dbed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid1,
            this.cpelayanan1,
            this.charga1,
            this.cpesan1});
            this.dbed.Location = new System.Drawing.Point(25, 209);
            this.dbed.Name = "dbed";
            this.dbed.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbed.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dbed.RowHeadersVisible = false;
            this.dbed.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dbed.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dbed.RowTemplate.Height = 28;
            this.dbed.Size = new System.Drawing.Size(389, 320);
            this.dbed.TabIndex = 10;
            this.dbed.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dbed_CellMouseClick);
            this.dbed.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dbed_RowsAdded);
            // 
            // cid1
            // 
            this.cid1.DataPropertyName = "pelayanan_id";
            this.cid1.HeaderText = "ID";
            this.cid1.MinimumWidth = 8;
            this.cid1.Name = "cid1";
            this.cid1.ReadOnly = true;
            this.cid1.Visible = false;
            // 
            // cpelayanan1
            // 
            this.cpelayanan1.DataPropertyName = "nama_pelayanan";
            this.cpelayanan1.HeaderText = "Pelayanan";
            this.cpelayanan1.MinimumWidth = 8;
            this.cpelayanan1.Name = "cpelayanan1";
            this.cpelayanan1.ReadOnly = true;
            // 
            // charga1
            // 
            this.charga1.DataPropertyName = "harga_pelayanan";
            this.charga1.HeaderText = "Harga";
            this.charga1.MinimumWidth = 8;
            this.charga1.Name = "charga1";
            this.charga1.ReadOnly = true;
            // 
            // cpesan1
            // 
            this.cpesan1.HeaderText = "Pesan";
            this.cpesan1.MinimumWidth = 8;
            this.cpesan1.Name = "cpesan1";
            this.cpesan1.ReadOnly = true;
            this.cpesan1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tresid
            // 
            this.tresid.AnimateReadOnly = false;
            this.tresid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tresid.Depth = 0;
            this.tresid.Enabled = false;
            this.tresid.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tresid.Hint = "Reservasi ID";
            this.tresid.LeadingIcon = null;
            this.tresid.Location = new System.Drawing.Point(25, 105);
            this.tresid.MaxLength = 50;
            this.tresid.MouseState = MaterialSkin.MouseState.OUT;
            this.tresid.Multiline = false;
            this.tresid.Name = "tresid";
            this.tresid.Size = new System.Drawing.Size(214, 50);
            this.tresid.TabIndex = 0;
            this.tresid.Text = "";
            this.tresid.TrailingIcon = null;
            // 
            // lbed
            // 
            this.lbed.BackColor = System.Drawing.Color.Pink;
            this.lbed.Location = new System.Drawing.Point(25, 171);
            this.lbed.Name = "lbed";
            this.lbed.Size = new System.Drawing.Size(389, 23);
            this.lbed.TabIndex = 11;
            this.lbed.Text = "Support Extra Bed";
            this.lbed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dmakanan
            // 
            this.dmakanan.AllowUserToAddRows = false;
            this.dmakanan.AllowUserToDeleteRows = false;
            this.dmakanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dmakanan.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dmakanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dmakanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid2,
            this.cpelayanan2,
            this.charga2,
            this.cpesan2});
            this.dmakanan.Location = new System.Drawing.Point(432, 209);
            this.dmakanan.Name = "dmakanan";
            this.dmakanan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dmakanan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dmakanan.RowHeadersVisible = false;
            this.dmakanan.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dmakanan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dmakanan.RowTemplate.Height = 28;
            this.dmakanan.Size = new System.Drawing.Size(389, 320);
            this.dmakanan.TabIndex = 10;
            this.dmakanan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dmakanan_CellMouseClick);
            this.dmakanan.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dmakanan_RowsAdded);
            // 
            // cid2
            // 
            this.cid2.DataPropertyName = "pelayanan_id";
            this.cid2.HeaderText = "ID";
            this.cid2.MinimumWidth = 8;
            this.cid2.Name = "cid2";
            this.cid2.ReadOnly = true;
            this.cid2.Visible = false;
            // 
            // cpelayanan2
            // 
            this.cpelayanan2.DataPropertyName = "nama_pelayanan";
            this.cpelayanan2.HeaderText = "Pelayanan";
            this.cpelayanan2.MinimumWidth = 8;
            this.cpelayanan2.Name = "cpelayanan2";
            this.cpelayanan2.ReadOnly = true;
            // 
            // charga2
            // 
            this.charga2.DataPropertyName = "harga_pelayanan";
            this.charga2.HeaderText = "Harga";
            this.charga2.MinimumWidth = 8;
            this.charga2.Name = "charga2";
            this.charga2.ReadOnly = true;
            // 
            // cpesan2
            // 
            this.cpesan2.HeaderText = "Pesan";
            this.cpesan2.MinimumWidth = 8;
            this.cpesan2.Name = "cpesan2";
            this.cpesan2.ReadOnly = true;
            this.cpesan2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lmakanan
            // 
            this.lmakanan.BackColor = System.Drawing.Color.Pink;
            this.lmakanan.Location = new System.Drawing.Point(432, 171);
            this.lmakanan.Name = "lmakanan";
            this.lmakanan.Size = new System.Drawing.Size(389, 23);
            this.lmakanan.TabIndex = 11;
            this.lmakanan.Text = "Makanan";
            this.lmakanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlainlain
            // 
            this.dlainlain.AllowUserToAddRows = false;
            this.dlainlain.AllowUserToDeleteRows = false;
            this.dlainlain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dlainlain.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dlainlain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dlainlain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid3,
            this.cpelayanan3,
            this.charga3,
            this.cpesan3});
            this.dlainlain.Location = new System.Drawing.Point(837, 209);
            this.dlainlain.Name = "dlainlain";
            this.dlainlain.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dlainlain.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dlainlain.RowHeadersVisible = false;
            this.dlainlain.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dlainlain.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dlainlain.RowTemplate.Height = 28;
            this.dlainlain.Size = new System.Drawing.Size(389, 320);
            this.dlainlain.TabIndex = 10;
            this.dlainlain.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dlainlain_CellMouseClick);
            this.dlainlain.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dlainlain_RowsAdded);
            // 
            // cid3
            // 
            this.cid3.DataPropertyName = "pelayanan_id";
            this.cid3.HeaderText = "ID";
            this.cid3.MinimumWidth = 8;
            this.cid3.Name = "cid3";
            this.cid3.ReadOnly = true;
            this.cid3.Visible = false;
            // 
            // cpelayanan3
            // 
            this.cpelayanan3.DataPropertyName = "nama_pelayanan";
            this.cpelayanan3.HeaderText = "Pelayanan";
            this.cpelayanan3.MinimumWidth = 8;
            this.cpelayanan3.Name = "cpelayanan3";
            this.cpelayanan3.ReadOnly = true;
            // 
            // charga3
            // 
            this.charga3.DataPropertyName = "harga_pelayanan";
            this.charga3.HeaderText = "Harga";
            this.charga3.MinimumWidth = 8;
            this.charga3.Name = "charga3";
            this.charga3.ReadOnly = true;
            // 
            // cpesan3
            // 
            this.cpesan3.HeaderText = "Pesan";
            this.cpesan3.MinimumWidth = 8;
            this.cpesan3.Name = "cpesan3";
            this.cpesan3.ReadOnly = true;
            this.cpesan3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // llainlain
            // 
            this.llainlain.BackColor = System.Drawing.Color.Pink;
            this.llainlain.Location = new System.Drawing.Point(837, 171);
            this.llainlain.Name = "llainlain";
            this.llainlain.Size = new System.Drawing.Size(389, 23);
            this.llainlain.TabIndex = 11;
            this.llainlain.Text = "Lain-lain";
            this.llainlain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tnokamar
            // 
            this.tnokamar.AnimateReadOnly = false;
            this.tnokamar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tnokamar.Depth = 0;
            this.tnokamar.Enabled = false;
            this.tnokamar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tnokamar.Hint = "No Kamar";
            this.tnokamar.LeadingIcon = null;
            this.tnokamar.Location = new System.Drawing.Point(382, 105);
            this.tnokamar.MaxLength = 50;
            this.tnokamar.MouseState = MaterialSkin.MouseState.OUT;
            this.tnokamar.Multiline = false;
            this.tnokamar.Name = "tnokamar";
            this.tnokamar.Size = new System.Drawing.Size(131, 50);
            this.tnokamar.TabIndex = 0;
            this.tnokamar.Text = "";
            this.tnokamar.TrailingIcon = null;
            // 
            // lketharga
            // 
            this.lketharga.AutoSize = true;
            this.lketharga.ForeColor = System.Drawing.Color.DarkOrange;
            this.lketharga.Location = new System.Drawing.Point(1080, 105);
            this.lketharga.Name = "lketharga";
            this.lketharga.Size = new System.Drawing.Size(111, 20);
            this.lketharga.TabIndex = 14;
            this.lketharga.Text = "Total Pesanan";
            // 
            // ltotalharga
            // 
            this.ltotalharga.AutoSize = true;
            this.ltotalharga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ltotalharga.ForeColor = System.Drawing.Color.DarkOrange;
            this.ltotalharga.Location = new System.Drawing.Point(1102, 125);
            this.ltotalharga.Name = "ltotalharga";
            this.ltotalharga.Size = new System.Drawing.Size(97, 29);
            this.ltotalharga.TabIndex = 12;
            this.ltotalharga.Text = "000 000";
            // 
            // lrp
            // 
            this.lrp.AutoSize = true;
            this.lrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lrp.ForeColor = System.Drawing.Color.DarkOrange;
            this.lrp.Location = new System.Drawing.Point(1056, 125);
            this.lrp.Name = "lrp";
            this.lrp.Size = new System.Drawing.Size(50, 29);
            this.lrp.TabIndex = 13;
            this.lrp.Text = "Rp.";
            // 
            // FormPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 554);
            this.Controls.Add(this.lketharga);
            this.Controls.Add(this.ltotalharga);
            this.Controls.Add(this.lrp);
            this.Controls.Add(this.llainlain);
            this.Controls.Add(this.lmakanan);
            this.Controls.Add(this.lbed);
            this.Controls.Add(this.dlainlain);
            this.Controls.Add(this.dmakanan);
            this.Controls.Add(this.dbed);
            this.Controls.Add(this.tresid);
            this.Controls.Add(this.tnokamar);
            this.Controls.Add(this.tpelangganid);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPesan";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesan";
            this.Load += new System.EventHandler(this.FormPesan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmakanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlainlain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tpelangganid;
        private System.Windows.Forms.DataGridView dbed;
        private MaterialSkin.Controls.MaterialTextBox tresid;
        private System.Windows.Forms.Label lbed;
        private System.Windows.Forms.DataGridView dmakanan;
        private System.Windows.Forms.Label lmakanan;
        private System.Windows.Forms.DataGridView dlainlain;
        private System.Windows.Forms.Label llainlain;
        private MaterialSkin.Controls.MaterialTextBox tnokamar;
        private System.Windows.Forms.Label lketharga;
        private System.Windows.Forms.Label ltotalharga;
        private System.Windows.Forms.Label lrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpelayanan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn charga1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cpesan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpelayanan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn charga2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cpesan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpelayanan3;
        private System.Windows.Forms.DataGridViewTextBoxColumn charga3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cpesan3;
    }
}