using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string GetSerie()
        {
            return "Serie B1_78364";
        }

        public ProductsType GetValue() => ProductsType.ProductB1;
    }
}
