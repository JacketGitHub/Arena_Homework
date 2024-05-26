using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Game_Homework
{
    public class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
    }

    public class Sword : Weapon
    {
        public Sword(string name)
        {
            Name = name;
            Damage = 125;
            Range = 0; // 0 because swords can't reach too far
        }
    }
    public class Bow : Weapon
    {
        public Bow(string name)
        {
            Name = name;
            Damage = 50;
            Range = 1; // Bows are usually mostly ranged weapons, bow bashing or stabbing with those arrows doesn't count
        }
    }
    public class SteelGauntlets : Weapon
    {
        public SteelGauntlets(string name)
        {
            Name = name;
            Damage = 75;
            Range = 0;
        }
    }
}
