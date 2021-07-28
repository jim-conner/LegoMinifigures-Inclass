using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Legs
{
    abstract class LegBase //dont' forget -> abstract lets us do inheritance
    {
        public BottomsType Bottoms { get; set; }
        public ShoesType Kicks { get; set; }

        public virtual void Dance()
        {
            Console.WriteLine("Rock that Electric Slide.");
        }
        public abstract void Walk();
    }
}
