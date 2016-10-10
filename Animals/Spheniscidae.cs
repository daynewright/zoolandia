using System;

namespace Zoolandia 
{
    class Spheniscidae : Animal
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