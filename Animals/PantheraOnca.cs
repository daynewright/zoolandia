using System;

namespace Zoolandia 
{
    class PantheraOnca : Animal
    {
        new string commonName = "Jaguar";
        private string scientificName = "PantheraOnca";
        public PantheraOnca()
        {
            Console.WriteLine($"{commonName}");
        }
    }
}