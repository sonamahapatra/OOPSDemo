using OOPSDemo.polymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Choose One From Below Option: ");
            Console.WriteLine("1.Inheritance\n2.polymorphism\n");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Car car= new Car();
                    car.modelNumber = 2022;
                    car.brand = "BMW";
                    car.Start();
                    break;
                    case 2:
                        Addition addition = new Addition();
                    addition.AddNumbers(10, 45.67, 50);
                    break;
                default:
                    Console.WriteLine("Please Choose program with given option");
                    break;
            }
                

            
            Console.ReadLine();
        }
    }
}
