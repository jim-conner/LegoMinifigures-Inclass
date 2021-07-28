using LegoMinifigures_Inclass.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Torsos
{
    class BatSuitTorso : TorsoBase
    {
        public bool HasBatBoomerang { get; set; }
        public LegoColor Color { get; internal set; } //did I do that?

        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("Does a fist bump.");
        }

        public override void Wiggle()
        {
            Console.WriteLine("Muscle flexin'");
        }

        public void Donates()
        {
            Console.WriteLine("Donated $150M to the Children's Fund!");
        }
    }
}
