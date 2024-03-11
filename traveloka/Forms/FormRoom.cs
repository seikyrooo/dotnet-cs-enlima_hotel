using enlimahotel;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static traveloka.GlobalClass;

namespace traveloka
{
    public partial class FormRoom : MaterialForm
    {
        db_enlimahotelEntities db;
        int kamid;
        byte[] imageData;

        public FormRoom(string action, int kamarid)
        {
            InitializeComponent();
            if (action == "Input")
            {
                badd.Text = "Input";
            }
            else
            {
                kamid = kamarid;
                badd.Text = "Update";
                db = new db_enlimahotelEntities();
                var room = db.tbl_kamar.Where(a=>a.kamar_id == kamarid).FirstOrDefault();

                if (room.foto_kamar != null)
                {
                    using (MemoryStream ms = new MemoryStream(room.foto_kamar))
                    {
                        pfotokamar.Image = Image.FromStream(ms);
                        pfotokamar.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                tjeniskamar.Text = room.jenis_kamar;
                ttarifkamar.Text = room.tarif_kamar.ToString();
                if (room.extra_bed == true)
                {
                    cextrabed.Checked = true;
                }
                else
                {
                    cextrabed.Checked = false;
                }
                imageData = room.foto_kamar;
                bnokamar.Text = room.kamar_id.ToString();
            }
            
        }
        private void badd_Click(object sender, EventArgs e)
        {
            if (tjeniskamar.Text == string.Empty || ttarifkamar.Text == string.Empty || pfotokamar.Image == null || bnokamar.UseAccentColor == false)
            {
                MessageBox.Show("Silahkan isi kolom diatas !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (badd.Text == "Input")
                {
                    db = new db_enlimahotelEntities();
                    var room = new tbl_kamar();
                    room.jenis_kamar = tjeniskamar.Text;
                    room.tarif_kamar = Convert.ToInt32(ttarifkamar.Text);
                    if (cextrabed.Checked)
                    {
                        room.extra_bed = true;
                    }
                    else
                    {
                        room.extra_bed = false;
                    }
                    if (imageData != null)
                    {
                        room.foto_kamar = imageData;
                    }
                    room.tersedia = DateTime.Now;
                    room.kamar_id = Convert.ToInt32(bnokamar.Text);
                    db.tbl_kamar.Add(room);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    db = new db_enlimahotelEntities();
                    var room = db.tbl_kamar.Where(a => a.kamar_id == kamid).FirstOrDefault();
                    room.jenis_kamar = tjeniskamar.Text;
                    room.tarif_kamar = Convert.ToInt32(ttarifkamar.Text);
                    if (pfotokamar.Image != null)
                    {
                        room.foto_kamar = imageData;
                    }
                    if (cextrabed.Checked == false)
                    {
                        room.extra_bed = false;
                    }
                    else
                    {
                        room.extra_bed = true;
                    }
                    room.kamar_id = Convert.ToInt32(bnokamar.Text);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Update", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void pfotokamar_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageData = File.ReadAllBytes(ofd.FileName);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pfotokamar.Image = Image.FromStream(ms);
                    pfotokamar.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void bnokamar_Click(object sender, EventArgs e)
        {
            if (badd.Text == "Input")
            {
                GlobalChoseNo = new FormNoKamar();
                GlobalChoseNo.ShowDialog();
            }
            else{
                MessageBox.Show("Anda tidak bisa mengubah No Kamar yang sudah di tentukan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void bnokamar_TextChanged(object sender, EventArgs e)
        {
            if (bnokamar.Text != "Pilih No Kamar")
            {
                bnokamar.UseAccentColor = true;
            }
            else
            {
                bnokamar.UseAccentColor= false;
            }
        }

        private void ttarifkamar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Kolom ini Berformat Angka", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
