
using System;

namespace Zoolandia 
{
    public class Mandrill : Animal 
    {
        public void talk ()
        {
            Console.WriteLine($"{this.name} the {this.commonName} just said Ooo,Ooo,Ahh,Ahh!");
        } 

        public override void eating(string food)
        {
            Console.WriteLine($"The {this.commonName} (Mandrill) is eating {food}.");
        }

        public Mandrill(string name)
        {
            this.commonName = name;
        }

    }

}