using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public interface IAbstractProductB
    {
        ProductEnum GetValue();

        string GetSerie();
    }
}
