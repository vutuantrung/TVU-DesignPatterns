using FactoryMethod.CreditCard.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.CreditCard.Factory
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new MoneyBack();
        }
    }
}
