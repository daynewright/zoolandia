using System;

namespace Zoolandia {
    public class Animal
    {
        public string name  { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string commonName { get; set; }

        public virtual void eating (string food)
        {
            Console.WriteLine("{this.commonName} is eating {food}" );
        }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }

    }
}
