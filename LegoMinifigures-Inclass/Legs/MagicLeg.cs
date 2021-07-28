using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Legs
{
    class MagicLeg : LegBase
    {
        public bool HasInvisibleLegs { get; set; }
        public int Length { get; set; } //in inches

        public void MeasureLegs(string size) //small, medium, large
        {
            if (size == "small")
            {
                Length = 2;
            }
            else if (size == "medium")
            {
                Length = 8;
            }else if (size == "large")
            {
                Length = 16;
            }
            else
            {
                Length = 1;
            }
        }

        public override void Walk()
        {
            Console.WriteLine("We all float down here....");
        }
    }
}
