using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class FactoryBuilding : Building
    {
        private string unitType;
        private int speed;
        private int spawnX;
        private int spawnY;

        public string UnitType
        {
            get;
            set;
        }

        public int Speed
        {
            get;
            set;
        }

        public int SpawnX
        {
            get;
            set;
        }

        public int SpawnY
        {
            get;
            set;
        }
        public override int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override char Team { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override char Symbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public FactoryBuilding(int x, int y, char team, char symbol, string units)
        {
            unitType = units;
            Speed = speed;
            SpawnX = x;

            if (y != 0)
            {
                spawnY = spawnY - 1;
            }
            else
            {
                spawnY = spawnY + 1;
            }
        }

        public Unit generateUnit()
        {
            UnitType unit = null;

            Random r = new Random();
            string name = "";

            if (unitType == "Melee")
            {
                if (r.Next(0, 2) == 0)
                {
                    name = "Knight";
                }
                else
                {
                    name = "Recruit";
                }

                if (UnitType == "Ranged")
                {
                    if (r.Next(0, 2) == 0)
                    {
                        name = "Fire Wizard";
                    }
                    else
                    {
                        name = "Archer";
                    }
                }

                if (UnitType == "Melee") && (Team == 'Shield');
                {
                    unit = new MeleeUnit(SpawnX, SpawnY, Team, 'K', name);
                }
                else if (UnitType == "Melee" && (Team == 'Hammer'))
                {
                    unit = new MeleeUnit(SpawnX, SpawnY, Team, 'Bow', name);
                }

                if (UnitType == "Ranged") && (Team == 'Shield');
                {
                    unit = new RangedUnit(SpawnX, SpawnY, Team, 'K', name);
                }
                else if (UnitType == "Ranged" && (Team == 'Hammer'))
                {
                    unit = new RangedUnit(SpawnX, SpawnY, Team, 'Bow', name);
                }
                return unit;
            }
        }
            public override void death()
                {
                Console.WriteLine("Factory Building" + this.Symbol + "at" this.SpawnX + "," + this.SpawnY = "is dead!");
                }

            public override string ToString()
        {
            return "This is a factory belonging to Team " + this.Team + ". It looks like this: " + this.Symbol + "\n positioned at " + this.X + "," + this.Y + ". \n HP: " + this.hp
                + "\n Create: " + this.unitType + " units every" + this.Speed + " second(s) at " + this.spawnX + "," + this.spawnY;
        }

        public override void save()
        {
            FileStream savefile = new FileStream("saves/buildin.game", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(savefile);

            writer.WriteLine(Symbol + ", " + Team + ", " + X + ", " + Y + ", " + hp + ", " + unitType + ", " + speed);
            Console.WriteLine("Saved!");
            writer.Close();
            savefile.Close();
        }
    }
}
