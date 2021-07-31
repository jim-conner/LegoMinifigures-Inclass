using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Heads
{
    //class isn't intended to be instantiated  -- only to be used for inheritance
    abstract class HeadBase
    {
        public LegoColor Color { get; set; }

        //change void -> virtual
        public virtual void SayHowdy()
        {
            Console.WriteLine("What is up.");
        }

        // abstrqact is forcing inherited classes to have this behavior
        // below i am saying every class that inherits from abstract headbase must 
        // have a method that looks like this... I'm not saying what it should DO 
        // I don't know what the behavior is, but I know it looks like this
        public abstract void Spin();
        // whatever uses it must override it's method
    }
}
