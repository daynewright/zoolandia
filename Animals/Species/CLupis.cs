using System;

namespace Zoolandia.Animals
{
    class CLupus : Animal
    {
        public Canis Genus = new Canis();

        public void bark()
        {
            Console.WriteLine($"{this.name} the {this.commonName} said WOOF! WOOF!");
        }
        public override void eating(string food)
        {
            Console.WriteLine($"The {this.commonName} (C. Lupis) is eating {food}.");
        }
    }
}