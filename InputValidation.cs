using System;


namespace ExchangeApp
{
    public class InputValidation
        {
            public static bool Validate(string input) { 

            if (input.IndexOf("/") != 3 || input.IndexOf(" ") != 7)
            {
                Console.WriteLine("Input error!");
                return false;
            }           
            else if (!decimal.TryParse(input.Substring(8, input.Length - 8), out decimal money))
            {
                Console.WriteLine("Money input error!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
