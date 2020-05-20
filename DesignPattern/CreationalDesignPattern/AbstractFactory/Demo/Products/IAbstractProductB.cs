using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public interface IAbstractProductB
    {
        ProductTypes GetValue();

        string GetSerie();
    }
}
