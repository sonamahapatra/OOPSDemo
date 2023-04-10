using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.polymorphism
{
    internal class Addition
    {
        public void AddNumbers(int first , int second)
        {
            Console.WriteLine("Sum:" + first + second);
        }
        //varying number of parameters compared to 1st method
        public void AddNumbers(int first ,int second , int third)
        {
           double Result = first + second + third; 
            Console.WriteLine("Sum:" + Result);
        }
        //Changing datatype compared to 2nd method
        public void AddNumbers(int first ,double second, int third)
        {
            double Result = first + second + third;
            Console.WriteLine("Sum:" + Result);
        }
        //Changing order compared to 3rd method
        public void AddNumbers(double second , int first,int third)
        {
            double Result = first + second + third;
            Console.WriteLine("Sum:" + Result);
        }
    }
}
