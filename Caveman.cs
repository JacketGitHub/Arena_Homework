using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Game_Homework
{
    public class Caveman : Hero // super simple hero, designed for beginners, doesn't have anything special
    {

        private const int ExtraDamageChance = 2;
        private const int PainToleranceChance = 15;
        public Caveman(string name) : base(name)
        {
           
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ExtraDamageChance)) attack = attack * 200 / 100;
            return attack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(PainToleranceChance)) incomingDamage = 0;
            base.TakeDamage(incomingDamage);
        }

        public override void EquipWeapon(Weapon weapon)
        {
            SteelGauntlets SteelGauntlets = weapon as SteelGauntlets;
            base.EquipWeapon(SteelGauntlets);
        }
    }
}
