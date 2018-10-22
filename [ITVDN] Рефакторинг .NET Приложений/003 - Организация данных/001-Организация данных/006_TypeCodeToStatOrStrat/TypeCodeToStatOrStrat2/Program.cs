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
        TypeEmployee type;

        public EmployeeType EmployeeType
        {
            get { return type.Type; }

            set
            {
                switch (value)
                {
                    case EmployeeType.Manager:
                        type = new Manager();
                        break;
                    case EmployeeType.Engeener:
                        type = new Engeener();
                        break;
                    case EmployeeType.Salesman:
                        type = new Salesman();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public Employee(EmployeeType type)
        {
            EmployeeType = type;
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

    abstract class TypeEmployee
    {
        public abstract EmployeeType Type { get; }
    }

    class Manager : TypeEmployee
    {
        public override EmployeeType Type
        {
            get { return EmployeeType.Manager; }
        }
    }

    class Engeener : TypeEmployee
    {
        public override EmployeeType Type
        {
            get { return EmployeeType.Engeener; }
        }
    }

    class Salesman : TypeEmployee
    {
        public override EmployeeType Type
        {
            get { return EmployeeType.Salesman; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
