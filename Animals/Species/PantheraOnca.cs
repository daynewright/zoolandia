using System;

namespace Zoolandia.Animals
{
    class PantheraOnca : Animal
    {
        public Panthera species = new Panthera();
        public string scientificName = "PantheraOnca";
        public PantheraOnca()
        {
            this.commonName = "Jaguar";
            Console.WriteLine($"{this.commonName}, {this.scientificName}");
        }
        public void sleep(int hours)
        {
            Console.WriteLine($"A Panthera usually sleeps {hours} hours.");   
        }
    }
}