using System;

namespace Zoolandia.Animals
{
    class Spheniscidae: Animal
    {
        public string scientificName {get; set;}

        public Aptenodytes Genus {get; set;}
        public Spheniscidae()
        {
            this.scientificName = "Spheniscidae";
            this.Genus  = new Aptenodytes();
            this.commonName = "Penguin";
            Console.WriteLine($"{this.commonName}, {this.scientificName}");
            Console.WriteLine($"This animal is of the genus {this.Genus.genusName}");
        }
        public virtual void tweet()
        {
            Console.WriteLine("This bird just went TWEET TWEET!!");
        }

        public override void sleep()
        {
            Console.WriteLine($"{this.commonName} is currently sleeping.");
        }
    }
}