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
    public partial class SiparisForm : Form
    {

        public static List<Extra> Extralar = new List<Extra>()
        {
            new Extra{ ExtraAdi="Ketçap",Fiyat=2},
            new Extra{ ExtraAdi="Mayonez",Fiyat=2},
            new Extra{ ExtraAdi="Hardal",Fiyat=2},
            new Extra{ ExtraAdi="Peynir",Fiyat=10},
            new Extra{ ExtraAdi="Sogan Halkasi",Fiyat=5}

        };
        public static  List<Menu> Menuler = new List<Menu>()
        {
            new Menu{ MenuAdi="Big King" , Fiyat=38.5M},
            new Menu{ MenuAdi="Double King" , Fiyat=70M},
            new Menu{ MenuAdi="Whooper" , Fiyat=45M},
            new Menu{ MenuAdi="Chicken Royal" , Fiyat=35M}


        };
        public static List<Siparis> VerilenSiparisler = new List<Siparis>();
        public static List<Siparis> TumSiparisler = new List<Siparis>();
        private void SiparisForm_Load(object sender, EventArgs e)
        {
            // Menu Listesindeki elemanlari combobox icerisine ekler
            foreach (var item in Menuler)
            {
                cmbMenu.Items.Add(item);
            }
            // Extralar icerisindeki elemanlari flowlayoutpanel'e ekler
            foreach (var item in Extralar)
            {
                CheckBox box = new CheckBox();
                box.Text = item.ExtraAdi;
                box.Tag = item;// Tag property object turunden deger tasir. Extra boxing yapilir

                flowLayoutPanel1.Controls.Add(box);
            }

            rdoKucuk.Checked = true;
            cmbMenu.SelectedIndex = 0;

        }
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.Adet = (int)numAdet.Value;
            siparis.Id = (Parametreler.SiparisID)++;


            #region Boyut
            if (rdoKucuk.Checked)
            {
                siparis.Boyut = Boyut.Kucuk;
            }
            else if (rdoOrta.Checked)
            {
                siparis.Boyut = Boyut.Orta;

            }
            else
            {
                siparis.Boyut = Boyut.Buyuk;

            }
            #endregion


            #region Extra Malzemeler 
            List<Extra> extralar = new();
            foreach (CheckBox checkbox in flowLayoutPanel1.Controls)
            {

               if (checkbox.Checked)
                {

                    // Birinci Yontem
                    Extra extra = new();
                    //extra = (Extra)checkbox.Tag; // Unboxing işlemi
                    //yapilir
                    extra = checkbox.Tag as Extra;
                    extralar.Add(extra);

                    // Buda ikinci yontem : extralar.Add(checkbox.Tag as Extra);
                }

            }

            siparis.Malzemeler = extralar;
            #endregion


            #region Menu
            siparis.SeciliMenu = cmbMenu.SelectedItem as Menu;

            #endregion


            siparis.Hesapla();
           
           

            lstSipraisler.Items.Add(siparis);

            TutarHesapla();
            
            VerilenSiparisler.Add(siparis);
            
            TumSiparisler.Add(siparis);
           
            Helper.Temizle(this.Controls);
        }

        private void TutarHesapla()
        {
            decimal toplam = 0;
            foreach (Siparis item in lstSipraisler.Items)
            {
                toplam += item.ToplamTutar;
            }

            lblToplamTutar.Text = "Toplam Tutar:" +toplam.ToString();
            lblToplamTutar.ForeColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Toplam Sipariş Tutari:{lblToplamTutar.Text} \n Satişi tamamlamak istermisiniz ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lblToplamTutar.Text = "Toplam Tutar:0";
                lstSipraisler.Items.Clear();
                MessageBox.Show("Sipariş Tamamlanmistir");

            }
            else
            {
                MessageBox.Show("Isteginiz uzerine siparis iptal edilmistir.");
            }
        }
    }
}
