using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Инкапсуляция коллекций

namespace ConsoleApplication14
{
    class MyClass
    {
        List<string> collection = new List<string>();

        public IList<string> GetCollection()
        {
            return collection.AsReadOnly();
        }

        public void AddRange(List<string> collection)
        {
            foreach (var element in collection)
            {
                collection.Add(element);
            }
        }

        public void AddElement(string element)
        {
            if (element != "Fool")
                collection.Add(element);
        }

        public void RemoveElement(string element)
        {
            collection.Remove(element);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass inst = new MyClass();

            inst.AddElement("First element");
            inst.AddElement("SecondElement");

            inst.AddRange(new List<string>());
        }
    }
}
