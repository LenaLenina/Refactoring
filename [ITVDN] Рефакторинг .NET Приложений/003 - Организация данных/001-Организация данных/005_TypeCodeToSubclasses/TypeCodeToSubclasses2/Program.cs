﻿using System;
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
                    break;
            }
        }
    }

    class Manager : Employee
    {

        public override EmployeeType EmployeeType
        {
            get { return EmployeeType.Manager; }
        }
    }

    class Engeener : Employee
    {
        public override EmployeeType EmployeeType
        {
            get { return EmployeeType.Engeener; }
        }
    }

    class Salesman : Employee
    {

        public override EmployeeType EmployeeType
        {
            get { return EmployeeType.Salesman; }
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
