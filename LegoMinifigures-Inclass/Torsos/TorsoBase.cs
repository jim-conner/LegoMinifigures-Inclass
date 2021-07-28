using LegoMinifigures_Inclass.Heads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.Torsos
{
    abstract class TorsoBase
    {
        public bool HasShirt { get; set; }
        public LegoColor BodyColor { get; set; }
        public string Toolblet { get; set; }

        public virtual void Greeting()
        {
            Console.WriteLine("HIGH FIVE");
        }

        public abstract void Wiggle();
    }
}
