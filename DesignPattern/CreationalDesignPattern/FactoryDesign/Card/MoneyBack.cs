using FactoryDesign.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Card
{
    class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 20000;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.MoneyBack;
        }

        public int GetCreditLimit()
        {
            return 1000;
        }
    }
}
