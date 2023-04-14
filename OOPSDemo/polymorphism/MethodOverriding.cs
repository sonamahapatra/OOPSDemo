using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.polymorphism
{
    public class Animal
    {
        public string name;
        
        public virtual void Run()
        {
            Console.WriteLine("running Slow");
        }
        public void AnimalDetails()
        {
            Console.WriteLine("Name of The Animal: "+ name);
        }
    }
    class Lion :Animal
    {
        public override void Run() 
        {
            Console.WriteLine("running faster");

        }
    }
}
