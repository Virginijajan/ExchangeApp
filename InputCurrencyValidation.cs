using System;


namespace ExchangeApp
{
    public class InputCurrencyValidation
    {
        public static bool ValidateCurrencyPair(Currency currency1, Currency currency2)
        {
            if (currency1 == null || currency2 == null)
            {
                Console.WriteLine("Unknown currency!");
                return false;
            }
            return true;
        }
    }
}
