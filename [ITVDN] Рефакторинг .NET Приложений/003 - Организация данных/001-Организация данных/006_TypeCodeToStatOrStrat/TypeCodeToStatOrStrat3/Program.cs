using System;

// Replace Type Code With State/Strategy (Замена кода типа состоянием/стратегией).

namespace ReplaceTypeCodeWithStateOrStrategy
{
    class Employee
    {
        EmployeeType  type;
        public const int ENGINEER = 0;
        public const int SALESMAN = 1;
        public const int MANAGER = 2;

        int monthlySalary;
        int commission;
        int bonus;

        
        public void SetTypeEmployee(int arg)
        {
            switch(arg)
            {
                case ENGINEER:
                    this.type = new Engineer();
                    break;
                case SALESMAN:
                    this.type = new Salesman();
                    break;
                case MANAGER:
                    this.type = new Manager();
                    break;
                default:
                    throw new Exception("Неправильный код служащего.");
            }
        }

        public int GetTypeEmployee()
        {
            return this.type.GetTypeCode();
        }

        public int PayAmount()
        {
            switch (GetTypeEmployee())
            {
                case ENGINEER:
                    return monthlySalary;
                case SALESMAN:
                    return monthlySalary + commission;
                case MANAGER:
                    return monthlySalary + bonus;
                default:
                    throw new Exception("Не тот служащий.");
            }
        }
    }

    abstract class EmployeeType
    {
        public abstract int GetTypeCode();
    }

    class Engineer : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Employee.ENGINEER;
        }
    }

    class Salesman : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Employee.SALESMAN;
        }
    }

    class Manager : EmployeeType
    {
        public override int GetTypeCode()
        {
            return Employee.MANAGER;
        }
    }

    class Program
    {
        static void Main()
        {


            // Delay.
            Console.ReadKey();
        }
    }
}
