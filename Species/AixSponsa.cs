using System;

namespace Zoolandia.Animals
{
    class AixSponsa : Aix 
    {
        public override void tweet()
            {
                Console.WriteLine($"{this.name} the bird said TWEET! TWEET!");
            }
        public override void eating(string food)
        {
            Console.WriteLine($"The {this.commonName} (Aix Sponsa) is eating {food}.");
        }
    }
}