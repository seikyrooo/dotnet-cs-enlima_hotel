using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using System.IO;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Common;
using static traveloka.GlobalClass;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing.Imaging;
using MaterialSkin;
using System.Windows.Media.Media3D;
using traveloka.CustomMaterial;
using enlimahotel;
using enlimahotel.Forms;

namespace traveloka
{
    public partial class FormMain : MaterialForm
    {
        db_enlimahotelEntities db;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public FormMain(string role)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            if (role == "admin")
            {
                if (tmain.TabCount == 6)
                {
                    tmain.TabPages.Add(t5);
                    tmain.TabPages.Add(t7);
                }
            }
            else
            {
                tmain.TabPages.Remove(t5);
                tmain.TabPages.Remove(t7);

            }

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            Loadprofilhotel();
            Loadchart();
            this.Text = t1tnamahotel.Text;
            Loadtablepelanggan();
            Loadtablebooking();
            Loadtableroom();
            LoadDefault();
            Loadtablepelanggan();
            Loadtableusers();
            LoadtablePelayanan();
            Loadprofil();
            Notif();
        }
        private void FormMain_Activated(object sender, EventArgs e) 
        {
            Loadprofilhotel();
            Loadchart();
            this.Text = t1tnamahotel.Text;
            Loadtablepelanggan();
            Loadtablebooking();
            Loadtableroom();
            LoadDefault();
            Loadtablepelanggan();
            Loadtableusers();
            LoadtablePelayanan();
            Loadprofil();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Yakin ingin Logout?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                e.Cancel = false;
                GlobalLogin.Show();
            }
            else
            {
                e.Cancel = true;
            }
        }

        //Tab1  
        private void Loadprofilhotel()
        {
            db = new db_enlimahotelEntities();
            var hotel = db.tbl_hotel.Where(a => a.hotel_id == 1).FirstOrDefault();
            
            t1tnamahotel.Text = hotel.nama_hotel;
            t1tnomortelepon.Text = hotel.nomor_telepon;
            t1talamat.Text = hotel.alamat;
            t1tkapasitaskamar.Text = hotel.kapasitas_kamar.ToString();
            if (hotel.logo_hotel != null)
            {
                using (MemoryStream ms = new MemoryStream(hotel.logo_hotel))
                {
                    Image image = Image.FromStream(ms);
                    t1plogohotel.Image = image;
                    t1plogohotel.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            int totalkamar = db.tbl_kamar.Count();
            int totalpelanggan = db.tbl_pelanggan.Count();
            t1langkakamar.Text = totalkamar.ToString();
            t1langkapelanggan.Text = totalpelanggan.ToString();
        }
        private void t1tkapasitaskamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Kolom ini Berformat Angka", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void t1tnomortelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Kolom ini Berformat Angka", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void Loadchart()
        {
            t1cpendapatan.Series.Clear();
            t1cpendapatan.Series.Add("Pendapatan");
            for (int i = 0; i < 5; i++)
            {
                DateTime bulan = DateTime.Now.AddMonths(-i);
                var pendapatan = (from res in db.tbl_reservasi.Where(a => a.tanggal_checkout.Value.Month == bulan.Date.Month) select res.total_bayar).Sum();
                t1cpendapatan.Series["Pendapatan"].Points.AddXY(bulan.Date.ToString("MMMM"), pendapatan);
            }
        }
        private void t1bsimpan_Click(object sender, EventArgs e)
        {
            if (t1tnamahotel.Text != string.Empty && t1tnomortelepon.Text != string.Empty && t1talamat.Text != string.Empty && t1tkapasitaskamar.Text != string.Empty)
            {
                db = new db_enlimahotelEntities();
                var room = (from kam in db.tbl_kamar select kam.kamar_id).Max();
                if (Convert.ToInt32(t1tkapasitaskamar.Text) < room)
                {
                    MessageBox.Show("Anda tidak bisa mengurangi Kapasitas, karena Kamar dengan No tertinggi adalah " + room, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db = new db_enlimahotelEntities();
                    var hotel = db.tbl_hotel.Where(a => a.hotel_id == 1).FirstOrDefault();
                    hotel.nama_hotel = t1tnamahotel.Text;
                    hotel.nomor_telepon = t1tnomortelepon.Text;
                    hotel.alamat = t1talamat.Text;
                    hotel.kapasitas_kamar = Convert.ToInt32(t1tkapasitaskamar.Text);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Update", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Silahkan isi Kolom diatas !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void t1plogohotel_Click(object sender, EventArgs e)
        {
            t1ofd.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            if (t1ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] imageData = File.ReadAllBytes(t1ofd.FileName);
                db = new db_enlimahotelEntities();
                var hotel = db.tbl_hotel.Where(a => a.hotel_id == 1).FirstOrDefault();
                hotel.logo_hotel = imageData;
                db.SaveChanges();
                MessageBox.Show("Logo berhasil diubah", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    t1plogohotel.Image = Image.FromStream(ms);
                    t1plogohotel.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                MessageBox.Show("Dibatalkan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void t1brefresh_Click(object sender, EventArgs e)
        {
            Loadprofilhotel();
        }

        //Tab2
        void Notif()
        {
            int totalcheckin = 0;
            int totalcheckout = 0;
            foreach (DataGridViewRow row in t2dbooking.Rows)
            {
                if (Convert.ToDateTime(row.Cells["t2ccheckin"].Value).Date < DateTime.Now.Date && row.Cells["t2cstatus"].Value.ToString() == "Reserved")
                {
                    totalcheckin += 1;
                }
                if (Convert.ToDateTime(row.Cells["t2ccheckout"].Value).Date < DateTime.Now.Date && row.Cells["t2cstatus"].Value.ToString() == "Checked In")
                {
                    totalcheckout += 1;
                }
            }
            if (totalcheckin > 0 && totalcheckout > 0)
            {
                MessageBox.Show("Anda memiliki " + totalcheckin + " data yang telat Check-in dan " + totalcheckout + " data yang telat Check-out, Silahkan hubungi Customer terkait!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (totalcheckin > 0 && totalcheckout == 0)
            {
                MessageBox.Show("Anda memiliki " + totalcheckin + " data yang telat Check-in, Silahkan hubungi Customer terkait!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (totalcheckin == 0 && totalcheckout > 0)
            {
                MessageBox.Show("Anda memiliki " + totalcheckout + " data yang telat Check-out, Silahkan hubungi Customer terkait!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        void Loadtablebooking()
        {
            db = new db_enlimahotelEntities();
            var reservasi = (from res in db.tbl_reservasi join pel in db.tbl_pelanggan on res.pelanggan_id equals pel.pelanggan_id join kam in db.tbl_kamar on res.kamar_id equals kam.kamar_id select new
            {
                res.reservasi_id,
                pel.nama,
                res.kamar_id,
                res.status,
                res.tanggal_checkin,
                res.tanggal_checkout,
                res.total_bayar,
                kam.tarif_kamar
            }).ToList();
            t2dbooking.DataSource = reservasi;
            t2cpesan.FlatStyle = FlatStyle.Popup;
            t2cpesan.DefaultCellStyle.BackColor = Color.SkyBlue;
            t2cdelete.FlatStyle = FlatStyle.Popup;
            t2cdelete.DefaultCellStyle.BackColor = Color.Red;
            t2cdelete.DefaultCellStyle.ForeColor = Color.White;
            t2cprint.FlatStyle = FlatStyle.Popup;
            t2cprint.DefaultCellStyle.BackColor = Color.Green;
            t2cprint.DefaultCellStyle.ForeColor = Color.White;
            
        }
        private void t2dbooking_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == t2dbooking.Columns["t2ccheckin"].Index && t2dbooking.Rows[e.RowIndex].Cells["t2cstatus"].Value.ToString() == "Reserved" && Convert.ToDateTime(t2dbooking.Rows[e.RowIndex].Cells["t2ccheckin"].Value).Date < DateTime.Now.Date)
            {
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
            if (e.ColumnIndex == t2dbooking.Columns["t2ccheckin"].Index && t2dbooking.Rows[e.RowIndex].Cells["t2cstatus"].Value.ToString() == "Reserved" && Convert.ToDateTime(t2dbooking.Rows[e.RowIndex].Cells["t2ccheckin"].Value).Date == DateTime.Now.Date)
            {
                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;
            }
            if (e.ColumnIndex == t2dbooking.Columns["t2ccheckout"].Index && t2dbooking.Rows[e.RowIndex].Cells["t2cstatus"].Value.ToString() == "Checked In" && Convert.ToDateTime(t2dbooking.Rows[e.RowIndex].Cells["t2ccheckout"].Value).Date < DateTime.Now.Date)
            {
                e.CellStyle.BackColor = Color.Red;
                e.CellStyle.ForeColor = Color.White;
            }
            if (e.ColumnIndex == t2dbooking.Columns["t2ccheckout"].Index && t2dbooking.Rows[e.RowIndex].Cells["t2cstatus"].Value.ToString() == "Checked In" && Convert.ToDateTime(t2dbooking.Rows[e.RowIndex].Cells["t2ccheckout"].Value).Date == DateTime.Now.Date)
            {
                e.CellStyle.BackColor = Color.Green;
                e.CellStyle.ForeColor = Color.White;
            }


        }
        private void t2cfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t2cfilter.Text == "All")
            {
                t2cfilter.SelectedIndex = -1;
                Loadtablebooking();
                
            }
            else
            {
                db = new db_enlimahotelEntities();
                var reservasi = (from res in db.tbl_reservasi
                                 join pel in db.tbl_pelanggan on res.pelanggan_id equals pel.pelanggan_id
                                 join kam in db.tbl_kamar on res.kamar_id equals kam.kamar_id
                                 select new
                                 {
                                     res.reservasi_id,
                                     pel.nama,
                                     res.kamar_id,
                                     res.status,
                                     res.tanggal_checkin,
                                     res.tanggal_checkout,
                                     res.total_bayar,
                                     kam.tarif_kamar
                                 }).Where(a=>a.status == t2cfilter.Text).ToList();
                t2dbooking.DataSource = reservasi;
            }
        }

        private void t2brefresh_Click(object sender, EventArgs e)
        {
            t2cfilter.SelectedIndex = -1;
            t2tsearch.Text = string.Empty;
            
            Loadtablebooking();
            Notif();
        }

        private void t2tsearch_TextChanged(object sender, EventArgs e)
        {
            if (t2tsearch.Text != string.Empty)
            {
                db = new db_enlimahotelEntities();
                var reservasi = (from res in db.tbl_reservasi
                                 join pel in db.tbl_pelanggan on res.pelanggan_id equals pel.pelanggan_id
                                 join kam in db.tbl_kamar on res.kamar_id equals kam.kamar_id
                                 select new
                                 {
                                     res.reservasi_id,
                                     pel.nama,
                                     res.kamar_id,
                                     res.status,
                                     res.tanggal_checkin,
                                     res.tanggal_checkout,
                                     res.total_bayar,
                                     kam.tarif_kamar
                                 }).Where(a => a.nama.StartsWith(t2tsearch.Text) || a.kamar_id.ToString().StartsWith(t2tsearch.Text)).ToList();
                t2dbooking.DataSource = reservasi;
            }
            else
            {
                Loadtablebooking();
            }
        }

        private void t2dbooking_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < t2dbooking.Rows.Count; i++)
            {
                db = new db_enlimahotelEntities();
                string id = t2dbooking.Rows[i].Cells["t2cid"].Value.ToString();
                var reservasi = db.tbl_reservasi.Where(a => a.reservasi_id == id).FirstOrDefault();
                
                if (reservasi.sarapan == true)
                {
                    t2dbooking.Rows[i].Cells["t2csarapan"].Value = true;
                }
                else
                {
                    t2dbooking.Rows[i].Cells["t2csarapan"].Value = false;
                }
                if (reservasi.status == "Checked In")
                {
                    t2dbooking.Rows[i].Cells["t2ccheckedin"].Value = true;
                    t2dbooking.Rows[i].Cells["t2ccheckedout"].Value = false;
                    t2dbooking.Rows[i].Cells["t2ccancelled"].Value = false;


                }
                else if (reservasi.status == "Checked Out")
                {
                    t2dbooking.Rows[i].Cells["t2ccheckedin"].Value = true;
                    t2dbooking.Rows[i].Cells["t2ccheckedout"].Value = true;
                    t2dbooking.Rows[i].Cells["t2ccancelled"].Value = false;

                }
                else if (reservasi.status == "Reserved")
                {
                    t2dbooking.Rows[i].Cells["t2ccheckedin"].Value = false;
                    t2dbooking.Rows[i].Cells["t2ccheckedout"].Value = false;
                    t2dbooking.Rows[i].Cells["t2ccancelled"].Value = false;

                }
                else
                {
                    t2dbooking.Rows[i].Cells["t2ccheckedin"].Value = false;
                    t2dbooking.Rows[i].Cells["t2ccheckedout"].Value = false;
                    t2dbooking.Rows[i].Cells["t2ccancelled"].Value = true;
                }
                t2dbooking.Rows[i].Cells["t2chari"].Value = (Convert.ToDateTime(t2dbooking.Rows[i].Cells["t2ccheckout"].Value).Date - Convert.ToDateTime(t2dbooking.Rows[i].Cells["t2ccheckin"].Value).Date).TotalDays + " Malam";
                var pesanan = (from pes in db.tbl_pesanan.Where(a => a.reservasi_id == id) select pes.harga).Sum();
                if (pesanan > 0)
                {
                    t2dbooking.Rows[i].Cells["t2cbiayapesanan"].Value = pesanan;
                }
                else
                {
                    t2dbooking.Rows[i].Cells["t2cbiayapesanan"].Value = 0;

                }
            }
        }

        private void t2dbooking_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if(e.ColumnIndex == t2dbooking.Columns["t2cpesan"].Index)
                {
                    FormPesan fp = new FormPesan(t2dbooking.Rows[e.RowIndex].Cells["t2cid"].Value.ToString(), t2dbooking.Rows[e.RowIndex].Cells["t2cpelanggan"].Value.ToString(), Convert.ToInt32(t2dbooking.Rows[e.RowIndex].Cells["t2ckamar"].Value), Convert.ToInt32(t2dbooking.Rows[e.RowIndex].Cells["t2cbiayapesanan"].Value));
                    fp.ShowDialog();
                    
                }
                else if (e.ColumnIndex == t2dbooking.Columns["t2cdelete"].Index)
                {
                    DialogResult result = MessageBox.Show("Yakin ingin Delete Data ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        string id = t2dbooking.Rows[e.RowIndex].Cells["t2cid"].Value.ToString();
                        string kamarid = t2dbooking.Rows[e.RowIndex].Cells["t2ckamar"].Value.ToString();
                        db = new db_enlimahotelEntities();
                        var kamar = db.tbl_kamar.Where(a => a.kamar_id.ToString() == kamarid).FirstOrDefault();
                        kamar.tersedia = DateTime.Now.Date;
                        db.SaveChanges();
                        db = new db_enlimahotelEntities();
                        
                        var reservasi = db.tbl_reservasi.Where(a => a.reservasi_id == id).FirstOrDefault();
                        db.tbl_reservasi.Remove(reservasi);
                        db.SaveChanges();
                        Loadtablebooking();
                        MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (e.ColumnIndex == t2dbooking.Columns["t2ccheckedin"].Index) 
                {
                    switch (t2dbooking.Rows[e.RowIndex].Cells["t2ccheckedin"].Value)
                    {
                        case true:
                            MessageBox.Show("Tidak bisa uncheck data yang sudah di Check In", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case false:
                            if (t2dbooking.Rows[e.RowIndex].Cells["t2cstatus"].Value.ToString() == "Reserved")
                            {
                                string id = t2dbooking.Rows[e.RowIndex].Cells["t2cid"].Value.ToString();
                                DialogResult result = MessageBox.Show("Konfirmasi Check-in pada reservasi " + id, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (result == DialogResult.Yes)
                                {
                                    t2dbooking.Rows[e.RowIndex].Cells["t2ccheckedin"].Value = true;
                                    db = new db_enlimahotelEntities();
                                    var reservasi = db.tbl_reservasi.Where(a => a.reservasi_id == id).FirstOrDefault();
                                    reservasi.status = "Checked In";
                                    db.SaveChanges();
                                    Loadtablebooking();
                                }
                            }
                            else
                            {
                                MessageBox.Show("hanya bisa Check In data yang berstatus Reserved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                            break;
                    }
                }
                else if (e.ColumnIndex == t2dbooking.Columns["t2ccheckedout"].Index)
                {
                    switch (t2dbooking.Rows[e.RowIndex].Cells["t2ccheckedout"].Value)
                    {
                        case true:
                            MessageBox.Show("Tidak bisa uncheck data yang sudah di Check Out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case false:
                            if (t2dbooking.Rows[e.RowIndex].Cells["t2cstatus"].Value.ToString() == "Checked In")
                            {
                                string id = t2dbooking.Rows[e.RowIndex].Cells["t2cid"].Value.ToString();

                                DialogResult result = MessageBox.Show("Konfirmasi Check-out pada reservasi " + id, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (result == DialogResult.Yes)
                                {
                                    t2dbooking.Rows[e.RowIndex].Cells["t2ccheckedout"].Value = true;
                                    db = new db_enlimahotelEntities();
                                    var reservasi = db.tbl_reservasi.Where(a => a.reservasi_id == id).FirstOrDefault();
                                    reservasi.status = "Checked Out";
                                    db.SaveChanges();
                                    db = new db_enlimahotelEntities();
                                    var kamar = db.tbl_kamar.Where(a => a.kamar_id == reservasi.kamar_id).FirstOrDefault();
                                    kamar.tersedia = DateTime.Now.Date;
                                    db.SaveChanges();
                                    Loadtablebooking();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tidak bisa Check Out data yang blm di Check in", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                            break;
                    }
                    
                }
                else if (e.ColumnIndex == t2dbooking.Columns["t2ccancelled"].Index)
                {
                    switch (t2dbooking.Rows[e.RowIndex].Cells["t2ccancelled"].Value)
                    {
                        case true:
                            MessageBox.Show("Tidak bisa uncheck data yang sudah di Cancel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case false:
                            if (t2dbooking.Rows[e.RowIndex].Cells["t2cstatus"].Value.ToString() == "Reserved")
                            {
                                string id = t2dbooking.Rows[e.RowIndex].Cells["t2cid"].Value.ToString();

                                DialogResult result = MessageBox.Show("Konfirmasi Cancel pada reservasi " + id, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (result == DialogResult.Yes)
                                {
                                    t2dbooking.Rows[e.RowIndex].Cells["t2ccancelled"].Value = true;
                                    db = new db_enlimahotelEntities();
                                    var reservasi = db.tbl_reservasi.Where(a => a.reservasi_id == id).FirstOrDefault();
                                    reservasi.status = "Cancelled";
                                    db.SaveChanges();
                                    db = new db_enlimahotelEntities();
                                    var kamar = db.tbl_kamar.Where(a => a.kamar_id == reservasi.kamar_id).FirstOrDefault();
                                    kamar.tersedia = DateTime.Now.Date;
                                    db.SaveChanges();
                                    Loadtablebooking();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tidak bisa Cancel Data yang sudah di Check In atau di Check Out", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                    }
                }
                else if (e.ColumnIndex == t2dbooking.Columns["t2csarapan"].Index)
                {
                    switch (t2dbooking.Rows[e.RowIndex].Cells["t2csarapan"].Value)
                    {
                        case true:
                            MessageBox.Show("Tidak bisa uncheck data yang sudah di Check", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case false:
                            string id = t2dbooking.Rows[e.RowIndex].Cells["t2cid"].Value.ToString();

                            DialogResult result = MessageBox.Show("Konfirmasi Sarapan dengan tambahan harga 50K", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                t2dbooking.Rows[e.RowIndex].Cells["t2csarapan"].Value = true;
                                db = new db_enlimahotelEntities();
                                var reservasi = db.tbl_reservasi.Where(a => a.reservasi_id == id).FirstOrDefault();
                                reservasi.sarapan = true;
                                reservasi.total_bayar += 50000;
                                db.SaveChanges();
                                db = new db_enlimahotelEntities();
                                var kamar = db.tbl_kamar.Where(a => a.kamar_id == reservasi.kamar_id).FirstOrDefault();
                                kamar.tersedia = DateTime.Now.Date;
                                db.SaveChanges();
                                Loadtablebooking();
                            }
                            break;
                    }
                }
                else if (e.ColumnIndex == t2dbooking.Columns["t2cprint"].Index)
                {
                    DialogResult result = MessageBox.Show("Untuk Print Struk Silahkan Tekan Enter setelah Gambar Struk Muncul", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        db = new db_enlimahotelEntities();
                        string id = t2dbooking.Rows[e.RowIndex].Cells["t2cid"].Value.ToString();
                        Print p = new Print(id, t2dbooking.Rows[e.RowIndex].Cells["t2cbiayapesanan"].Value.ToString());
                        p.ShowDialog();
                    }
                }
            }
        }

        private void t2badd_Click(object sender, EventArgs e)
        {
            GlobalBooking = new FormBooking();
            GlobalBooking.ShowDialog();
        }
        //Tab3
        void Loadtableroom()
        {
            db = new db_enlimahotelEntities();
            var room = (from kam in db.tbl_kamar
                        select new
                        {
                            kam.kamar_id,
                            kam.jenis_kamar,
                            kam.tarif_kamar
                        }).ToList();
            t3droom.DataSource= room;
            t3cupdate.FlatStyle = FlatStyle.Popup;
            t3cupdate.DefaultCellStyle.BackColor = Color.SkyBlue;
            t3cdelete.FlatStyle = FlatStyle.Popup;
            t3cdelete.DefaultCellStyle.BackColor = Color.Red;
            t3cdelete.DefaultCellStyle.ForeColor = Color.White;
        }

        private void t3droom_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == t3droom.Columns["t3cupdate"].Index)
                {
                    GlobalRoom = new FormRoom("Update", Convert.ToInt32(t3droom.Rows[e.RowIndex].Cells["t3cid"].Value));
                    GlobalRoom.ShowDialog();
                }
                if (e.ColumnIndex == t3droom.Columns["t3cdelete"].Index)
                {
                    DialogResult result = MessageBox.Show("Konfirmasi Hapus Data", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int kamid = Convert.ToInt32(t3droom.Rows[e.RowIndex].Cells["t3cid"].Value);
                        db = new db_enlimahotelEntities();
                        var room = db.tbl_kamar.Where(a => a.kamar_id == kamid).FirstOrDefault();
                        db.tbl_kamar.Remove(room);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void t3droom_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            db = new db_enlimahotelEntities();
            for (int i = 0;i < t3droom.Rows.Count; i++)
            {
                int roomid = Convert.ToInt32(t3droom.Rows[i].Cells["t3cid"].Value);
                var room = db.tbl_kamar.Where(a=>a.kamar_id == roomid).FirstOrDefault();
                if (room.foto_kamar != null)
                {
                    byte[] imageData = room.foto_kamar;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        /*Image resize = new Bitmap(Image.FromStream(ms), new Size(160, 130));
                        t3droom.Rows[i].Cells["t3cfotokamar"].Value = resize;
                        
                        t3cfotokamar.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;*/
                    }
                }
                if (room.extra_bed == true)
                {
                    t3droom.Rows[i].Cells["t3cextrabed"].Value = "Support";
                }
                else
                {
                    t3droom.Rows[i].Cells["t3cextrabed"].Value = "Not Supported";
                }
                if (room.tersedia < DateTime.Now)
                {
                    t3droom.Rows[i].Cells["t3cstatus"].Value = "Tersedia";
                }
                else
                {
                    t3droom.Rows[i].Cells["t3cstatus"].Value = "Tidak Tersedia";
                }
            }
        }

        private void t3badd_Click(object sender, EventArgs e)
        {
            GlobalRoom = new FormRoom("Input", 0);
            GlobalRoom.ShowDialog();
        }

        private void t3brefresh_Click(object sender, EventArgs e)
        {
            t3tsearch.Text = string.Empty;
            t3cfilter.Text = "All";
            Loadtableroom();
        }
        private void t3tsearch_TextChanged(object sender, EventArgs e)
        {
            db = new db_enlimahotelEntities();
            var room = (from kam in db.tbl_kamar.Where(a => a.kamar_id.ToString() == t3tsearch.Text || a.jenis_kamar.StartsWith(t3tsearch.Text))
                        select new
                        {
                            kam.kamar_id,
                            kam.jenis_kamar,
                            kam.tarif_kamar
                        }).ToList();
            t3droom.DataSource = room;
            
        }
        private void t3cfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            t3tsearch.Text = string.Empty;
            if (t3cfilter.Text == "Tersedia")
            {
                db = new db_enlimahotelEntities();
                var room = (from kam in db.tbl_kamar.Where(a => a.tersedia <= DateTime.Now)
                            select new
                            {
                                kam.kamar_id,
                                kam.jenis_kamar,
                                kam.tarif_kamar
                            }).ToList();
                t3droom.DataSource = room;
            }
            else if (t3cfilter.Text == "Tidak Tersedia")
            {
                
                db = new db_enlimahotelEntities();
                var room = (from kam in db.tbl_kamar.Where(a=>a.tersedia > DateTime.Now)
                            select new
                            {
                                kam.kamar_id,
                                kam.jenis_kamar,
                                kam.tarif_kamar
                            }).ToList();
                t3droom.DataSource = room;
            }
            else if (t3cfilter.Text == "All")
            {
                Loadtableroom();
            }

        }
        //Tab4
        void Loadtablepelanggan()
        {
            db = new db_enlimahotelEntities();
            var pelanggan = (from pel in db.tbl_pelanggan
                             select new
                             {
                                 pel.pelanggan_id,
                                 pel.nama,
                                 pel.email,
                                 pel.nomor_telepon,
                                 pel.jenis_identitas,
                                 pel.no_identitas
                             }).ToList();
            t4dpelanggan.DataSource = pelanggan;
            t4cupdate.FlatStyle = FlatStyle.Popup;
            t4cupdate.DefaultCellStyle.BackColor = Color.SkyBlue;
            t4cdelete.FlatStyle = FlatStyle.Popup;
            t4cdelete.DefaultCellStyle.BackColor = Color.Red;
            t4cdelete.DefaultCellStyle.ForeColor = Color.White;
        }

        private void t4badd_Click(object sender, EventArgs e)
        {
            FormCustomer fc = new FormCustomer("Input", 0);
            fc.ShowDialog();
        }

        private void t4brefresh_Click(object sender, EventArgs e)
        {
            t4tsearch.Text = string.Empty;
            Loadtablepelanggan();
        }

        private void t4dpelanggan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == t4dpelanggan.Columns["t4cupdate"].Index)
                {
                    FormCustomer fc = new FormCustomer("Update", Convert.ToInt32(t4dpelanggan.Rows[e.RowIndex].Cells["t4cid"].Value));
                    fc.ShowDialog();
                }
                if (e.ColumnIndex == t4dpelanggan.Columns["t4cdelete"].Index)
                {
                    DialogResult result = MessageBox.Show("Konfirmasi Hapus Data", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int kamid = Convert.ToInt32(t3droom.Rows[e.RowIndex].Cells["t4cid"].Value);
                        db = new db_enlimahotelEntities();
                        var room = db.tbl_kamar.Where(a => a.kamar_id == kamid).FirstOrDefault();
                        db.tbl_kamar.Remove(room);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void t4tsearch_TextChanged(object sender, EventArgs e)
        {
            db = new db_enlimahotelEntities();
            var pelanggan = (from pel in db.tbl_pelanggan.Where(a=>a.nama.StartsWith(t4tsearch.Text))
                             select new
                             {
                                 pel.pelanggan_id,
                                 pel.nama,
                                 pel.email,
                                 pel.nomor_telepon,
                                 pel.jenis_identitas,
                                 pel.no_identitas
                             }).ToList();
            t4dpelanggan.DataSource = pelanggan;

        }
        //Tab5
        void LoadDefault()
        {
            db = new db_enlimahotelEntities();
            var reservasi = (from res in db.tbl_reservasi
                             join pel in db.tbl_pelanggan on res.pelanggan_id equals pel.pelanggan_id
                             join kam in db.tbl_kamar on res.kamar_id equals kam.kamar_id
                             select new
                             {
                                 res.reservasi_id,
                                 pel.nama,
                                 res.kamar_id,
                                 res.status,
                                 res.tanggal_checkin,
                                 res.tanggal_checkout,
                                 res.total_bayar,
                                 kam.tarif_kamar
                             }).ToList();
            t5chart.Series.Clear();
            t5chart.Series.Add("Pendapatan");
            int currentYear = DateTime.Now.Year;
            for (int i = 1; i <= 12; i++)
            {
                DateTime date = new DateTime(currentYear, i, 1);
                db = new db_enlimahotelEntities();
                var pendapatan = (from res in db.tbl_reservasi.Where(a => a.tanggal_checkout.Value.Month == date.Date.Month && a.tanggal_checkin.Value.Year == date.Date.Year) select res.total_bayar).Sum();
                t5chart.Series["Pendapatan"].Points.AddXY(date.Date.ToString("MMMM - yyyy"), pendapatan);
            }

            t5dbooking.DataSource = reservasi;
            db = new db_enlimahotelEntities();
            t5ctahun.Items.Clear();
            for (int i = 2005; i <= Convert.ToInt32(DateTime.Now.Date.Year);i++)
            {
                t5ctahun.Items.Add(i);
            }
            t5cbulan.SelectedIndex = -1;
            t5ctahun.SelectedIndex = -1;
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

        private void t5bprint_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Silahkan Tekan Enter untuk Print setelah Struk muncul", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CustomReport cr = new CustomReport(t5dbooking, t5chart);
            cr.ShowDialog();
        }

        private void t5cfilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t5cfilter.Text == "Custom")
            {
                t5ctahun.Enabled = true;
                t5ctahun.Text = DateTime.Now.Year.ToString();
                t5cbulan.Enabled = true;
            }
            else
            {
                t5ctahun.Enabled = false;
                t5ctahun.SelectedIndex = -1;
                t5cbulan.SelectedIndex = -1;
                t5cbulan.Enabled = false;
                LoadDefault();
            }
        }

        private void t5ctahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t5ctahun.SelectedIndex != -1)   
            {
                db = new db_enlimahotelEntities();
                int tahuntxt = Convert.ToInt32(t5ctahun.Text);
                DateTime tahun = new DateTime(tahuntxt, 1, 1);
                var reservasi = (from res in db.tbl_reservasi.Where(a => a.tanggal_checkin.Value.Year == tahun.Date.Year).ToList()
                                 join pel in db.tbl_pelanggan on res.pelanggan_id equals pel.pelanggan_id
                                 join kam in db.tbl_kamar on res.kamar_id equals kam.kamar_id
                                 select new
                                 {
                                     res.reservasi_id,
                                     pel.nama,
                                     res.kamar_id,
                                     res.status,
                                     res.tanggal_checkin,
                                     res.tanggal_checkout,
                                     res.total_bayar,
                                     kam.tarif_kamar
                                 }).ToList();
                t5dbooking.DataSource = reservasi;
                t5chart.Series.Clear();
                t5chart.Series.Add("Pendapatan");
                int currentYear = Convert.ToInt32(t5ctahun.Text);
                for (int i = 1; i <= 12; i++)
                {
                    DateTime date = new DateTime(currentYear, i, 1);
                    db = new db_enlimahotelEntities();
                    var pendapatan = (from res in db.tbl_reservasi.Where(a => a.tanggal_checkout.Value.Month == date.Date.Month &&a.tanggal_checkin.Value.Year == date.Date.Year) select res.total_bayar).Sum();
                    t5chart.Series["Pendapatan"].Points.AddXY(date.Date.ToString("MMMM - yyyy"), pendapatan);
                }

            }
        }
            

        private void t5cbulan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t5cbulan.SelectedIndex != -1)
            {
                db = new db_enlimahotelEntities();
                int tahuntxt = Convert.ToInt32(t5ctahun.Text);
                int bulantxt = Convert.ToInt32(t5cbulan.SelectedIndex + 1);
                DateTime tahun = new DateTime(tahuntxt, bulantxt, 1);
                var reservasi = (from res in db.tbl_reservasi.Where(a => a.tanggal_checkin.Value.Year == tahun.Date.Year && a.tanggal_checkin.Value.Month == tahun.Date.Month).ToList()
                                 join pel in db.tbl_pelanggan on res.pelanggan_id equals pel.pelanggan_id
                                 join kam in db.tbl_kamar on res.kamar_id equals kam.kamar_id
                                 select new
                                 {
                                     res.reservasi_id,
                                     pel.nama,
                                     res.kamar_id,
                                     res.status,
                                     res.tanggal_checkin,
                                     res.tanggal_checkout,
                                     res.total_bayar,
                                     kam.tarif_kamar
                                 }).ToList();
                t5dbooking.DataSource = reservasi;


            }
        }
        //Tab6
        private void t6tsearch_TextChanged(object sender, EventArgs e)
        {
            db = new db_enlimahotelEntities();
            var pel = db.tbl_pelayanan.Where(a=>a.nama_pelayanan.StartsWith(t6tsearch.Text) || a.pelayanan_id.ToString() == t6tsearch.Text).ToList();
            t6dpelayanan.DataSource = pel;
        }
        void LoadtablePelayanan()
        {
            db = new db_enlimahotelEntities();
            var pel = db.tbl_pelayanan.ToList();
            t6dpelayanan.DataSource = pel;
            t6cupdate.FlatStyle = FlatStyle.Popup;
            t6cdelete.FlatStyle = FlatStyle.Popup;
            t6cupdate.DefaultCellStyle.BackColor = Color.SkyBlue;
            t6cdelete.DefaultCellStyle.BackColor = Color.Red;
            t6cdelete.DefaultCellStyle.ForeColor = Color.White;
        }

        private void t6brefresh_Click(object sender, EventArgs e)
        {
            LoadtablePelayanan();
        }

        private void t6badd_Click(object sender, EventArgs e)
        {
            FormPelayanan fp = new FormPelayanan(0);
            fp.ShowDialog();
        }

        private void t6dpelayanan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == t6dpelayanan.Columns["t6cupdate"].Index)
                {
                    FormPelayanan fp = new FormPelayanan(Convert.ToInt32(t6dpelayanan.Rows[e.RowIndex].Cells["t6cid"].Value));
                    fp.ShowDialog();
                }
                if (e.ColumnIndex == t6dpelayanan.Columns["t6cdelete"].Index)
                {
                    DialogResult result = MessageBox.Show("Yakin ingin delete data ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        db = new db_enlimahotelEntities();
                        int pelid = Convert.ToInt32(t6dpelayanan.Rows[e.RowIndex].Cells["t6cid"].Value);
                        var pel = db.tbl_pelayanan.Where(a => a.pelayanan_id == pelid).FirstOrDefault();
                        db.tbl_pelayanan.Remove(pel);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        //Tab7
        void Loadtableusers()
        {
            
            db = new db_enlimahotelEntities();
            var users = (from user in db.tbl_user.Where(a=>a.user_id != vuserid)
                         select new
                         {
                             user.user_id,
                             user.name,
                             user.email,
                             user.phone,
                             user.role,
                             user.password
                         }).ToList();
            t7duser.DataSource = users;
            t7cupdate.FlatStyle = FlatStyle.Popup;
            t7cupdate.DefaultCellStyle.BackColor = Color.SkyBlue;
            t7cdelete.FlatStyle = FlatStyle.Popup;
            t7cdelete.DefaultCellStyle.BackColor = Color.Red ;
            t7cdelete.DefaultCellStyle.ForeColor = Color.White;
        }

        private void t7duser_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < t7duser.Rows.Count; i++)
            {
                int id = Convert.ToInt32(t7duser.Rows[i].Cells["t7cid"].Value);
                db = new db_enlimahotelEntities();
                var user = db.tbl_user.Where(a => a.user_id == id).FirstOrDefault();
                if (user.photo != null)
                {
                    byte[] imageData = user.photo;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image resize = new Bitmap(Image.FromStream(ms), new Size(165, 130));
                        t7duser.Rows[i].Cells["t7cphoto"].Value = resize;
                        t7cphoto.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    }
                }

            }
        }

        private void t7tsearch_TextChanged(object sender, EventArgs e)
        {
            db = new db_enlimahotelEntities();
            var users = (from user in db.tbl_user.Where(a=>a.user_id.ToString() == t7tsearch.Text || a.name.StartsWith(t7tsearch.Text) && a.user_id != vuserid)
                         select new
                         {
                             user.user_id,
                             user.name,
                             user.email,
                             user.phone,
                             user.role,
                             user.password
                         }).ToList();
            t7duser.DataSource = users;
        }

        private void t7brefresh_Click(object sender, EventArgs e)
        {
            Loadtableusers();
        }

        private void t7badd_Click(object sender, EventArgs e)
        {
            FormUser fu = new FormUser(0);
            fu.ShowDialog();
        }

        private void t7duser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == t7duser.Columns["t7cupdate"].Index)
                {
                    FormUser fu = new FormUser(Convert.ToInt32(t7duser.Rows[e.RowIndex].Cells["t7cid"].Value));
                    fu.ShowDialog();
                }
                if (e.ColumnIndex == t7duser.Columns["t7cdelete"].Index)
                {
                    DialogResult result = MessageBox.Show("Yakin ingin menghapus data ini ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        db = new db_enlimahotelEntities();
                        int id = Convert.ToInt32(t7duser.Rows[e.RowIndex].Cells["t7cid"].Value);
                        var user = db.tbl_user.Where(a => a.user_id == id).FirstOrDefault();
                        db.tbl_user.Remove(user);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        //Tab8
        byte[] imageProfil;
        void Loadprofil()
        {
            db = new db_enlimahotelEntities();
            var user = db.tbl_user.Where(a => a.user_id == vuserid).FirstOrDefault();
            t8tnama.Text = user.name;
            t8temail.Text = user.email;
            t8tnotelepon.Text = user.phone;
            if (user.photo != null)
            {
                imageProfil = user.photo;
                using (MemoryStream ms = new MemoryStream(imageProfil))
                {
                    t8pphoto.Image = Image.FromStream(ms);
                    t8pphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void t8brefresh_Click(object sender, EventArgs e)
        {
            Loadprofil();
        }

        private void t8pphoto_Click(object sender, EventArgs e)
        {
            t1ofd.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            if (t1ofd.ShowDialog() == DialogResult.OK)
            {
                imageProfil = File.ReadAllBytes(t1ofd.FileName);
                using (MemoryStream ms = new MemoryStream(imageProfil))
                {
                    t8pphoto.Image = Image.FromStream(ms);
                    t8pphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void t8bsimpan_Click(object sender, EventArgs e)
        {
            if (t8tnama.Text == string.Empty || t8temail.Text == string.Empty || t8tnotelepon.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi Data terlebih dahulu !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                db = new db_enlimahotelEntities();
                var email = db.tbl_user.Where(a=>a.email == t8temail.Text && a.user_id != vuserid).FirstOrDefault();
                if (email != null)
                {
                    MessageBox.Show("Email sudah digunakan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    db = new db_enlimahotelEntities();
                    var user = db.tbl_user.Where(a => a.user_id == vuserid).FirstOrDefault();
                    if (user != null)
                    {
                        user.name = t8tnama.Text;
                        user.email = t8temail.Text;
                        user.phone = t8tnotelepon.Text;
                        if (t8pphoto.Image != null)
                        {
                            user.photo = imageProfil;
                        }
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil di Input");
                    }
                }
            }
        }

        private void t8bchangepassword_Click(object sender, EventArgs e)
        {
            FormUser fu = new FormUser(vuserid);
            fu.ShowDialog();
        }
    }

}