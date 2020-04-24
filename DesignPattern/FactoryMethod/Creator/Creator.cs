using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Class
{
    abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string Operation()
        {
            var product = FactoryMethod();

            return $"Operation return { product.ToString() }";
        }
    }
}
