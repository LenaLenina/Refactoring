using System;
using System.Collections.Generic;

namespace Refactoring
{
    /// <summary>
    /// Класс, представляющий клиента магазина.
    /// </summary>
    class Customer
    {
        // Поля

        private string name = null;
        private List<Rental> rentals = new List<Rental>();

        // Методы

        public Customer(string name)
        {
            this.name = name;
        }
                
        /// <summary>
        /// Метод создающий отчет.
        /// </summary>
        /// <returns></returns>
        public string Statement()
        {
            string result = string.Format("Учет аренды для {0}: ", name);

            foreach (Rental rental in rentals)
            {
                // Показать результаты для этой аренды 
                result += "\t" + rental.Movie.Title + "\t" + rental.GetCharge() + "\n";
            }

            // Добавить нижний колонтитул
            result += "Сумма задолженности составляет " + GetTotalCharge() + "\n";
            result += "Вы заработали " + GetTotalFrequentRenterPoints() + " очков за активность";
            return result;
        }
        
        /// <summary>
        /// Метод создающий HTML - отчет.
        /// </summary>
        /// <returns></returns>
        public string HtmlStatement()
        {
            string result = "<H1>Операции аренды для <EM>" + Name + "</EM></H1><P>\n";
             
            foreach (Rental rental in rentals)
            {
                // Показать результаты для этой аренды 
                result += rental.Movie.Title + rental.GetCharge() + "<BR>\n";
            }

            // Добавить нижний колонтитул
            result += "<P>Сумма задолженности составляет <EM>" + GetTotalCharge() + "</EM><P>\n";
            result += "Вы заработали <EM>" + GetTotalFrequentRenterPoints() + "<EM> очков за активность<P>";
            return result;
        }

        private double GetTotalCharge()
        {
            double result = 0;

            foreach (Rental rental in rentals)
            {
                result += rental.GetCharge();
            }

            return result;
        }

        private int GetTotalFrequentRenterPoints()
        {
            int result = 0;

            foreach (Rental rental in rentals)
            {
                result += rental.GetFrequentRenterPoints();
            }

            return result;
        }

        // Свойства

        public Rental Rentals
        {
            set { this.rentals.Add(value); }
        }

        public string Name
        {
            get { return this.name; }
        }
    }
}
