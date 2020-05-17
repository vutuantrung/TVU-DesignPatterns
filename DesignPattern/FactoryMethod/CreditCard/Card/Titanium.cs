using FactoryMethod.CreditCard.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.CreditCard.Card
{
    class Titanium : ICreditCard
    {
        public int GetCreditLimit()
        {
            return 25000;
        }

        public int GetAnnualCharge()
        {
            return 1500;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.Titanium;
        }
    }
}
