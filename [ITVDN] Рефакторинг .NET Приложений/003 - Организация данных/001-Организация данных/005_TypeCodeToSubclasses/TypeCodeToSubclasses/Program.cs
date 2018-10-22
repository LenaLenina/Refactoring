using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Замена кода типа подклассами

namespace ConsoleApplication14
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

        public Employee(EmployeeType type)
        {
            this.type = type;
        }

        public void DescribeYourself()
        {
            switch (type)
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
                    break;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee Alex = new Employee(EmployeeType.Engeener);

            Alex.DescribeYourself();
        }
    }
}
