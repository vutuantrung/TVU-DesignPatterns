using FactoryDesign.Card;
using FactoryDesign.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign.Factory
{
    public class CreditCardFactory
    {
        public static CreditCard GetCreditCard( CreditCardType cardType )
        {
            if ( cardType == CreditCardType.MoneyBack ) return new MoneyBack();
            if ( cardType == CreditCardType.Platium ) return new Platium();
            if ( cardType == CreditCardType.Titanium ) return new Titanium();

            return null;
        }
    }
}
