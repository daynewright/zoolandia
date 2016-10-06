using System;

namespace Zoolandia 
{
    class CLupus : Animal
    {
        public void bark()
        {
            Console.WriteLine($"{this.name} the {this.commonName} said WOOF! WOOF!");
        }
    }
}