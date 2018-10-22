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

        public Employee(EmployeeType type)
        {
            this.type = type;
        }

        public void CheckMail()
        {
            AssertEmployeeType(type == EmployeeType.Manager);
            Console.WriteLine("Checking email...");
        }

        public void TestEquipment()
        {
            AssertEmployeeType(type == EmployeeType.Engeener);
            Console.WriteLine("Testing equipment...");
        }

        public void MakeRediscount()
        {
            AssertEmployeeType(type == EmployeeType.Salesman);
            Console.WriteLine("Making rediscount...");
        }

        private void AssertEmployeeType(bool condition)
        {
            if (condition == false)
                throw new WrongEmployeeTypeException("This employee can not do such work");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee tom = new Employee(EmployeeType.Engeener);

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

