using System;

// Extract Interface (Выделение интерфейса).

namespace ExtractInterface
{
    class Employee
    {
        int rate;
        bool specialSkill;
        string name;
        string departament;

        public Employee(int rate, bool specialSkill, string name, string departament)
        {
            this.rate = rate;
            this.specialSkill = specialSkill;
            this.name = name;
            this.departament = departament;
        }

        public int GetRate()
        {
            return rate;
        }

        public bool HasSpecialSkill()
        {
            return specialSkill;
        }

        public string GetName()
        {
            return name;
        }

        public string GetDepartament()
        {
            return departament;
        }
    }

    class Program
    {
        public static double Charge(Employee emp, int days)
        {
            int @base = emp.GetRate() * days;
            if (emp.HasSpecialSkill())
            {
                return @base * 1.05;
            }
            else
            {
                return @base;
            }
        }

        static void Main()
        {
            Employee kent = new Employee(100, true, "Kent", "IT");
            double charge = Charge(kent, 20);
            Console.WriteLine(charge);

            // Delay.
            Console.ReadKey();
        }
    }
}
