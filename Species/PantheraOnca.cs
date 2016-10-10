using System;

namespace Zoolandia.Animals
{
    class PantheraOnca : Panthera
    {
        string scientificName = "PantheraOnca";
        public PantheraOnca()
        {
            this.commonName = "Jaguar";
            Console.WriteLine($"{this.commonName}, {this.scientificName}");
        }
    }
}