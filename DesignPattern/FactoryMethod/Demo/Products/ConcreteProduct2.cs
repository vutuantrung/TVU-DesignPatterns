using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Products
{
    public class ConcreteProduct2 : IProduct
    {
        private ProductEnum _productType;

        public ConcreteProduct2()
        {
            Process();
        }

        public void Process()
        {
            _productType = ProductEnum.ValueProduct2;
        }

        public ProductEnum GetValue() => _productType;
    }
}
