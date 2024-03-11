using enlimahotel;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traveloka
{
    public partial class FormRoomDetail : MaterialForm
    {
        db_enlimahotelEntities db;
        public FormRoomDetail(int roomid)
        {
            InitializeComponent();
            db = new db_enlimahotelEntities();
            var room = db.tbl_kamar.Where(a => a.kamar_id == roomid).FirstOrDefault();
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
            using (MemoryStream ms = new MemoryStream(room.foto_kamar))
            {
                pfotokamar.Image = Image.FromStream(ms);
                pfotokamar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
