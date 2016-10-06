using System;

namespace Zoolandia 
{
    class AixSponsa : Animal 
    {
        public void tweet()
            {
                Console.WriteLine($"{this.name} the bird said TWEET! TWEET!");
            }
    }
}