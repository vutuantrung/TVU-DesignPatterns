using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Class
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string Operation()
        {
            var product = FactoryMethod();

            return $"Operation return { product.ToString() }";
        }
    }
}
