
using System;

namespace Zoolandia 
{
    public class Mandrill : Animal 
    {
        public void talk ()
        {
            Console.WriteLine($"{this.name} the {this.commonName} just said Ooo,Ooo,Ahh,Ahh!");
            Console.WriteLine($"{this.name} has {this.legs} legs.");
        } 

        public override void eating(string food)
        {
            Console.WriteLine($"The {this.commonName} (Mandrill) is eating {food}.");
        }

        public Mandrill(string name)
        {
            this.commonName = name;
        }

        public Mandrill(int legs)
        {
            this.legs = legs;
        }
    }

}