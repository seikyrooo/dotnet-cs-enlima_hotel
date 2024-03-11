namespace traveloka.CustomMaterial
{
    partial class CustomReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomReport));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.t5pprint = new System.Windows.Forms.Panel();
            this.t5chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.t5dbooking = new System.Windows.Forms.DataGridView();
            this.t5cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5cpelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5ckamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5cstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5ccheckin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5ccheckout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5ctotalbayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5cmalam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5cbiayakamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5cbiayapesanan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t5pprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t5chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5dbooking)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // t5pprint
            // 
            this.t5pprint.Controls.Add(this.t5chart);
            this.t5pprint.Controls.Add(this.t5dbooking);
            this.t5pprint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t5pprint.Location = new System.Drawing.Point(0, 0);
            this.t5pprint.Name = "t5pprint";
            this.t5pprint.Size = new System.Drawing.Size(928, 800);
            this.t5pprint.TabIndex = 14;
            // 
            // t5chart
            // 
            chartArea1.Name = "ChartArea1";
            this.t5chart.ChartAreas.Add(chartArea1);
            this.t5chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.t5chart.Enabled = false;
            legend1.Name = "Legend1";
            this.t5chart.Legends.Add(legend1);
            this.t5chart.Location = new System.Drawing.Point(0, 509);
            this.t5chart.Name = "t5chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Pendapatan";
            this.t5chart.Series.Add(series1);
            this.t5chart.Size = new System.Drawing.Size(928, 291);
            this.t5chart.TabIndex = 13;
            this.t5chart.Text = "Pendapatan";
            // 
            // t5dbooking
            // 
            this.t5dbooking.AllowUserToAddRows = false;
            this.t5dbooking.AllowUserToDeleteRows = false;
            this.t5dbooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.t5dbooking.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.t5dbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.t5dbooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t5cid,
            this.t5cpelanggan,
            this.t5ckamar,
            this.t5cstatus,
            this.t5ccheckin,
            this.t5ccheckout,
            this.t5ctotalbayar,
            this.t5cmalam,
            this.t5cbiayakamar,
            this.t5cbiayapesanan});
            this.t5dbooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t5dbooking.Enabled = false;
            this.t5dbooking.Location = new System.Drawing.Point(0, 0);
            this.t5dbooking.Name = "t5dbooking";
            this.t5dbooking.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.t5dbooking.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.t5dbooking.RowHeadersVisible = false;
            this.t5dbooking.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.t5dbooking.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.t5dbooking.RowTemplate.Height = 28;
            this.t5dbooking.Size = new System.Drawing.Size(928, 800);
            this.t5dbooking.TabIndex = 12;
            this.t5dbooking.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.t5dbooking_RowsAdded);
            // 
            // t5cid
            // 
            this.t5cid.DataPropertyName = "reservasi_id";
            this.t5cid.HeaderText = "ID";
            this.t5cid.MinimumWidth = 8;
            this.t5cid.Name = "t5cid";
            this.t5cid.ReadOnly = true;
            this.t5cid.Visible = false;
            // 
            // t5cpelanggan
            // 
            this.t5cpelanggan.DataPropertyName = "nama";
            this.t5cpelanggan.HeaderText = "Pelanggan";
            this.t5cpelanggan.MinimumWidth = 8;
            this.t5cpelanggan.Name = "t5cpelanggan";
            this.t5cpelanggan.ReadOnly = true;
            // 
            // t5ckamar
            // 
            this.t5ckamar.DataPropertyName = "kamar_id";
            this.t5ckamar.HeaderText = "No Kamar";
            this.t5ckamar.MinimumWidth = 8;
            this.t5ckamar.Name = "t5ckamar";
            this.t5ckamar.ReadOnly = true;
            // 
            // t5cstatus
            // 
            this.t5cstatus.DataPropertyName = "status";
            this.t5cstatus.HeaderText = "Status";
            this.t5cstatus.MinimumWidth = 8;
            this.t5cstatus.Name = "t5cstatus";
            this.t5cstatus.ReadOnly = true;
            // 
            // t5ccheckin
            // 
            this.t5ccheckin.DataPropertyName = "tanggal_checkin";
            this.t5ccheckin.HeaderText = "Check In";
            this.t5ccheckin.MinimumWidth = 8;
            this.t5ccheckin.Name = "t5ccheckin";
            this.t5ccheckin.ReadOnly = true;
            // 
            // t5ccheckout
            // 
            this.t5ccheckout.DataPropertyName = "tanggal_checkout";
            this.t5ccheckout.HeaderText = "Check Out";
            this.t5ccheckout.MinimumWidth = 8;
            this.t5ccheckout.Name = "t5ccheckout";
            this.t5ccheckout.ReadOnly = true;
            // 
            // t5ctotalbayar
            // 
            this.t5ctotalbayar.DataPropertyName = "total_bayar";
            this.t5ctotalbayar.HeaderText = "Total Bayar";
            this.t5ctotalbayar.MinimumWidth = 8;
            this.t5ctotalbayar.Name = "t5ctotalbayar";
            this.t5ctotalbayar.ReadOnly = true;
            // 
            // t5cmalam
            // 
            this.t5cmalam.HeaderText = "Hari";
            this.t5cmalam.MinimumWidth = 8;
            this.t5cmalam.Name = "t5cmalam";
            this.t5cmalam.ReadOnly = true;
            // 
            // t5cbiayakamar
            // 
            this.t5cbiayakamar.DataPropertyName = "tarif_kamar";
            this.t5cbiayakamar.HeaderText = "Biaya Kamar";
            this.t5cbiayakamar.MinimumWidth = 8;
            this.t5cbiayakamar.Name = "t5cbiayakamar";
            this.t5cbiayakamar.ReadOnly = true;
            // 
            // t5cbiayapesanan
            // 
            this.t5cbiayapesanan.HeaderText = "Biaya Pesanan";
            this.t5cbiayapesanan.MinimumWidth = 8;
            this.t5cbiayapesanan.Name = "t5cbiayapesanan";
            this.t5cbiayapesanan.ReadOnly = true;
            // 
            // CustomReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 800);
            this.Controls.Add(this.t5pprint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomReport";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomReport_KeyPress);
            this.t5pprint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t5chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5dbooking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        public System.Windows.Forms.Panel t5pprint;
        private System.Windows.Forms.DataVisualization.Charting.Chart t5chart;
        private System.Windows.Forms.DataGridView t5dbooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5cpelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5ckamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5cstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5ccheckin;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5ccheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5ctotalbayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5cmalam;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5cbiayakamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn t5cbiayapesanan;
    }
}