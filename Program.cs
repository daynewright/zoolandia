
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
                commonName = "dog"
            };      

            dog.bark();
            dog.eating("a bone");

            Zoolandia.AixSponsa bird = new Zoolandia.AixSponsa()
            {
                name = "Tweety",
                height ="tiny",
                weight = "5 ounces",
                commonName = "wood duck"
            };

            bird.tweet();
            bird.eating("bird seed");

            Zoolandia.Mandrill monkey = new Zoolandia.Mandrill()
            {
                name = "Bob",
                height = "4 feet",
                weight = "30lbs",
                commonName = "monkey"
            };

            monkey.talk();
            monkey.eating("banana");
        }
    }
}
