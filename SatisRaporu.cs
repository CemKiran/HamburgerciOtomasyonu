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
    public partial class SatisRaporu : Form
    {
        public SatisRaporu()
        {
            InitializeComponent();
        }

        private void SatisRaporu_Load(object sender, EventArgs e)
        {
            int menuadet = 0;
            decimal ciro = 0;
            decimal extraGelirleri = 0;

            foreach (Siparis siparis in SiparisForm.TumSiparisler)
            {
                ciro += siparis.ToplamTutar;
                foreach (var item in siparis.Malzemeler)
                {
                    extraGelirleri += item.Fiyat;
                }

                menuadet += siparis.Adet;
                listTumSatislar.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString();
            lblExtraGelir.Text = extraGelirleri.ToString();
            lblMenuSatis.Text = menuadet.ToString();
        }
    }
}
