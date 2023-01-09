using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Araclar
{
    public class Arac
    {
         
        public string Renk { get; set; }
        public string Marka { get; set; }
        public void MarkaVeRenk()
        {
            Console.WriteLine(string.Format("Aracın markası:{0} Aracın rengi:{1}", Renk, Marka));
        }

    }
}
