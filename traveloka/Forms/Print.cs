using enlimahotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traveloka
{
    public partial class Print : Form
    {
        db_enlimahotelEntities db;
        public Print(string resid, string totalpesanan)
        {
            InitializeComponent();
            db = new db_enlimahotelEntities();
            var hotel = db.tbl_hotel.Where(a=>a.hotel_id == 1).FirstOrDefault();
            using (MemoryStream ms = new MemoryStream(hotel.logo_hotel))
            {
                plogo.Image = Image.FromStream(ms);
            }
            plogo.SizeMode = PictureBoxSizeMode.StretchImage;
            var res = db.tbl_reservasi.Where(a => a.reservasi_id == resid).FirstOrDefault();
            lreservasiid.Text = resid;
            lcheckin.Text = res.tanggal_checkin.Value.Date.ToString("dd/MM/yyyy");
            lcheckout.Text = res.tanggal_checkout.Value.Date.ToString("dd/MM/yyyy");
            lnokamar.Text = res.kamar_id.ToString();
            ltotalharga.Text = res.total_bayar.ToString();
            var pesanan = (from pes in db.tbl_pesanan.Where(a => a.reservasi_id == res.reservasi_id) join pel in db.tbl_pelayanan on pes.pelayanan_id equals pel.pelayanan_id select new
            {
                pes.pesanan_id,
                pes.reservasi_id,
                pel.nama_pelayanan,
                pes.harga
            }).ToList();
            dpes.DataSource = pesanan;
            totalbayar.Text = res.total_bayar.ToString();
            ltotalpesanan.Text = totalpesanan;
            var pelanggan = db.tbl_pelanggan.Where(a=>a.pelanggan_id == res.pelanggan_id).FirstOrDefault();
            lnama.Text = pelanggan.nama;
            lemail.Text = pelanggan.email;
            lnomortelepon.Text = pelanggan.nomor_telepon;
            ldateprint.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            lstatus.Text = res.status;
            lnamahotel.Text = hotel.nama_hotel;
        }
        private void pd_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y,0,0, s);
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
        Bitmap memoryImage;

        private void PrintCheckin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PrintDialog p = new PrintDialog();
                if (p.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                    this.Close();
                }
            }else if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
