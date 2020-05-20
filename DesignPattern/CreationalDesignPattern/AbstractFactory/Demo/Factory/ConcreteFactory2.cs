using FactoryAbstract.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Factory
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA() => new ConcreteProductA2();

        public IAbstractProductB CreateProductB() => new ConcreteProductB2();
    }
}
