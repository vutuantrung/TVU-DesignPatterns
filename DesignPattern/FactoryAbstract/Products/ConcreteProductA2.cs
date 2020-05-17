using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public int GetProductNumber()
        {
            return 104;
        }

        public ProductTypes GetValue() => ProductTypes.ProductA2;
    }
}
