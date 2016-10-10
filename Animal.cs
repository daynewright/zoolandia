using System;

namespace Zoolandia.Animals
    {
        public class Animal
        {
            public string name  { get; set; }
            public string height { get; set; }
            public string weight { get; set; }
            public int legs { get; set; }
            public string commonName { get; set; }
            
            public virtual void eating (string food)
            {
                Console.WriteLine($"This animal is eating {food}" );
            }

            public virtual void sleep ()
            {
                Console.WriteLine("This animal is now sleeping");
            }
        }
    }