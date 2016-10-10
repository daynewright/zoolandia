using System;

namespace Zoolandia.Animals
{
    public class Panthera : Animal
    {
        public void sleep(int hours)
        {
            Console.WriteLine($"A Panthera ({this.commonName}) usually sleeps {hours} hours.");   
        }
    }
}