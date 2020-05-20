using FactoryMethod.CreditCard.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.CreditCard.Card
{
    public class MoneyBack : ICreditCard
    {
        public int GetCreditLimit()
        {
            return 15000;
        }

        public int GetAnnualCharge()
        {
            return 500;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.MoneyBack;
        }
    }
}
