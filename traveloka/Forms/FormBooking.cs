using enlimahotel;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traveloka
{
    public partial class FormBooking : MaterialForm
    {
        db_enlimahotelEntities db;
        public FormBooking()
        {
            InitializeComponent();
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            Loadcustompanel(DateTime.Now);
            LoadMalam();
            Loadidpelanggan();
        }
        void Loadidpelanggan()
        {
            db = new db_enlimahotelEntities();
            var pelanggan = db.tbl_pelanggan.ToList();
            cpelangganid.DataSource = pelanggan;
            cpelangganid.DisplayMember = "nama";
            cpelangganid.SelectedIndex = -1;
        }
        void LoadMalam()
        {
            for (int i = 0; i < 30; i++)
            {
                cmalam.Items.Add(i.ToString());
            }
            cmalam.SelectedIndex = -1;
        }
        void Loadcustompanel(DateTime checkin)
        {
            flpkamar.Controls.Clear();
            db = new db_enlimahotelEntities();
            var room = db.tbl_hotel.FirstOrDefault();
            int totalkamar = Convert.ToInt32(room.kapasitas_kamar) + 1;
            for (int i = 0; i < totalkamar; i++)
            {
                Image imageData = null;
                int kamarid = i;
                var kamar = db.tbl_kamar.Where(a => a.kamar_id == kamarid && a.tersedia <= checkin.Date).FirstOrDefault();
                if (kamar != null)
                {
                    using (MemoryStream ms = new MemoryStream(kamar.foto_kamar))
                    {
                        imageData = null/*Image.FromStream(ms)*/;
                        CustomPanel cp = new CustomPanel(kamarid.ToString(), imageData, "Kamar " + kamar.kamar_id.ToString(), kamar.tarif_kamar.ToString(), "Book", kamar.jenis_kamar);
                        cp.TopLevel = false;
                        flpkamar.Controls.Add(cp);
                        cp.Show();
                    }
                }
            }
        }

        private void dcheckin_ValueChanged(object sender, EventArgs e)
        {
            if (dcheckin.Value.Date < DateTime.Today.Date)
            {
                MessageBox.Show("Tidak bisa Check In pada tanggal tersebut", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dcheckin.Value= DateTime.Today;
            }
            else
            {
                cmalam.SelectedIndex = -1;
                dcheckout.Value = dcheckin.Value.Date;
                Loadcustompanel(dcheckin.Value.Date);
            }
        }

        private void cmalam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dcheckout.Value = dcheckin.Value.Date.AddDays(cmalam.SelectedIndex);
        }   
    }
}
