using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Hamburgerci
{
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SiparisForm.Menuler.Add(new Menu
            {
                MenuAdi = textBox1.Text,
                Fiyat = numericUpDown1.Value
            });

            MessageBox.Show("Başariyla Kaydedildi..");
        }
    }
}
