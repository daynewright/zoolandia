
using System;

namespace Zoolandia.Animals
{
    public class Aix
    {
        public string genusName {get; set;}
        public Aix()
        {
            this.genusName = "Aix";
        }
        public virtual void tweet(string name)
        {
            Console.WriteLine($"This {name} bird just went TWEET TWEET!! (from Aix.cs)");
        }

    }
}