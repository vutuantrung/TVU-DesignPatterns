using FactoryDesign.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Card
{
    class Platium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 30000;
        }

        public CreditCardType GetCardType()
        {
            return CreditCardType.Platium;
        }

        public int GetCreditLimit()
        {
            return 1500;
        }
    }
}
