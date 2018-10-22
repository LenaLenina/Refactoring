using System;

// Extract Class (Выделение класса). 163 стр.
// Выделение в отдельный класс функций относящихся к телефонным номерам.

namespace ExtractClass
{
    class Person
    {
        string name;
        string officeNumber;
        TelephoneNumber officeTelephone;

        public Person(string name)
        {
            this.officeTelephone = new TelephoneNumber();
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public string GetTelephoneNumber()
        {
            return "(" + GetOfficeAreaCode() + ")" + officeNumber;
        }

        public string GetOfficeAreaCode()
        {
            return officeTelephone.GetAreaCode();
        }

        public void SetOfficeAreaCode(string arg)
        {
            officeTelephone.SetAreaCode(arg);
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

    class TelephoneNumber
    {
        string areaCode;

        public string GetAreaCode()
        {
            return areaCode;
        }

        public void SetAreaCode(string arg)
        {
            areaCode = arg;
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
