using System;
using System.Collections.Generic;
using System.Linq;

namespace ExchangeApp
{
    public class ExchangeCurrency
    {
        public decimal Exchange(string input)
        {
            decimal amount = 0;

            if(InputValidation.Validate(input))
            {
                var currencyInput1 = input.Substring(0, 3);
                var currencyInput2 = input.Substring(4, 3);
                var money = decimal.Parse(input.Substring(8, input.Length - 8));

                Console.WriteLine($"{currencyInput1} {currencyInput2} {money}");

                var currencyExchangeRates = new CurrencyExchangeRates();

                var currency1 = currencyExchangeRates.ExangeRates().FirstOrDefault(s => s.Name == currencyInput1);
                var currency2 = currencyExchangeRates.ExangeRates().FirstOrDefault(s => s.Name == currencyInput2);

                if(InputCurrencyValidation.ValidateCurrencyPair(currency1, currency2))
                {
                    amount = CalculateAmount.Calculate(currency1.Value, currency2.Value, money);
                }
            } 
            return amount;
        }
    }
}
