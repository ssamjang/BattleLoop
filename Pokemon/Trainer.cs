using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Pokemon
{
    class Trainer
    {
        private string name;
        private bool isAlive = true; // False if all pokemon have fainted
        private int numberOfPkmn;
        private double money;

        public Trainer(string name, int numberOfPkmn, double money)
        {
            this.name = name;
            this.numberOfPkmn = numberOfPkmn;
            this.money = money;
        }


        public override string ToString()
        {
            return this.name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public bool IsAlive // returns trainer's current life status
        {
            get { return this.isAlive; }
            set { this.isAlive = value; }
        }

        public void TrainerDies() //Call when trainer loses all pokemon
        {
            this.isAlive = false;
        }
        
        public int NumberOfPkmn
        {
            get { return this.numberOfPkmn; }
            set { this.numberOfPkmn = value; }
        }
        public double Money
        {
            get { return this.money; }
            set { this.money = value; }
        }

        public void PkmnFainted() //decrements number of pokemon alive
        {
            this.numberOfPkmn -= 1;
        }


    }//End of class


}//End of namespace
