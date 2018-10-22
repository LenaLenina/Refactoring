using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Replace Subclass With Fields (Замена подкласса полями).

namespace SubclassToFields
{
    class Person
    {
        readonly bool isMale;

        public bool IsMale()
        {
            return isMale;
        }

        public static Person CreateMale()
        {
            return new Person(true);
        }

        public static Person CreateFemale()
        {
            return new Person(false);
        }

        protected Person(bool isMale)
        {
            this.isMale = isMale;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
