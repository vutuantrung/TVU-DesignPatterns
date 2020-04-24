using FactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Class
{
    public class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
