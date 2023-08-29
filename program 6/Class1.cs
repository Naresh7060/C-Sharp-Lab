using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ass2_Ques6
{
    internal partial class Employee
    {
        public void Show()
        {
            Console.WriteLine("Name of Employee is : " + Name);
            Console.WriteLine("Salary = " + (BasicSal + 0.10*BasicSal + 0.05*BasicSal));
        }
    }
}
