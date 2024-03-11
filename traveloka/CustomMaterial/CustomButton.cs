using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static traveloka.GlobalClass;
using System.Windows.Forms;

namespace traveloka
{
    public partial class CustomButton : Form
    {
        public CustomButton(string idbutton, bool click)
        {
            InitializeComponent();
            button.Text = idbutton;
            if (click ==true )
            {
                button.UseAccentColor= true;
            }
            else
            {
                button.UseAccentColor= false;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (button.UseAccentColor == true)
            {
                MessageBox.Show("No Kamar ini sudah digunakan Kamar Lain!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Konfirmasi Pilihan, Anda tidak dapat mengubah No Kamar setelah sudah di Input", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    GlobalChoseNo.Close();
                    GlobalRoom.bnokamar.Text = button.Text;
                }
                
            }
        }
    }
}
