using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Shopping.StrategyShopping
{
    public interface IPaymentStrategy
    {
        void Pay( double amount );
    }
}
