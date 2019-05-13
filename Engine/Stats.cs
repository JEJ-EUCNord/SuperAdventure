using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Stats
    {
        public int Strength { get; set; }
        
        public int Intellect { get; set; }
        public int Agility { get; set; }

        public int Defense { get; set; }
        public int CriticalStrike { get; set; }

        public Stats(int strength, int intellect, int agility, int defense, int criticalStrike)
        {
            Strength = strength;
            
            Intellect = intellect;
            Agility = agility;

            defense = Defense;
            criticalStrike = CriticalStrike;
            
        }
    }
}
