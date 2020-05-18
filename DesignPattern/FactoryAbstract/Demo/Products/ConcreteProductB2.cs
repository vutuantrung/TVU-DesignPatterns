﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        public string GetSerie()
        {
            return "Serie B2_57204";
        }

        public ProductTypes GetValue() => ProductTypes.ProductB2;
    }
}