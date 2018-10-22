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

        public List<string> GetCollection()
        {
            return collection;
        }

        public void SetCollection(List<string> collection)
        {
            this.collection = collection;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass inst = new MyClass();

            string newElement = "First element";

            if (newElement != "Fool")
                inst.GetCollection().Add(newElement);

            newElement = "SecondElement";

            if (newElement != "Fool")
                inst.GetCollection().Add(newElement);

            inst.SetCollection(new List<string>());
        }
    }
}
