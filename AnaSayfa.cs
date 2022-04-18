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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChildForm(new SiparisForm());
           
            
            
        }

        private void menuEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new MenuEkle());
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new ExtraEkle());
        }


        public void ChildForm(Form childForm)
        {
            this.Width = childForm.Width + 100;
            this.Height = childForm.Height + 100;
           
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }

            }

            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();

            }



        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            if (Parametreler.programSeriNo != "aliveli4950")
            {
                MessageBox.Show("Programi Kacak Kullaniyorsunuz");
                Environment.Exit(0);
            }
            
            
        }

        private void siparisRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ChildForm(new SatisRaporu());
        }
    }
}
