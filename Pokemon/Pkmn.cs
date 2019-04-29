using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pokemon
{
    class Pkmn
    {
        private bool isAlive = true;
        private int hp;
        private int attack;

        public Pkmn(int healthPoints, int attack)
        {
            this.hp = healthPoints;
            this.attack = attack;
        }

        public bool IsAlive
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
        }

        public void CheckDeath()
        {
            if (this.hp <= 0)
            {
                this.isAlive = false;
            }
        }

        public void TakeDamage(int dmg)
        {
            this.hp -= dmg;
            CheckDeath();
        }

        public int DealDamage()
        {
            return this.attack;
        }


    }//End of Class
}//End of namespace
