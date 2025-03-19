using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjacks
{
    public class kartlar
    {
        public kartlar(string kart, string değerler)
        {
            this.kart = kart;
            this.degerler = değerler;
        }

        public string kart { get; set; }
        public string degerler { get; set; }
        public int Imageindex { get; set; }

        public override string ToString()
        {
            return kart + "" + degerler;
        }
    }
}
