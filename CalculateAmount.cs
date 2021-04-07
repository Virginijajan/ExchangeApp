namespace ExchangeApp
{
   public class CalculateAmount
    {
        public static decimal Calculate(decimal currency1, decimal currency2, decimal money)
        {
            decimal amount = currency1 / currency2 * money;
            return amount;
        }
    }
}
