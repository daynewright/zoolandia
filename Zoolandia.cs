using System;

namespace Zoolandia {
    public class Animal
    {
        public string name  { get; set; }
        public string height { get; set; }
        public string weight { get; set; }

        public virtual void hunting()
        {
            Console.WriteLine("Animal is now searching for food");
        }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }

    }
}
