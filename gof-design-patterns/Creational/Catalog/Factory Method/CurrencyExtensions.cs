using System.Globalization;

namespace Creational.Catalog.FactoryMethod
{
    public static class CurrencyExtensions
    {

        /// <summary>
        /// Get rate of the given currency to USD.
        /// <br />
        /// Получить курс валюты к USD.
        /// </summary>
        public static double GetCurrencyRate(Currency currency)
        {
            double rate = 0.0;

            var rates = GetRateList();

            rate = rates[currency.Code];

            return rate;
        }



        /// <summary>
        /// Get the lsit of currencies rales to USD (mock).
        /// <br />
        /// Получить список соотношений валют к USD (mock).
        /// </summary>
        private static Dictionary<string, double> GetRateList()
        {
            string filePath = @"..\..\..\Catalog\Factory Method\mock-currency-rates.txt";
            var list = File.ReadAllLines(filePath).ToList();

            return list.ToDictionary(str => str.Split(" ").First(), rate => Double.Parse(rate.Split(" ").Last(), CultureInfo.InvariantCulture));
        }

    }
}
