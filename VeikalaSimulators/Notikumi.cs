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
                return $"- Negatīvs notikums: Klientu sūdzība! Zaudēti {sods} €.";
            }
            else if (NotikumaIespeja <= 30)
            {
                int bonussProd = random.Next(1, 10);
                veikals.Invetars += bonussProd;
                return $"+ Pozitīvs notikums: Tu saņēmi bonusu produktu no piegādātāja! +{bonussProd}.";
            }
            else if (veikals.Invetars == 0)
            {
                decimal sods = random.Next(50, 200);
                veikals.Budzets -= sods;
                return $"- Negatīvs notikums: Tukšs invetārs! Zaudēti {sods} €.";
            }
            return string.Empty;
        }
    }
}
