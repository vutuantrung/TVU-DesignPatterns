using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Products
{
    public interface IProduct
    {
        void Process();

        ProductTypes GetValue();
    }
}
