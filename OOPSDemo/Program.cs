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
            Console.WriteLine("1.Inheritance\n");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Car car= new Car();
                    car.modelNumber = 2022;
                    car.brand = "BMW";
                    car.Start();
                    break;
                default:
                    Console.WriteLine("Please Choose program with given option");
                    break;
            }
                

            
            Console.ReadLine();
        }
    }
}
