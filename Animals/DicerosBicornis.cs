using System;

namespace Zoolandia 
{
    class DicerosBicornis : Animal
    {
        new string commonName = "Black Rino";
        private string scientificName = "Diceros Bicornis";
        public DicerosBicornis(){
            Console.WriteLine($"{commonName}");
        }
    }
}