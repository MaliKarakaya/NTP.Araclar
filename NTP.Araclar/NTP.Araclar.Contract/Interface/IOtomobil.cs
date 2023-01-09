using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Araclar.Interface
{
    public interface IOtomobil
    {
        public int KapiSayisi { get; set; }
        public int Hiz { get; set; }
        public void Hizlan(int artis);
        public void Yavasla(int azalma);
        public string ToString();
    }
}
