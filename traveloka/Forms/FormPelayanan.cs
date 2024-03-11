using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;

namespace enlimahotel.Forms
{
    public partial class FormPelayanan : MaterialForm
    {
        db_enlimahotelEntities db;
        int updateid;
        public FormPelayanan(int id)
        {
            InitializeComponent();
            ckategori.SelectedIndex = -1;
            db = new db_enlimahotelEntities();
            var pel = db.tbl_pelayanan.Where(a=>a.pelayanan_id == id).FirstOrDefault();
            if (pel != null)
            {
                bsimpan.Text = "Update";
                tnamapelayanan.Text = pel.nama_pelayanan;
                tharga.Text = pel.harga_pelayanan.ToString();
                ckategori.Text = pel.kategori;
                updateid = id;
            }
            else
            {
                bsimpan.Text = "Input";
            }
            
        }

        private void bsimpan_Click(object sender, EventArgs e)
        {
            if (tnamapelayanan.Text == string.Empty || tharga.Text == string.Empty || ckategori.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi kolom diatas!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bsimpan.Text == "Input")
                {
                    tbl_pelayanan pel = new tbl_pelayanan();
                    pel.nama_pelayanan = tnamapelayanan.Text;
                    pel.harga_pelayanan = Convert.ToInt32(tharga.Text);
                    pel.kategori = ckategori.Text;
                    db.tbl_pelayanan.Add(pel);
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    db = new db_enlimahotelEntities();
                    var pel = db.tbl_pelayanan.Where(a=>a.pelayanan_id == updateid).FirstOrDefault();
                    pel.nama_pelayanan = tnamapelayanan.Text;
                    pel.harga_pelayanan = Convert.ToInt32(tharga.Text);
                    pel.kategori = ckategori.Text;
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void tharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Data ini harus diisi dengan angka !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
