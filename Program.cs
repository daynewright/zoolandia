
namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Zoolandia.Dog dog = new Zoolandia.Dog
            {
                name = "Fluffy",
                height = "5 inches",
                weight = "50 lbs"
            };      

            dog.bark();

            Zoolandia.Bird bird = new Zoolandia.Bird()
            {
                name = "Tweety",
                height ="tiny",
                weight = "5 ounces"
            };

            bird.tweet();

            Zoolandia.Monkey monkey = new Zoolandia.Monkey()
            {
                name = "Bob",
                height = "4 feet",
                weight = "30lbs"
            };

            monkey.eatBanana();
        }
    }
}
