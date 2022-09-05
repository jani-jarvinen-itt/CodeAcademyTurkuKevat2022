using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalkkatiedotXmlJsonKonversio
{
    public class Palkkatiedot
    {
        public string personName { get; set; }
        public Kuukausipalkka salary { get; set; }
        public string hiredate { get; set; }
    }

    public class Kuukausipalkka
    {
        public double monthly { get; set; }
    }
}
