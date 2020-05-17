using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Products
{
    public class ConcreteProduct1 : IProduct
    {
        private ProductTypes _productType;

        public ConcreteProduct1()
        {
            Process();
        }

        public void Process()
        {
            _productType = ProductTypes.ValueProduct1;
        }

        public ProductTypes GetValue() => _productType;
    }
}
