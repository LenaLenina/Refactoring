using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Decompose Conditional (Декомпозиция условного оператора).

namespace DecomposeConditional
{
    static class Seasons
    {
        public static DateTime SUMMER_START { get { return new DateTime(DateTime.Now.Year, 6, 1); } }
        public static DateTime SUMMER_END { get { return new DateTime(DateTime.Now.Year, 8, 31); } }
    }

    static class DateExtensions
    {
        public static bool Before(this DateTime now, DateTime dateTimeToCompare)
        {
            if (now < dateTimeToCompare)
                return true;

            return false;
        }

        public static bool After(this DateTime now, DateTime dateTimeToCompare)
        {
            if (now > dateTimeToCompare)
                return true;

            return false;
        }
    }

    class SomeService
    {
        readonly double serviceBasePrice = 200;
        readonly double winterServiceCharge = 50;
        readonly double additionalCost = 25;
        readonly DateTime date = DateTime.Now;

        public SomeService(double basePrice, double winterCharge, double additionalCost, DateTime date)
        {
            serviceBasePrice = basePrice;
            winterServiceCharge = winterCharge;
            this.additionalCost = additionalCost;
            this.date = date;
        }

        public SomeService()
        { }

        public double GetCharge()
        {
            if (IsSummertime())
                return GetSummerCharge();
            else
                return GetWinterCharge();
        }

        private double GetWinterCharge()
        {
            return serviceBasePrice + additionalCost + winterServiceCharge;
        }

        private double GetSummerCharge()
        {
            return serviceBasePrice + additionalCost;
        }

        private bool IsSummertime()
        {
            return date.Before(Seasons.SUMMER_END) && date.After(Seasons.SUMMER_START);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SomeService service = new SomeService();

            double totalCharge = service.GetCharge();

            Console.WriteLine(totalCharge.ToString("C"));
        }
    }
}
