using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public interface IAbstractProductA
    {
        ProductTypes GetValue();

        int GetProductNumber();
    }
}
