using System;

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
            var amount = new ExchangeCurrency().Exchange(input);
            Console.WriteLine($"{amount}");
        }
    }
}
