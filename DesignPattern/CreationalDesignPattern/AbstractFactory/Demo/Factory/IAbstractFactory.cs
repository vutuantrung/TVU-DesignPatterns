using FactoryAbstract.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Factory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
