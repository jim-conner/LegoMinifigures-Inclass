using LegoMinifigures_Inclass.Heads;
using LegoMinifigures_Inclass.Legs;
using LegoMinifigures_Inclass.Torsos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures_Inclass.MiniFigures
{
    class MiniFigure
    {
        public HeadBase Head { get; set; }
        public TorsoBase Torso { get; set; }
        public LegBase Leg { get; set; }

        public MiniFigure( HeadBase head, TorsoBase torso, LegBase leg )
        {
            Head = head;
            Torso = torso;
            Leg = leg;
        }

        public void BuildIt()
        {
            Console.WriteLine("I love to build stuff!");
            Head.SayHowdy();
            Head.Spin();
        }
        
    }
}
