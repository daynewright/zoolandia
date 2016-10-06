using System;

namespace Zoolandia 
{
    class Bird : Animal 
    {
        public void tweet()
            {
                Console.WriteLine($"{this.name} the bird said TWEET! TWEET!");
            }
    }
}