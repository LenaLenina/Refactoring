using System;
using System.Collections;

// Extract Superclass (Выделение родительского класса).

namespace ExtractSuperclass
{
    abstract class Party
    {
        protected string name;

        public Party(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public abstract int GetAnnualCost();
    }

    class Employee : Party
    {
        string id;
        int annualCost;

        public Employee(string name, string id, int annualCost)
            : base(name)
        {
            this.id = id;
            this.annualCost = annualCost;
        }

        public override int GetAnnualCost()
        {
            return annualCost;
        }

        public string GetId()
        {
            return id;
        }
    }

    class Departament : Party
    {
        ArrayList staff = new ArrayList();

        public Departament(string name)
            : base(name)
        {
        }

        public override int GetAnnualCost()
        {
            int result = 0;

            foreach (Employee employee in staff)
            {
                result += employee.GetAnnualCost();
            }
            return result;
        }

        public int GetHeadCount()
        {
            return staff.Count;
        }

        public IEnumerator GetStaff()
        {
            return staff.GetEnumerator();
        }

        public void AddStaff(Employee arg)
        {
            staff.Add(arg);
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
