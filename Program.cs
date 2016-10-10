using System;
using Zoolandia.Animals;


namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CLupus dog = new CLupus()
            {
                name = "Fluffy",
                height = "5 inches",
                weight = "50 lbs",
                commonName = "dog",
                legs = 4
            };      

            dog.bark();
            dog.eating("a bone");
            Console.WriteLine("\n");

            AixSponsa bird = new AixSponsa()
            {
                name = "Tweety",
                height ="tiny",
                weight = "5 ounces",
                commonName = "bird",
                legs = 2
            };

            bird.tweet();
            bird.eating("bird seed");
            Console.WriteLine("\n");

            Mandrill monkey = new Mandrill("monkey")
            {
                name = "Bob",
                height = "4 feet",
                weight = "30lbs",
                legs = 2
            };

            monkey.talk();
            monkey.eating("banana");
            Console.WriteLine("\n");


            Mandrill monkey4legs = new Mandrill(4)
            {
                name = "Tom",
                height = "3 feet",
                weight = "25lbs",
                commonName = "monkey"
            };

            monkey4legs.talk();
            monkey4legs.eating("popcorn");
            Console.WriteLine("\n");


            Mandrill monkeyNext = new Mandrill("Luke", 6)
            {
                height = "3 feet",
                weight = "25lbs",
                commonName = "monkey"
            };

            monkeyNext.talk();
            monkeyNext.eating("popcorn");
            monkeyNext.sleep();
            Console.WriteLine("\n");


            DicerosBicornis rhino = new DicerosBicornis();
            rhino.sleep();
            Console.WriteLine("\n");


            PantheraOnca jaguar = new PantheraOnca();
            jaguar.sleep(8);

        }
    }
}
