using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Game_Homework
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        public Weapon EquippedWeapon { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }

        public Hero(string name)
        {
            Name = name;
            Health = 500;
            StartingHealth = Health;
            Strength = 100;
        }

        public virtual int Attack()
        {
            int totalDamage = Strength + (EquippedWeapon?.Damage ?? 0);
            return (Strength * Random.Shared.Next(80, 121)) / 100;
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }

        public virtual void EquipWeapon(Weapon weapon)
        {
            EquippedWeapon = weapon;
        }
    }
}
