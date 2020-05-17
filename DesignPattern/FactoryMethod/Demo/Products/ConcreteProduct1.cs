using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Products
{
    public class ConcreteProduct1 : IProduct
    {
        private ProductEnum _productType;

        public ConcreteProduct1()
        {
            Process();
        }

        public void Process()
        {
            _productType = ProductEnum.ValueProduct1;
        }

        public ProductEnum GetValue() => _productType;
    }
}
