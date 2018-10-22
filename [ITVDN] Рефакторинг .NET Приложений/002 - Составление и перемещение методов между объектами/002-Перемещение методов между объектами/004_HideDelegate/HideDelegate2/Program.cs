using System;

// Hide Delegate (Сокрытие делегирования). 168 стр.

namespace HideDelegate
{
    class Person
    {
        Departament departament;

        public Person()
        {
            departament = new Departament(this);
        }

        public void SetDepartament(Departament arg)
        {
            departament = arg;
        }

        public Person GetManager()
        {
            return departament.GetManager();
        }
    }

    class Departament
    {
        private string chargeCode;
        private Person manager;

        public Departament(Person manager)
        {
            this.manager = manager;
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
            Person john = new Person();
            Person mark = new Person();

            Departament hr = new Departament(john);
            Departament rnd = new Departament(mark);

            Person manager = john.GetManager();

            // Delay.
            Console.ReadKey();
        }
    }
}
