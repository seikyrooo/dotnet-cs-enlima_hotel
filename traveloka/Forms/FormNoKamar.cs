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
    public partial class FormNoKamar : MaterialForm
    {
        db_enlimahotelEntities db;
        
        public FormNoKamar()
        {
            InitializeComponent();
            

            
        }
        private void FormNoKamar_Load(object sender, EventArgs e)
        {
            db = new db_enlimahotelEntities();
            var hotel = db.tbl_hotel.Where(a => a.hotel_id == 1).FirstOrDefault();
            int buttonPerRow = 10;
            int buttonCount = 0;
            int rowCount = 0;

            for (int i = 1; i <= hotel.kapasitas_kamar; i++)
            {
                
                db = new db_enlimahotelEntities();
                var room = db.tbl_kamar.Where(a => a.kamar_id == i).FirstOrDefault();
                bool click;
                if (room != null)
                {
                    click = true;
                }
                else
                {
                    click = false;
                }
                CustomButton cb = new CustomButton(i.ToString(), click);
                cb.TopLevel = false;
                flpnokamar.Controls.Add(cb);
                cb.Show();
                buttonCount++;
                if (buttonCount % buttonPerRow == 0)
                {
                    rowCount++;
                }
            }
        }
    }
}
