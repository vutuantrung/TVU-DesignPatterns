using FactoryDesign.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Card
{
    class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 35000;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.Titanium;
        }

        public int GetCreditLimit()
        {
            return 2000;
        }
    }
}
