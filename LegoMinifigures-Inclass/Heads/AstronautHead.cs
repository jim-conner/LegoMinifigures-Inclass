using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Heads
{
    class AstronautHead : HeadBase
    {
        //public LegoColor Color { get; set; } //bc I aadded HeadBase above
        public bool WearingHelmet {get;set;}
        public FacialHair FacialHair { get; set; }

        public override void SayHowdy() {
            base.SayHowdy();
            Console.WriteLine("Major Tom to Ground Control...");
        }

        public override void Spin()
        {
            Console.WriteLine("The Astronaut head spins to take in the beauty of the cosmos");
        }

        public void Shave()
        {
            Console.WriteLine($"The Astronaut head shaves it's {FacialHair}");
            FacialHair = FacialHair.None;
        }
    }
}
