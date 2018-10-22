using System;

// Remove Middle Man (Удаление посредника). 172 стр.

namespace RemoveMiddleMan
{
    class Person
    {
        Departament departament;

        public Person GetManager()
        {
            return departament.GetManager();
        }

        public Departament GetDepartament()
        {
            return departament;
        }

        public void SetDepartament(Departament departament)
        {
            this.departament = departament;
        }
    }

    class Departament
    {
        Person manager;

        public Departament(Person manager)
        {
            this.manager = manager;
            this.manager.SetDepartament(this);
        }

        public Person GetManager()
        {
            return manager;
        }
    }

    class Program
    {
        static void Main()
        {
            Person mark = new Person();
            Departament hr = new Departament(mark);

            Person manager = mark.GetDepartament().GetManager();

            // Delay.
            Console.ReadKey();
        }
    }
}
