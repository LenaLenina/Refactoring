using System;
using System.Collections;

// Extract Superclass (Выделение родительского класса).

namespace ExtractSuperclass
{
    class Employee
    {
        string name;
        string id;
        int annualCost;

        public Employee(string name, string id, int annualCost)
        {
            this.name = name;
            this.id = id;
            this.annualCost = annualCost;
        }

        public int GetAnnualCost()
        {
            return annualCost;
        }

        public string GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Departament
    {
        string name;
        ArrayList staff = new ArrayList();

        public Departament(string name)
        {
            this.name = name;
        }

        public int GetTotalAnnualCost()
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

        public string GetName()
        {
            return name;
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
