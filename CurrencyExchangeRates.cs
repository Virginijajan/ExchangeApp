using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp
{
    class CurrencyExchangeRates
    {
        public List<Currency> ExangeRates() {

            List<Currency> exchangeRates = new List<Currency>();

            exchangeRates.Add(new Currency(){ Name = "EUR", Value = 743.94M });
            exchangeRates.Add(new Currency(){ Name = "USD", Value = 663.11M });
            exchangeRates.Add(new Currency(){ Name = "GBP", Value = 852.85M });
            exchangeRates.Add(new Currency(){ Name = "SEK", Value = 76.10M });
            exchangeRates.Add(new Currency(){ Name = "NOK", Value = 78.40M });
            exchangeRates.Add(new Currency(){ Name = "CHF", Value = 683.58M });
            exchangeRates.Add(new Currency(){ Name = "JPY", Value = 5.9740M });
            exchangeRates.Add(new Currency(){ Name = "DKK", Value = 100.00M });

            return exchangeRates;
        }
    }
}
