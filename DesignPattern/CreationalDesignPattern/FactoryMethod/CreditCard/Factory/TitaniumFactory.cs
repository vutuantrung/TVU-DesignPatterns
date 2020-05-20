using FactoryMethod.CreditCard.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.CreditCard.Factory
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new Titanium();
        }
    }
}
