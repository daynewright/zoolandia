using System;

namespace Zoolandia.Animals
{
    class Spheniscidae : Aptenodytes
    {
        string scientificName = "Spheniscidae";
        public Spheniscidae()
        {
            this.commonName = "Penguin";
            Console.WriteLine($"{this.commonName}, {this.scientificName}");
        }

        public override void sleep()
        {
            Console.WriteLine($"{this.commonName} is currently sleeping.");
        }
    }
}