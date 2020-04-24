using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Class
{
    class ConcreteCreator1 : Creator
    {
        IProduct _product;

        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }

        public ProductTypes GetValueProduct => _product.GetValue();
    }
}
