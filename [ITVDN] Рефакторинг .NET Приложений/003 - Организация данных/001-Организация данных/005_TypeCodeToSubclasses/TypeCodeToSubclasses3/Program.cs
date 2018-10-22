using System;

// Replace Type Code With Subclasses (Замена кода типа подклассами). 230 - 231 стр.

namespace ReplaceTypeCodeWithSubclasses
{
    enum EmployeeType
    {
        ENGINEER = 0,
        SALESMAN = 1,
        MANAGER = 2
    }

    abstract class Employee
    {       
        protected Employee()
        {
        }

        public abstract EmployeeType GetTypeEmployee();

        public Employee Create(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.ENGINEER:
                    return new Engineer();
                case EmployeeType.SALESMAN:
                    return new Salesman();
                case EmployeeType.MANAGER:
                    return new Manager();
                default:
                    throw new ArgumentOutOfRangeException("Недопустимое значение кода типа.");
            }
        }
    }

    class Engineer : Employee
    {
        public override EmployeeType GetTypeEmployee()
        {
            return EmployeeType.ENGINEER;
        }
    }

    class Salesman : Employee
    {
        public override EmployeeType GetTypeEmployee()
        {
            return EmployeeType.SALESMAN;
        }
    }

    class Manager : Employee
    {
        public override EmployeeType GetTypeEmployee()
        {
            return EmployeeType.MANAGER;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee engineer = new Engineer();
            Employee salesman = new Salesman();
            Employee manager = new Manager();

            // Delay.
            Console.ReadKey();
        }
    }
}
