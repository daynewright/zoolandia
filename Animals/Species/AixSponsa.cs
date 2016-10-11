using System;

namespace Zoolandia.Animals
{
    class AixSponsa : Animal 
    {
        public Aix Genus = new Aix();

        public override void eating(string food)
        {
            Console.WriteLine($"The {this.commonName} (Aix Sponsa) is eating {food}.");
        }
        public void tweet()
        {
            Console.WriteLine($"{this.name} the {this.commonName} goes TWEET TWEET!! (from AixSponsa.cs)");
        }
    }
}