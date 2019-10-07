using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Map
    {
        public Unit[] units = new Unit[10]; //declares a one dimensional array named units, with 10 positions

        public Map() 
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int newX = r.Next(0, 20); //gives a random x coordinate between 0 and 20
                int newY = r.Next(0, 20); //gives a random y coordinate between 0 and 20
                int team = i % 2;
                int tempAttack = 0;

                switch (r.Next(0, 4)) //Randomises the tempAttack value of the unit
                {
                    case 0: tempAttack = 5; break;
                    case 1: tempAttack = 10; break;
                    case 2: tempAttack = 15; break;
                    case 3: tempAttack = 20; break;
                }
                switch (r.Next(0, 2)) //Randomises whether the new unit is ranged or melee based
                {
                    case 0: units[i] = new MeleeUnit(newX, newY, 100, 1, tempAttack, 1, team, i.ToString()); break;
                    case 1: units[i] = new RangedUnit(newX, newY, 100, 1, tempAttack, 4, team, i.ToString()); break;
                }
            }
            //      units[0] = new MeleeUnit(0, 0, 100, 1, 10, 0, 0, "0"); 
            //      units[1] = new MeleeUnit(20, 20, 100, 1, 10, 1, 1, "0");
        }

    }
}
