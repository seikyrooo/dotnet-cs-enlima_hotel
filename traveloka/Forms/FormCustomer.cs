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

namespace traveloka
{
    public partial class FormCustomer : MaterialForm
    {
        db_enlimahotelEntities db;
        int pelid;
        public FormCustomer(string action, int id)
        {
            InitializeComponent();
            if(action == "Input")
            {
                bsimpan.Text = "Input";
            }
            else
            {
                pelid = id;
                db = new db_enlimahotelEntities();
                var cus = db.tbl_pelanggan.Where(a=>a.pelanggan_id== pelid).FirstOrDefault();
                tnama.Text = cus.nama;
                temail.Text = cus.email;
                tnomortelepon.Text = cus.nomor_telepon;
                tjenisidentitas.Text = cus.jenis_identitas;
                tnoidentitas.Text = cus.no_identitas;
                bsimpan.Text = "Simpan";
            }
        }

        private void bsimpan_Click(object sender, EventArgs e)
        {
            if(bsimpan.Text == "Input")
            {
                db = new db_enlimahotelEntities();
                tbl_pelanggan pel = new tbl_pelanggan();
                pel.nama = tnama.Text;
                pel.email = temail.Text;
                pel.nomor_telepon = tnomortelepon.Text;
                pel.jenis_identitas = tjenisidentitas.Text;
                pel.no_identitas = tjenisidentitas.Text;
                db.tbl_pelanggan.Add(pel);
                db.SaveChanges();
                MessageBox.Show("Berhasil Input Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                db = new db_enlimahotelEntities();
                var pel = db.tbl_pelanggan.Where(a => a.pelanggan_id == pelid).FirstOrDefault();
                pel.nama = tnama.Text;
                pel.email = temail.Text;
                pel.nomor_telepon = tnomortelepon.Text;
                pel.jenis_identitas = tjenisidentitas.Text;
                pel.no_identitas = tjenisidentitas.Text;
                db.SaveChanges();
                MessageBox.Show("Berhasil Update Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void tnomortelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Kolom ini Berformat Angka", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tnoidentitas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Kolom ini Berformat Angka", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
