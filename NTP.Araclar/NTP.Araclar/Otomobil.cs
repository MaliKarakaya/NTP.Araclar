using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Araclar
{
    public class Otomobil : Arac
    {
        public Otomobil(string renk, string marka)
        {
            Renk = renk;
            Marka = marka;
        }

        public int KapiSayisi { get; set; }
        public int Hiz { get; set; }
        public int Vites
        {
            get
            {
                if (Hiz <= 20)
                {
                    return 1;
                }
                else if (Hiz <= 40)
                {
                    return 2;
                }
                else if (Hiz <= 60)
                {
                    return 3;
                }
                else if (Hiz <= 90)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        public void Hizlan(int artis)
        {
            this.Hiz += artis;
        }

        public void Yavasla(int azalma)
        {
            this.Hiz -= azalma;
            if (Hiz <= 0)
            {
                this.Hiz = 0;
            }
        }

        public override string ToString()
        {
            return $"Aracın hızı:{Hiz.ToString()} Aracın Vites:{Vites.ToString()}," +
                $" Aracin bilgisi: Marka={Marka}; Renk={Renk}";
        }

    }
}
