using System;
using System.Text;

// Introduce Null Object (Введение объекта Null).

namespace IntroduceNullObject
{
    class Customer
    {
        string name;
        string telephoneNo;
        Address address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string TelephoneNo
        {
            get { return telephoneNo; }
            set { telephoneNo = value; }
        }

        internal Address Address
        {
            get
            {
                if (address != null)
                {
                    return address;
                }
                else
                {
                    return new NullAddress();
                }
            }
            set { address = value; }
        }

        public Customer(string name, string telephoneNo)
        {
            this.name = name;
            this.telephoneNo = telephoneNo;
        }

        public string GetFullInfo()
        {
            StringBuilder strBuilder = new StringBuilder();

            strBuilder
                .Append("Name: " + name)
                .AppendLine("Telephone Number: " + telephoneNo);

            strBuilder.AppendLine(GetAddressInfo());

            return strBuilder.ToString();
        }

        public string GetAddressInfo()
        {
            StringBuilder strBuilder = new StringBuilder();

            string country, city;

            city = Address.City;
            country = Address.Country;

            strBuilder
                .AppendLine("Country: " + country)
                .AppendLine("City: " + city);

            return strBuilder.ToString();
        }
    }

    class Address
    {
        string country, city;

        public virtual string City
        { get { return city; } }

        public virtual string Country
        { get { return country; } }

        public Address(string country, string city)
        {
            this.country = country;
            this.city = city;
        }

        protected Address()
        {
        }

        public virtual bool IsNull()
        {
            return false;
        }
    }

    class NullAddress : Address
    {
        public override bool IsNull()
        {
            return true;
        }

        public override string City
        {
            get
            { return "Unknown"; }
        }

        public override string Country
        {
            get
            { return "Unknown"; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer tom = new Customer("Tom", "(052)1457487");

            tom.Address = new Address("Ukraine", "Kyiv");

            Console.WriteLine(tom.GetFullInfo());
        }
    }
}
