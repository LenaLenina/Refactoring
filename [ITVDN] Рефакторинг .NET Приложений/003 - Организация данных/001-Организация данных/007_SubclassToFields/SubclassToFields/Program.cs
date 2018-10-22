using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Replace Subclass With Fields (Замена подкласса полями).

namespace SubclassToFields
{
    abstract class Person
    {
        public abstract bool IsMale();
    }

    class Male : Person
    {
        public override bool IsMale()
        {
            return true;
        } 
    }

    class Female : Person
    {
        public override bool IsMale()
        {
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
