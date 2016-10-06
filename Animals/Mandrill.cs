
using System;

namespace Zoolandia 
{
    public class Mandrill : Animal 
    {
        public void talk ()
        {
            Console.WriteLine($"{this.name} the {this.commonName} just said Ooo,Ooo,Ahh,Ahh!");
        } 
    }

}