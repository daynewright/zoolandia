
using System;

namespace Zoolandia 
{
    public class Monkey : Animal 
    {
        public void eatBanana ()
        {
            Console.WriteLine($"{this.name} the monkey just ate a banana.");
        } 
    }

}