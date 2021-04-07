using System;
using System.Linq;

namespace ExchangeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exchange");
            Console.WriteLine("Usage: <currency pair><amount to exchange>");
            Console.Write("Exchange ");

            var input=Console.ReadLine();

            
            if (input.IndexOf("/") != 3 || input.IndexOf(" ")!=7)
            {
                Console.WriteLine("Input error!");
            }

            else if (!decimal.TryParse(input.Substring(8, input.Length - 8), out var money))
            {
                Console.WriteLine("Money input error!");
            }
            else
            {
                var currencyInput1 = input.Substring(0, 3);
                var currencyInput2 = input.Substring(4, 3);

                Console.WriteLine($"{currencyInput1} {currencyInput2} {money}");

                var currencyExchangeRates = new CurrencyExchangeRates();

                var currency1 = currencyExchangeRates.ExangeRates().FirstOrDefault(s => s.Name == currencyInput1);

                var currency2 = currencyExchangeRates.ExangeRates().FirstOrDefault(s => s.Name == currencyInput2);
                if (currency1 == null || currency2 == null)
                {
                    Console.WriteLine("Unknown currency!");
                }
                else
                {
                    var amount = Amount.Change(currency1.Value, currency2.Value, money);

                    Console.WriteLine($"{amount}");
                }

            }
        }
    }
}
