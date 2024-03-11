using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static traveloka.GlobalClass;

namespace enlimahotel.Forms
{
    
    public partial class FormUser : MaterialForm
    {
        db_enlimahotelEntities db;
        int updateid = 0;
        byte[] imageData;
        public FormUser(int id)
        {
            InitializeComponent();
            db = new db_enlimahotelEntities();
            var user = db.tbl_user.Where(a=>a.user_id== id).FirstOrDefault();
            if (user != null && user.user_id != vuserid)
            {
                bsimpan.Text = "Update";
                updateid = id;
                if (user.photo != null)
                {
                    imageData = user.photo;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pphoto.Image = Image.FromStream(ms);
                        pphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                tnama.Text = user.name;
                crole.Text = user.role;
                tnotelepon.Text = user.phone;
                temail.Text = user.email;
                tpassword.Text = user.password;
            }
            else if (id == 0)
            {
                bsimpan.Text = "Input";
                crole.SelectedIndex = -1;
            }else if (id == vuserid)
            {
                bsimpan.Text = "Ganti Password";
                updateid = id;
                if (user.photo != null) 
                {
                    imageData = user.photo;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pphoto.Image = Image.FromStream(ms);
                        pphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                tnama.Text = user.name;
                crole.Text = user.role;
                tnotelepon.Text = user.phone;
                temail.Text = user.email;
                tpassword.Text = user.password;

                tnama.Enabled = false;
                crole.Enabled = false;
                tnotelepon.Enabled = false;
                temail.Enabled = false;
                pphoto.Enabled = false;
            }
        }
        private void pphoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageData = File.ReadAllBytes(openFileDialog1.FileName);
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pphoto.Image = Image.FromStream(ms);
                    pphoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void bsimpan_Click(object sender, EventArgs e)
        {
            if (tnama.Text == string.Empty || crole.Text == string.Empty || tnotelepon.Text == string.Empty || temail.Text == string.Empty || tpassword.Text == string.Empty)
            {
                MessageBox.Show("Silahkan isi data terlebih dahulu!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (bsimpan.Text == "Input")
                {
                   db = new db_enlimahotelEntities();
                    var email = db.tbl_user.Where(a => a.email == temail.Text).FirstOrDefault();
                    if (email != null)
                    {
                        MessageBox.Show("Email sudah digunakan", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        tbl_user user = new tbl_user();
                        user.name = tnama.Text;
                        user.email = temail.Text;
                        user.role = crole.Text;
                        user.phone = tnotelepon.Text;
                        user.password = tpassword.Text;
                        if (pphoto.Image != null)
                        {
                            user.photo = imageData;
                        }
                        
                        user.active = true;
                        db.tbl_user.Add(user);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil di input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (bsimpan.Text == "Update")
                {
                    db = new db_enlimahotelEntities();
                    var user = db.tbl_user.Where(a => a.user_id == updateid).FirstOrDefault();
                    user.photo = imageData;
                    user.name = tnama.Text;
                    user.role = crole.Text;
                    user.email = temail.Text;
                    user.phone = tnotelepon.Text;
                    user.password = tpassword.Text;
                    user.active = true;
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }else if ( bsimpan.Text == "Ganti Password")
                {
                    db = new db_enlimahotelEntities();
                    var user = db.tbl_user.Where(a => a.user_id == updateid).FirstOrDefault();
                    user.password = tpassword.Text;
                    db.SaveChanges();
                    MessageBox.Show("Data berhasil di Update", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            
        }

        private void cshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cshowpassword.Checked)
            {
                tpassword.PasswordChar = '\0';
            }
            else
            {
                tpassword.PasswordChar = '*';
            }
        }
    }
}
