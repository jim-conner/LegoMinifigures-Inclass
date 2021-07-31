using LegoMinifigures_Inclass.Heads;
using LegoMinifigures_Inclass.Legs;
using LegoMinifigures_Inclass.MiniFigures;
using LegoMinifigures_Inclass.Torsos;
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

            var seaLeg = new SeaLeg();
            seaLeg.AreWobbly = true;
            seaLeg.Bottoms = Bottoms.None;
            seaLeg.NumberOfLegs = 3;
            //seaLeg.Shoes = Shoes.ShellToedAdidas;

            var magicLeg = new MagicLeg();
            magicLeg.Bottoms = Bottoms.Chaps;
            magicLeg.HasInvisibleLegs = true;
            magicLeg.MeasureLegs("small");
            Console.WriteLine($"Magic legs have a length of {magicLeg.Length}.");

            var legs = new List<LegBase>() { magicLeg, seaLeg };

            foreach (var leg in legs)
            {
                leg.Dance();
                leg.Walk();
            }

            Console.WriteLine("Before Bob.");

            var bob = new MiniFigure(workerHead, cowboyTorso, seaLeg ); //creating new type of SeaLeg
            bob.BuildIt();
            
            Console.WriteLine("You just Bob do his thing!");
            Console.ReadLine();
        }
    }
}
