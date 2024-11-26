using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeikalaSimulators
{
    public class VeikalaLogika
    {
        public decimal Budzets {  get; internal set; }
        public int Invetars { get; internal set; }
        public decimal ProduktaCena { get; set; }
        private const decimal IepirkumaCena = 5m;

        public VeikalaLogika()
        {
            Budzets = 1000m;
            Invetars = 10;
            ProduktaCena = 10m;
        }

        public string DienasSimulacija(Random random)
        {
            int pamataPieprasijums = random.Next(10, 50);
            int pieprasijums = (int)(pamataPieprasijums - ProduktaCena / 2);

            if (pieprasijums < 0) pieprasijums = 0;
      
            int pardots = Math.Min(pieprasijums, Invetars);
            decimal dienasIenakumi = pardots * ProduktaCena;
            Invetars -= pardots;
            Budzets += dienasIenakumi;

            return $"Šodien tika pārdotas {pardots} preces. Peļņa: {dienasIenakumi} €.";
        }

        public bool InvetaraIepirkums(int daudzums)
        {
            decimal maksa = daudzums * IepirkumaCena;
            if (Budzets >= maksa)
            {
                Invetars += daudzums;
                Budzets -= maksa;
                return true;
            }
            return false;
        }
    }
}
