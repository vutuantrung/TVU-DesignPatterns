using FactoryMethod.CreditCard.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.CreditCard.Factory
{
    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            return this.MakeProduct();
        }
    }
}
