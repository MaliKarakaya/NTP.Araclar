using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP.Araclar.Interface
{
    public interface IArac
    {
        public string Renk { get; set; }
        public string Marka { get; set; }
        public void MarkaVeRenk();       

    }
}
