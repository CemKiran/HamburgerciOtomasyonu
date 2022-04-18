using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparis
    {
        public int Id { get; set; }
        public Menu SeciliMenu { get; set; }

        public Boyut Boyut { get; set; }

        public List<Extra> Malzemeler { get; set; }

        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;

            switch (Boyut)
            {
               
                case Boyut.Orta:
                    ToplamTutar += SeciliMenu.Fiyat * 0.1m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += SeciliMenu.Fiyat * 0.2m;
                    break;
            }

            //Extra malzemeler icin gerekli hesaplamalar yapiliyor
            foreach (var item in Malzemeler)
            {
                ToplamTutar += item.Fiyat;
            }

            ToplamTutar = ToplamTutar * Adet;
        }

        public override string ToString()
        {
            // MenuAdi Adet , Boyut ,(extralar) Toplam
            string str = "";
            if (Malzemeler.Count < 1)
            {
                str = $"{Id} Numarali Siparis({DateTime.Now}) {SeciliMenu} x {Adet} , {Boyut} , Toplam:{ToplamTutar}";
                return str;
            }
            else
            {
                str = $"{Id} Numarali Siparis({DateTime.Now}){SeciliMenu} x {Adet} , {Boyut} ";
                string extraMalzemeler = "";
                foreach (var item in Malzemeler)
                {
                    extraMalzemeler += $"{item.ExtraAdi} , ";
                }
                
                string temiz = extraMalzemeler.Trim(',');
                extraMalzemeler = temiz; // En Sondaki , isaretini atar.

                str = str + "("+extraMalzemeler + ")" + $" Toplam:{ToplamTutar}" ;
                return str;
            }
             





            
        }

    }
}
