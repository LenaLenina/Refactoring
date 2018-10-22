using System;

// Extract Class (Выделение класса). 164 стр.
// Выделение в отдельный класс функций относящихся к телефонным номерам.

namespace ExtractClass
{
    class Person
    {
        string name;
        TelephoneNumber officeTelephone;

        public Person(string name)
        {
            this.officeTelephone = new TelephoneNumber();
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public TelephoneNumber OfficeTelephone 
        { 
            get { return officeTelephone; } 
        }

        public string GetTelephoneNumber()
        {
            return officeTelephone.GetTelephoneNumber();
        }
    }

    class TelephoneNumber
    {
        string number;
        string areaCode;

        public string GetTelephoneNumber()
        {
            return "(" + areaCode + ")" + number;
        }

        public string AreaCode
        {
            get { return areaCode; }
            set { areaCode = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Person person = new Person("Martin");
            TelephoneNumber telephone = person.OfficeTelephone;
            telephone.AreaCode = "044";
            telephone.Number = "123 45 67";

            Console.WriteLine("Name: {0} - Phone: {1}",
                person.Name, person.GetTelephoneNumber());

            // Delay.
            Console.ReadKey();
        }
    }
}
