using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Pokemon
{
    class Battle
    {
        static void Main(string[] args)
        {
            bool battleFinished = false;

            Trainer Red = new Trainer("red", 6, 200);

            //Creates a list of Elite Four trainers
            List<Trainer> eliteFour = new List<Trainer>()
            {
                new Trainer("Lorelei", 2, 2000),
                new Trainer("Bruno", 2, 1000),
                new Trainer("Agatha", 2, 3000),
                new Trainer("Lance", 2, 5000)
            };

            while (!battleFinished) //Battle loop
            {
                for (int i = 0; i < 4; i++) // Loop through the eliteFour
                {
                    while (Red.NumberOfPkmn > 0 && 
                            eliteFour[i].NumberOfPkmn > 0)//Battle code here
                    {
                        WriteLine("{0} has {1} pkmn left!", eliteFour[i].Name, eliteFour[i].NumberOfPkmn);

                        eliteFour[i].PkmnFainted();

                        ReadKey();
                        
                    }

                    Red.PkmnFainted();
                    WriteLine("{0}'s pkmn fainted!", Red.Name);

                    WriteLine("{0} has {1} pkmn left!", Red.Name, Red.NumberOfPkmn);

                }



                WriteLine("Red defeated the Elite Four!");

                battleFinished = true;

            }//End of Battle loop

            ReadKey();

        }//End of Main program




    }//End of Battle program
}//End of namespace
