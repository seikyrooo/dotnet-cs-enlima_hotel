using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static traveloka.GlobalClass;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using enlimahotel;

namespace traveloka.CustomMaterial
{
    public partial class CustomReport : Form
    {
        db_enlimahotelEntities db;
        public CustomReport(DataGridView dp, Chart dc)
        {
            InitializeComponent();
            t5dbooking.DataSource = dp.DataSource;
            t5chart.Series.Clear();
            t5chart.Series.Add("Pendapatan");
            int currentYear = DateTime.Now.Year;
            for (int i = 1; i <= 12; i++)
            {
                DateTime date = new DateTime(currentYear, i, 1);
                db = new db_enlimahotelEntities();
                var pendapatan = (from res in db.tbl_reservasi.Where(a => a.tanggal_checkout.Value.Month == date.Date.Month) select res.total_bayar).Sum();
                t5chart.Series["Pendapatan"].Points.AddXY(date.Date.ToString("MMMM - yyyy"), pendapatan);
            }



        }
        Bitmap memoryImage;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void CustomReport_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PrintDialog p = new PrintDialog();
                if (p.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                    this.Close();
                    
                }
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void t5dbooking_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < t5dbooking.Rows.Count; i++)
            {
                db = new db_enlimahotelEntities();
                string id = t5dbooking.Rows[i].Cells["t5cid"].Value.ToString();
                var reservasi = db.tbl_reservasi.Where(a => a.reservasi_id == id).FirstOrDefault();
                t5dbooking.Rows[i].Cells["t5cmalam"].Value = (Convert.ToDateTime(t5dbooking.Rows[i].Cells["t5ccheckout"].Value).Date - Convert.ToDateTime(t5dbooking.Rows[i].Cells["t5ccheckin"].Value).Date).TotalDays + " Malam";
                var pesanan = (from pes in db.tbl_pesanan.Where(a => a.reservasi_id == id) select pes.harga).Sum();
                if (pesanan > 0)
                {
                    t5dbooking.Rows[i].Cells["t5cbiayapesanan"].Value = pesanan;
                }
                else
                {
                    t5dbooking.Rows[i].Cells["t5cbiayapesanan"].Value = 0;

                }
            }
        }
    }
}
