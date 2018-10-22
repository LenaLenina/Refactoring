using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Replace Type Code With State (Замена кода типа состоянием).

namespace TypeCodeToStat
{
    enum EmployeeType
    {
        Manager,
        Engeener,
        Salesman
    }

    class Employee
    {
        EmployeeType type;

        public EmployeeType EmployeeType
        {
            get { return type; }
            set { type = value; }
        }

        public Employee(EmployeeType type)
        {
            this.type = type;
        }

        public void DescribeYourself()
        {
            switch (EmployeeType)
            {
                case EmployeeType.Manager:
                    Console.WriteLine("hi, I'm the manager. I accept orders from customers.");
                    break;
                case EmployeeType.Engeener:
                    Console.WriteLine("Hi, I'm an engineer. I repair equipment.");
                    break;
                case EmployeeType.Salesman:
                    Console.WriteLine("Hi, I am salesman. I sell products.");
                    break;
                default:
                    throw new Exception();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
