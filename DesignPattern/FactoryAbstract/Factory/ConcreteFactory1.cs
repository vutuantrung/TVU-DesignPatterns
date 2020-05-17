using FactoryAbstract.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Factory
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA() => new ConcreteProductA1();

        public IAbstractProductB CreateProductB() => new ConcreteProductB1();
    }
}
