using System;

namespace Zoolandia 
{
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine($"{this.name} the dog said WOOF! WOOF!");
        }
    }
}