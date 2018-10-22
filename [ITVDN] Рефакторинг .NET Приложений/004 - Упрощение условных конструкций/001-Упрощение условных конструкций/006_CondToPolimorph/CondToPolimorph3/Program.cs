using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Replace Conditional With Polimorphism (Замена условного оператора полиморфизмом). 261 стр.

namespace ReplaceConditionalWithPolimorphism
{
    enum EmployeeType
    {
        Manager,
        Engeener,
        Salesman
    }

    abstract class Employee
    {
        public abstract EmployeeType EmployeeType { get; }

        public static Employee Create(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Manager:
                    return new Manager();
                case EmployeeType.Engeener:
                    return new Engeener();
                case EmployeeType.Salesman:
                    return new Salesman();
                default:
                    throw new ArgumentException();
            }
        }

        public abstract void DescribeYourself();
    }

    class Manager : Employee
    {
        public override EmployeeType EmployeeType
        {
            get { return EmployeeType.Manager; }
        }

        public override void DescribeYourself()
        {
            Console.WriteLine("hi, I'm the manager. I accept orders from customers.");
        }
    }

    class Engeener : Employee
    {
        public override EmployeeType EmployeeType
        {
            get { return EmployeeType.Engeener; }
        }

        public override void DescribeYourself()
        {
            Console.WriteLine("Hi, I'm an engineer. I repair equipment.");
        }
    }

    class Salesman : Employee
    {
        public override EmployeeType EmployeeType
        {
            get { return EmployeeType.Salesman; }
        }

        public override void DescribeYourself()
        {
            Console.WriteLine("Hi, I am salesman. I sell products.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee alex = Employee.Create(EmployeeType.Engeener);

            alex.DescribeYourself();
        }
    }
}
