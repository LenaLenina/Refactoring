using System;

// Extract Subclass (Выделение подкласса).

namespace ExtractSubclass
{

    class WrongEmployeeTypeException : Exception
    {
        public WrongEmployeeTypeException(string message)
            : base(message)
        {
        }
    }

    enum EmployeeType
    {
        Engeener,
        Salesman,
        Manager
    }

    class Employee
    {
        EmployeeType type;

        internal EmployeeType Type
        {
            get { return type; }
        }

        public Employee(EmployeeType type)
        {
            this.type = type;
        }
    }

    class Engeener : Employee
    {
        public Engeener()
            : base(EmployeeType.Engeener)
        {
        }

        public void TestEquipment()
        {
            Console.WriteLine("Testing equipment...");
        }
    }

    class Manager : Employee
    {
        public void CheckMail()
        {
            Console.WriteLine("Checking email...");
        }

        public Manager()
            : base(EmployeeType.Manager)
        {
        }
    }

    class Salesman : Employee
    {
        public Salesman()
            : base(EmployeeType.Salesman)
        {
        }

        public void MakeRediscount()
        {
            Console.WriteLine("Making rediscount...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Engeener tom = new Engeener();

            try
            {
                tom.TestEquipment();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}

