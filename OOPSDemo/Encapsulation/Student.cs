using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo.Encapsulation
{
    public class Student
    {
        private string studentName;

        public string Name
        {
            get { return studentName; }
            set {
                if (value.Length >= 3)
                    studentName = value;
                else
                    Console.WriteLine("Please Enter Minimum 3 letters name");
            }
        }
      //  public string studentName { get; set; }

    }
   
}
