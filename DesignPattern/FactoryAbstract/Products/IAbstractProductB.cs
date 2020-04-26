using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public interface IAbstractProductB
    {
        ProductsType GetValue();

        string GetSerie();
    }
}
