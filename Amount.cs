using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeApp
{
    class Amount
    {
        public static decimal Change(decimal currency1, decimal currency2, decimal money)
        {
            decimal amount = currency1 / currency2 * money;
            return amount;
        }
    }
}
