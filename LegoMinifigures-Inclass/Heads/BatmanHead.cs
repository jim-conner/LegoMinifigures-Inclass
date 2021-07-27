using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Heads
{
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        //changed string -> LegoColor where enum limits choices to what's in enum
        //public LegoColorEnum Version { get; set; } //get rid of line bc of ": Headbase" 
        public string FacialExpression { get; set; } = "Stoic";
        //public LegoColor Color => LegoColor.Black;
        public override void Spin()
        {
            base.SayHowdy(); //let me interact directly with the thing I'm inheriting from
            Console.WriteLine("Where is the Joker!?");
        }

        public override void SayHowdy() //marked method as override to allow for custom behavior
        {
            Console.WriteLine("I'm Batman!");
        }
    }


}
