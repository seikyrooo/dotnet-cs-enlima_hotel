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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static traveloka.GlobalClass;
using MaterialSkin;
using enlimahotel;
using Microsoft.CSharp;
using System.Data.SqlClient;
using System.Data.Entity;
using enlimahotel.Forms;
using enlimahotel.Properties;
using System.Configuration;
using System.Xml;

namespace traveloka
{
    public partial class FormLogin : MaterialForm
    {
        db_enlimahotelEntities db;
        public FormLogin()
        {
            InitializeComponent();
            thost.Text = ConfigurationManager.ConnectionStrings["db_enlimahotelEntities"].ConnectionString;
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            db = new db_enlimahotelEntities();
            if (temail.Text != string.Empty && tpassword.Text != string.Empty)
            {
                var user = db.tbl_user.Where(a => a.email.Equals(temail.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.password == tpassword.Text)
                    {
                        vuserid = user.user_id;
                        if (user.photo != null)
                        {
                            using (MemoryStream ms = new MemoryStream(user.photo))
                            {
                                vphoto = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            user.photo = null;
                        }
                        vname = user.name;
                        vrole = user.role;
                        vphone = user.phone;
                        vemail = user.email;
                        vpassword = user.password;
                        vactive = user.active;
                        GlobalLogin = this;
                        GlobalLogin.Hide();
                        MessageBox.Show("Login Berhasil", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GlobalMain = new FormMain(user.role);
                        
                        GlobalMain.ShowDialog();



                    }
                    else
                    {
                        MessageBox.Show("Password Salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                }
                {
                    MessageBox.Show("Email Salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silahkan isi kolom diatas!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
        public static bool SetGlobalSetting(string settingName, string settingValue)
        {
            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
                XmlNode xmlNode = xml.DocumentElement.SelectSingleNode("descendant::setting[@name='" + settingName + "']");
                xmlNode.SelectSingleNode("db_enlimahotelEntities").InnerText = settingValue;
                xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                Settings s = new Settings();
                s.Reload();

                return true;
            }
            catch (Exception e)
            {
                // process the exception as you need
            }
            return false;
        }
    private void button1_Click(object sender, EventArgs e)
        {
            SetGlobalSetting("connectionStrings", thost.Text);
        }
    }
}
