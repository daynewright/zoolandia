using System;

namespace Zoolandia 
{
    class Spheniscidae : Animal
    {
        new string commonName = "Penguin";
        private string scientificName = "Spheniscidae";
        public Spheniscidae()
        {
            Console.WriteLine($"{commonName}");
        }
    }
}