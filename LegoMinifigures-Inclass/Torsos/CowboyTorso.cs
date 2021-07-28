using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Torsos
{
    class CowboyTorso : TorsoBase
    {
        public bool HasPullString { get; set; }
        public bool HasHolster { get; set; }

        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("There's a snake in my boot!");
        }

        public override void Wiggle() {
            Console.WriteLine("Cowboy reaches in his holster, and pulls out a banana.");
        }

        public void LassoDance()
        {
            Console.WriteLine("Work it, Cowboy - It's all in the wrist!");
        }
    }
}
