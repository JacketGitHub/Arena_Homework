using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Game_Homework
{
    internal class PebbleThrower : Hero // basically a meme hero, it takes guaranteed damage and does almost no damage
    {
        private const int ChanceToDodgeDamage = 0;
        private const int ChangeToDoSomeDamage = 0;

        public PebbleThrower(string name) : base(name) 
        {
        
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(ChanceToDodgeDamage)) incomingDamage = 0; // never gonna happen, at this point this is just a formality
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int attack = base.Attack();
            if (ThrowDice(ChangeToDoSomeDamage)) attack = 1;
            return base.Attack();
        }
    }
}
