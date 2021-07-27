using LegoMinifigures_Inclass.Heads;
using System;
using System.Collections.Generic;

namespace LegoMinifigures_Inclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var workerHead = new ConstructionWorkerHead();

            workerHead.Color = LegoColor.Yellow;
            //head.SayHowdy();

            var batmanHead = new BatmanHead();
            //batmanHead.SayHowdy();

            var astronautHead = new AstronautHead();

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead};

            foreach (var head in heads)
            {
                head.SayHowdy();
                head.Spin();
            }
        }
    }
}
