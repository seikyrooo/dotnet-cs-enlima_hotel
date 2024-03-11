using enlimahotel;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace traveloka
{
    public partial class FormPesan : MaterialForm
    {
        db_enlimahotelEntities db;
        int hargapesan = 0;
        public FormPesan(string resid, string pelanggan, int kamarid, int harga)
        {
            InitializeComponent();
            tresid.Text = resid;
            tpelangganid.Text = pelanggan;
            tnokamar.Text= kamarid.ToString();
            db = new db_enlimahotelEntities();
            var kamar = db.tbl_kamar.Where(a => a.kamar_id == kamarid && a.extra_bed == true).FirstOrDefault();
            if (harga != 0)
            {
                hargapesan = harga;
            }
            ltotalharga.Text = hargapesan.ToString();
            if (kamar != null)
            {
                lbed.Text = "Support Extra Bed";
                dbed.Enabled = true;
            }
            else
            {
                lbed.Text = "Not Support Extra Bed";
                dbed.Enabled = false;
            }
        }
        void LoadallTable()
        {
            db = new db_enlimahotelEntities();
            var bed = (from pel in db.tbl_pelayanan.Where(a => a.kategori == "Bed")
                       select new
                       {
                           pel.pelayanan_id,
                           pel.nama_pelayanan,
                           pel.harga_pelayanan
                       }).ToList();
            dbed.DataSource = bed;

            var makanan = (from pel in db.tbl_pelayanan.Where(a => a.kategori == "Makanan")
                       select new
                       {
                           pel.pelayanan_id,
                           pel.nama_pelayanan,
                           pel.harga_pelayanan
                       }).ToList();
            dmakanan.DataSource = makanan;

            var lainlain = (from pel in db.tbl_pelayanan.Where(a => a.kategori == "Lain-lain")
                       select new
                       {
                           pel.pelayanan_id,
                           pel.nama_pelayanan,
                           pel.harga_pelayanan
                       }).ToList();
            dlainlain.DataSource = lainlain;
        }

        private void FormPesan_Load(object sender, EventArgs e)
        {
            LoadallTable();
        }
        private void dbed_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dbed.Rows.Count; i++)
            {
                int pelid = Convert.ToInt32(dbed.Rows[i].Cells["cid1"].Value);
                db = new db_enlimahotelEntities();
                var pesan = db.tbl_pesanan.Where(a => a.reservasi_id == tresid.Text && a.pelayanan_id == pelid).FirstOrDefault();
                if (pesan != null)
                {
                    dbed.Rows[i].Cells["cpesan1"].Value = true;
                }
                else
                {
                    dbed.Rows[i].Cells["cpesan1"].Value = false;
                }
            }
            
        }

        private void dmakanan_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dmakanan.Rows.Count; i++)
            {
                db = new db_enlimahotelEntities();
                int pelid = Convert.ToInt32(dmakanan.Rows[i].Cells["cid2"].Value);
                var pesan = db.tbl_pesanan.Where(a => a.reservasi_id == tresid.Text && a.pelayanan_id == pelid).FirstOrDefault();
                if (pesan != null)
                {
                    dmakanan.Rows[i].Cells["cpesan2"].Value = true;
                }
                else
                {
                    dmakanan.Rows[i].Cells["cpesan2"].Value = false;
                }
            }
        }

        private void dlainlain_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dlainlain.Rows.Count; i++)
            {
                db = new db_enlimahotelEntities();
                int pelid = Convert.ToInt32(dlainlain.Rows[i].Cells["cid3"].Value);
                var pesan = db.tbl_pesanan.Where(a => a.reservasi_id == tresid.Text && a.pelayanan_id == pelid).FirstOrDefault();
                if (pesan != null)
                {
                    dlainlain.Rows[i].Cells["cpesan3"].Value = true;
                }
                else
                {
                    dlainlain.Rows[i].Cells["cpesan3"].Value = false;
                }
            }
        }

        private void dbed_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dbed.Columns["cpesan1"].Index)
                {
                    switch (dbed.Rows[e.RowIndex].Cells["cpesan1"].Value)
                    {
                        case true:
                            db = new db_enlimahotelEntities();
                            var pesan = db.tbl_pesanan.Where(a=>a.reservasi_id == tresid.Text).FirstOrDefault();
                            dbed.Rows[e.RowIndex].Cells["cpesan1"].Value = false;
                            db.tbl_pesanan.Remove(pesan);
                            db.SaveChanges();
                            hargapesan -= Convert.ToInt32(dbed.Rows[e.RowIndex].Cells["charga1"].Value);
                            ltotalharga.Text = hargapesan.ToString();
                            break;
                        case false:
                            dbed.Rows[e.RowIndex].Cells["cpesan1"].Value = true;
                            db = new db_enlimahotelEntities();
                            tbl_pesanan tambahpesan = new tbl_pesanan();
                            tambahpesan.reservasi_id = tresid.Text;
                            tambahpesan.pelayanan_id = Convert.ToInt32(dbed.Rows[e.RowIndex].Cells["cid1"].Value);
                            tambahpesan.harga = Convert.ToInt32(dbed.Rows[e.RowIndex].Cells["charga1"].Value);
                            db.tbl_pesanan.Add(tambahpesan);
                            db.SaveChanges();
                            db = new db_enlimahotelEntities();
                            var res = db.tbl_reservasi.Where(a => a.reservasi_id == tresid.Text).FirstOrDefault();
                            res.total_bayar += tambahpesan.harga;
                            db.SaveChanges();
                            hargapesan += Convert.ToInt32(dbed.Rows[e.RowIndex].Cells["charga1"].Value);
                            ltotalharga.Text = hargapesan.ToString();
                            break;
                    }
                }
            }
        }

        private void dmakanan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dmakanan.Columns["cpesan2"].Index)
                {
                    switch (dmakanan.Rows[e.RowIndex].Cells["cpesan2"].Value)
                    {
                        case true:
                            db = new db_enlimahotelEntities();
                            var pesan = db.tbl_pesanan.Where(a => a.reservasi_id == tresid.Text).FirstOrDefault();
                            dmakanan.Rows[e.RowIndex].Cells["cpesan2"].Value = false;
                            db.tbl_pesanan.Remove(pesan);
                            db.SaveChanges();
                            db = new db_enlimahotelEntities();
                            var reser = db.tbl_reservasi.Where(a => a.reservasi_id == tresid.Text).FirstOrDefault();
                            reser.total_bayar -= pesan.harga;
                            db.SaveChanges();
                            hargapesan -= Convert.ToInt32(dmakanan.Rows[e.RowIndex].Cells["charga2"].Value);
                            ltotalharga.Text = hargapesan.ToString();
                            break;
                        case false:
                            dmakanan.Rows[e.RowIndex].Cells["cpesan2"].Value = true;
                            db = new db_enlimahotelEntities();
                            tbl_pesanan tambahpesan = new tbl_pesanan();
                            tambahpesan.reservasi_id = tresid.Text;
                            tambahpesan.pelayanan_id = Convert.ToInt32(dmakanan.Rows[e.RowIndex].Cells["cid2"].Value);
                            tambahpesan.harga = Convert.ToInt32(dmakanan.Rows[e.RowIndex].Cells["charga2"].Value);
                            db.tbl_pesanan.Add(tambahpesan);
                            db.SaveChanges();
                            db = new db_enlimahotelEntities();
                            var res = db.tbl_reservasi.Where(a => a.reservasi_id == tresid.Text).FirstOrDefault();
                            res.total_bayar += tambahpesan.harga;
                            db.SaveChanges();
                            hargapesan += Convert.ToInt32(dmakanan.Rows[e.RowIndex].Cells["charga2"].Value);
                            ltotalharga.Text = hargapesan.ToString();
                            break;
                    }
                }
            }
        }

        private void dlainlain_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dlainlain.Columns["cpesan3"].Index)
                {
                    switch (dlainlain.Rows[e.RowIndex].Cells["cpesan3"].Value)
                    {
                        case true:
                            db = new db_enlimahotelEntities();
                            var pesan = db.tbl_pesanan.Where(a => a.reservasi_id == tresid.Text).FirstOrDefault();
                            dlainlain.Rows[e.RowIndex].Cells["cpesan3"].Value = false;
                            db.tbl_pesanan.Remove(pesan);
                            db.SaveChanges();
                            hargapesan -= Convert.ToInt32(dlainlain.Rows[e.RowIndex].Cells["charga3"].Value);
                            ltotalharga.Text = hargapesan.ToString();
                            break;
                        case false:
                            dlainlain.Rows[e.RowIndex].Cells["cpesan3"].Value = true;
                            db = new db_enlimahotelEntities();
                            tbl_pesanan tambahpesan = new tbl_pesanan();
                            tambahpesan.reservasi_id = tresid.Text;
                            tambahpesan.pelayanan_id = Convert.ToInt32(dlainlain.Rows[e.RowIndex].Cells["cid3"].Value);
                            tambahpesan.harga = Convert.ToInt32(dlainlain.Rows[e.RowIndex].Cells["charga3"].Value);
                            db.tbl_pesanan.Add(tambahpesan);
                            db.SaveChanges();
                            db = new db_enlimahotelEntities();
                            var res = db.tbl_reservasi.Where(a=>a.reservasi_id == tresid.Text).FirstOrDefault();
                            res.total_bayar += tambahpesan.harga;
                            db.SaveChanges();
                            hargapesan += Convert.ToInt32(dlainlain.Rows[e.RowIndex].Cells["charga3"].Value);
                            ltotalharga.Text = hargapesan.ToString();
                            break;
                    }
                }
            }
        }
    }
}
