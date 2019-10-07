using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class ResourceBuilding : Building
    {
        private string unitType;
        private int totalResources;
        private int roundResources;
        private int remainingResources;
        private int spawnX;
        private int spawnY;

        public override int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int HP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override char Team { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override char Symbol { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void death()
        {
            Console.WriteLine("Resource Building" + this.Symbol + "at" this.SpawnX + "," + this.SpawnY = "is dead!");
        }

        public override string ToString()
        {
            return "This is a resource building belonging to Team " + this.Team + ". It looks like this: " + this.Symbol + "\n positioned at " + this.X + "," + this.Y + ". \n HP: " + this.hp
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
