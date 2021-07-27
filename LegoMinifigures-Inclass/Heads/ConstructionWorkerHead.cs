using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Heads
{
    class ConstructionWorkerHead : HeadBase
    {
        public bool HasMullet { get; set; }
        //public string Color { get; set; } //...hides inherited member error
        public int NumberofTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            //setting property to the opposite value
            WearingHardHat = !WearingHardHat;
            Console.WriteLine($"The Construction Worker head {(WearingHardHat ? "is" : "is not")} wearning its hard hat");
            return WearingHardHat;
        }
        public override void Spin()
        {
            if (NumberofTeeth > 0)
                NumberofTeeth -= 1; //curly braces optional for 1 line

            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder");
        }

        //behavior is now being defined from within HeadBase
        //public void SayHowdy()
        //{
        //    Console.WriteLine("The Construction Worker Head says howwwwdy.");
        //}
    }
}
