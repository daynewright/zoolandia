using System;

namespace Zoolandia 
{
    class PantheraOnca : Animal
    {
        string scientificName = "PantheraOnca";
        public PantheraOnca()
        {
            this.commonName = "Jaguar";
            Console.WriteLine($"{this.commonName}, {this.scientificName}");
        }
    }
}