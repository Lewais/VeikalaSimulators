using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeikalaSimulators
{
    public class VeikalaLogika
    {
        public decimal Budzets {  get; private set; }
        public int Invetars { get; private set; }
        public decimal ProduktaCena { get; set; }

        public VeikalaLogika()
        {
            Budzets = 1000m;
            Invetars = 100;
            ProduktaCena = 10m;
        }
    }
}
