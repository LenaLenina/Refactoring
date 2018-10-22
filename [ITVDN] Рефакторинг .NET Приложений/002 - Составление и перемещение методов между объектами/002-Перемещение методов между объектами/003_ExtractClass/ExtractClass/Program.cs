using System;

// Extract Class (Выделение класса). 162 - 163 стр.

namespace ExtractClass
{
    class Person
    {
        string name;
        string officeAreaCode;
        string officeNumber;

        public Person(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTelephoneNumber()
        {
            return "(" + officeAreaCode + ")" + officeNumber;
        }

        public string GetOfficeAreaCode()
        {
            return officeAreaCode;
        }

        public void SetOfficeAreaCode(string arg)
        {
            officeAreaCode = arg;
        }

        public string GetOfficeNumber()
        {
            return officeNumber;
        }

        public void SetOfficeNumber(string arg)
        {
            officeNumber = arg;
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person("Martin");
            person.SetOfficeAreaCode("044");
            person.SetOfficeNumber("123 45 67");

            Console.WriteLine("Name: {0} - Phone: {1}",
                person.GetName(), person.GetTelephoneNumber());

            // Delay.
            Console.ReadKey();
        }
    }
}
