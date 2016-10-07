
namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Zoolandia.CLupus dog = new Zoolandia.CLupus()
            {
                name = "Fluffy",
                height = "5 inches",
                weight = "50 lbs",
                commonName = "dog",
                legs = 4
            };      

            dog.bark();
            dog.eating("a bone");

            Zoolandia.AixSponsa bird = new Zoolandia.AixSponsa()
            {
                name = "Tweety",
                height ="tiny",
                weight = "5 ounces",
                commonName = "wood duck",
                legs = 2
            };

            bird.tweet();
            bird.eating("bird seed");

            Zoolandia.Mandrill monkey = new Zoolandia.Mandrill("monkey")
            {
                name = "Bob",
                height = "4 feet",
                weight = "30lbs",
                legs = 2
            };

            monkey.talk();
            monkey.eating("banana");

            Zoolandia.Mandrill monkey4legs = new Zoolandia.Mandrill(4)
            {
                name = "4 Leg Tom",
                height = "3 feet",
                weight = "25lbs",
                commonName = "monkey"
            };

            monkey4legs.talk();
            monkey4legs.eating("popcorn");
        }
    }
}
