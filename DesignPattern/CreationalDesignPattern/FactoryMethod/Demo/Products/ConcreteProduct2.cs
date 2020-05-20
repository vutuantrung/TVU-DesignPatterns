using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Products
{
    public class ConcreteProduct2 : IProduct
    {
        private ProductTypes _productType;

        public ConcreteProduct2()
        {
            Process();
        }

        public void Process()
        {
            _productType = ProductTypes.ValueProduct2;
        }

        public ProductTypes GetValue() => _productType;
    }
}
