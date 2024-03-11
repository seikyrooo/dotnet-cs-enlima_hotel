using enlimahotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static traveloka.GlobalClass;

namespace traveloka
{
    public partial class CustomPanel : Form
    {
        db_enlimahotelEntities db;
        public CustomPanel(string buttonname, Image image, string title, string price, string buttontxt, string subtitle)
        {
            InitializeComponent();
            ppicture.Image = image;
            ppicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ltitle.Text = title;
            lharga.Text = price;
            baction.Text = buttontxt;
            baction.Name = buttonname;
            lsubtitle.Text = subtitle;
            bdetail.Name = buttonname;
        }
        string LoadReservationId()
        {
            db =new db_enlimahotelEntities();
            var max = (from res in db.tbl_reservasi select res.reservasi_id).Max();
            long hitung;
            string urutan;
            if (max != null )
            {
                hitung = Convert.ToInt32(max.Substring(max.Length - 4, 4)) + 1;
                string urutankode = "0000" + hitung;
                urutan = "RE" + DateTime.Now.Date.Year + urutankode.Substring(urutankode.Length - 4, 4);
            }
            else
            {
                urutan = "RE" + DateTime.Now.Date.Year + "0001";
            }
            return urutan;
        }
        private void baction_Click(object sender, EventArgs e)
        {
            if (GlobalBooking.cmalam.Text == string.Empty || GlobalBooking.cpelangganid.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi Data Booking terlebih dahulu!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db = new db_enlimahotelEntities();
                var kamar = db.tbl_kamar.Where(a => a.kamar_id.ToString() == baction.Name).FirstOrDefault();
                int totalbayar = 0;
                db = new db_enlimahotelEntities();
                var reservation = new tbl_reservasi();
                var pelanggan = db.tbl_pelanggan.Where(a => a.nama == GlobalBooking.cpelangganid.Text).FirstOrDefault();
                reservation.reservasi_id = LoadReservationId();
                reservation.pelanggan_id = pelanggan.pelanggan_id;
                reservation.kamar_id = Convert.ToInt32(baction.Name);
                reservation.tanggal_checkin = GlobalBooking.dcheckin.Value.Date;
                reservation.tanggal_checkout = GlobalBooking.dcheckout.Value.Date;
                reservation.extra_bed = false;
                if (GlobalBooking.ccheckin.Checked)
                {
                    reservation.status = "Checked In";
                }
                else
                {
                    reservation.status = "Reserved";
                }
                reservation.jumlah_tamu = Convert.ToInt32(GlobalBooking.cjumlahpelanggan.Text);
                totalbayar += Convert.ToInt32(kamar.tarif_kamar * Convert.ToInt32(GlobalBooking.cmalam.Text));
                if (GlobalBooking.csarapan.Checked)
                {
                    reservation.sarapan = true;
                    totalbayar += 50000;
                }
                else
                {
                    reservation.sarapan = false;
                }
                reservation.total_bayar = totalbayar;
                reservation.user_id = vuserid;
               
                DialogResult result = MessageBox.Show("Konfirmasi Booking dari Pelanggan " + pelanggan.nama + " dengan total pembayaran awal " + totalbayar, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    db.tbl_reservasi.Add(reservation);
                    db.SaveChanges();
                    db = new db_enlimahotelEntities();
                    var kamaredit = db.tbl_kamar.Where(a => a.kamar_id.ToString() == baction.Name).FirstOrDefault();
                    kamaredit.tersedia = GlobalBooking.dcheckout.Value.Date;
                    db.SaveChanges();
                    this.Close();
                }

            }
        }

        private void bdetail_Click(object sender, EventArgs e)
        {
            FormRoomDetail frd = new FormRoomDetail(Convert.ToInt32(baction.Name));
            frd.ShowDialog();
        }
    }
}
