using OOPSDemo.Encapsulation;
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
            Console.WriteLine("1.Inheritance\n2.polymorphism\n3.Method Overriding \n4.Encapsulation");
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
                case 3:
                    Animal animal= new Animal();
                    animal.name = "Elephant";
                    animal.AnimalDetails();
                    animal.Run();

                    Lion lion = new Lion();
                    lion.name = "Lion";
                    lion.AnimalDetails();
                    lion.Run();
                    break;
                    case 4:
                        Student student= new Student();
                    Console.WriteLine("Enter Your Student Name:");
                    student.Name =Console.ReadLine();
                    Console.WriteLine("Name :"+ student.Name);
                    break;
                default:
                    Console.WriteLine("Please Choose program with given option");
                    break;
            }
                

            
            Console.ReadLine();
        }
    }
}
