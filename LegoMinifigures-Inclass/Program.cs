using LegoMinifigures_Inclass.Heads;
using LegoMinifigures_Inclass.Torsos;
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

            var heads = new List<HeadBase>() { astronautHead, batmanHead, workerHead };

            foreach (var head in heads)
            {
                head.SayHowdy();
                head.Spin();
            }

            var batmanTorso = new BatSuitTorso();
            batmanTorso.Color = LegoColor.Green;
            batmanTorso.HasBatBoomerang = true;
            batmanTorso.HasShirt = false;
            batmanTorso.Donates();

            var cowboyTorso = new CowboyTorso();

            var sumoTorso = new SumoTorso();

            var torsos = new List<TorsoBase>() { batmanTorso, batmanTorso, sumoTorso };
            foreach (var torso in torsos)
            {
                torso.Greeting();
                torso.Wiggle();
            }

        }
    }
}
