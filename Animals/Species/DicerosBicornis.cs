using System;

namespace Zoolandia.Animals 
{
    class DicerosBicornis : Animal
    {
        public Diceros Genus = new Diceros();
        string scientificName = "Diceros Bicornis";
        public DicerosBicornis(){
            this.commonName = "Black Rino";
            Console.WriteLine($"\n {this.commonName}, {this.scientificName}");
        }

        public override void sleep()
        {
            Console.WriteLine($"{this.commonName} is currently sleeping.");
        }
    }
}