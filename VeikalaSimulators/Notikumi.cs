using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeikalaSimulators
{
    public static class Notikumi
    {
        public static string NotikumuGenerators(VeikalaLogika veikals, Random random)
        {
            int NotikumaIespeja = random.Next(1, 101); 
            if (NotikumaIespeja <= 20)
            {
                decimal sods = random.Next(50, 200);
                veikals.Budzets -= sods;
                return $"Negatīvs notikums: Klientu sūdzība! Zaudēti {penalty} €.";
            }
            else if (NotikumaIespeja <= 30) // 10% iespēja pozitīvam notikumam
            {
                decimal bonuss = random.Next(50, 200);
                veikals.Budzets += bonuss;
                return $"Pozitīvs notikums: Tu saņēmi bonusu no piegādātāja! Peļņa: {bonuss} €.";
            }
            return string.Empty;
        }
    }
}
