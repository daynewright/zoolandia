using System;

namespace Zoolandia.Animals
{
    public class Aptenodytes
    {
        public string genusName {get; set;}
        public Aptenodytes()
        {
            this.genusName = "Aptenodytes";
        }
         public virtual void tweet()
        {
            Console.WriteLine("This bird just went TWEET TWEET!! (from Aptenodytes.cs)");
        }
        
    }
}