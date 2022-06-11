using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafePointOfSale
{
    public class CreditCardPayment
    {
        public ulong CreditCardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int CVV { get; set; }

        public CreditCardPayment()
        {

        }

        public CreditCardPayment(ulong creditCardNumber, string expirationDate, int expirationYear, int cVV)
        {
            CreditCardNumber = creditCardNumber;
            ExpirationDate = expirationDate;
            CVV = cVV;
        }

    }
}
