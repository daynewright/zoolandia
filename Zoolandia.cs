using System;

namespace Zoolandia {
    public class Animal
    {
        public string name  { get; set; }
        public string height { get; set; }
        public string weight { get; set; }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }

    }

    public class Monkey: Animal
    {
        public void eatBanana ()
        {
            Console.WriteLine($"{this.name} the monkey just ate a banana.");
        } 
    }

    public class Dog: Animal 
    {
        public void bark()
        {
            Console.WriteLine($"{this.name} the dog said WOOF! WOOF!");
        }
    }

    public class Bird: Animal
    {
        public void tweet()
        {
            Console.WriteLine($"{this.name} the bird said TWEET! TWEET!");
        }
    }

}
