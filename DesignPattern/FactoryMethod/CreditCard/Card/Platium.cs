using FactoryMethod.CreditCard.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.CreditCard.Card
{
    public class Platium : ICreditCard
    {
        public int GetCreditLimit()
        {
            return 35000;
        }

        public int GetAnnualCharge()
        {
            return 2000;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.Platium;
        }
    }
}
