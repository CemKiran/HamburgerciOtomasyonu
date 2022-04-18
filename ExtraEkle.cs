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
    public partial class ExtraEkle : Form
    {
        public ExtraEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Extra extra = new Extra();
            //extra.ExtraAdi = textBox1.Text;
            //extra.Fiyat = numericUpDown1.Value;
            //SiparisForm.Extralar.Add(extra);


            // Object Init
            SiparisForm.Extralar.Add(new Extra 
            { 
                ExtraAdi = textBox1.Text, 
                Fiyat = numericUpDown1.Value 
            });

            MessageBox.Show("Başariyla Kaydedildi..");

        }
    }
}
