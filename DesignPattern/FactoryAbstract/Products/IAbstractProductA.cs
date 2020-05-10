using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAbstract.Products
{
    public interface IAbstractProductA
    {
        ProductEnum GetValue();

        int GetProductNumber();
    }
}
