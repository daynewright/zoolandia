using System;

namespace Zoolandia 
{
    class CLupus : Animal
    {
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