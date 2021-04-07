using System.Collections.Generic;

namespace ExchangeApp
{
    public class CurrencyExchangeRates
    {
        public List<Currency> ExangeRates() {

            List<Currency> exchangeRates = new List<Currency>
            {
                new Currency{ Name = "EUR", Value = 743.94M },
                new Currency { Name = "USD", Value = 663.11M },
                new Currency { Name = "GBP", Value = 852.85M },
                new Currency { Name = "SEK", Value = 76.10M },
                new Currency { Name = "NOK", Value = 78.40M },
                new Currency { Name = "CHF", Value = 683.58M },
                new Currency { Name = "JPY", Value = 5.9740M },
                new Currency { Name = "DKK", Value = 100.00M }
            };
            return exchangeRates;
        }
    }
}
