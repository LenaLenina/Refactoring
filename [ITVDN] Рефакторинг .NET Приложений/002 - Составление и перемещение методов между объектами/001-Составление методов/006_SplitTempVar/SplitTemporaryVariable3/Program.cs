using System;

// Split Temporary Variable (Расщепление временной переменной). 142 стр.

namespace SplitTemporaryVariable
{
    struct Roots
    {
        public double firstRoot;
        public double secondRoot;

        public Roots(double firstRoot, double secondRoot)
        {
            this.firstRoot = firstRoot;
            this.secondRoot = secondRoot;
        }

        public override string ToString()
        {
            return string.Format("1-str root: {0}\n2-nd root: {1}", firstRoot, secondRoot);
        }
    }

    class QuadraticEquationCalculator
    {
        double a, b, c;

        public QuadraticEquationCalculator(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Roots SolveTheEquation()
        {
            if (GetDiscriminant() < 0)
                throw new Exception("There are no roots on the set of real numbers");

            return FindRoots();
        }

        private Roots FindRoots()
        {
            return new Roots(GetFirstRoot(), GetSecondRoot());
        }

        private double GetFirstRoot()
        {
            return (-b + Math.Sqrt(GetDiscriminant())) / (2 * a);
        }

        private double GetSecondRoot()
        {
            return (-b - Math.Sqrt(GetDiscriminant())) / (2 * a);
        }

        public double GetDiscriminant()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine(new QuadraticEquationCalculator(5, 5, -16).SolveTheEquation());
            // Delay.
            Console.ReadKey();
        }
    }
}
