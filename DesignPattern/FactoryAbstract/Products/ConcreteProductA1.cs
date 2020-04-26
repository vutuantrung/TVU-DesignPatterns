﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public class ConcreteProductA1 : IAbstractProductA
    {
        public int GetProductNumber()
        {
            return 5;
        }

        public ProductsType GetValue() => ProductsType.ProductA1;
    }
}
