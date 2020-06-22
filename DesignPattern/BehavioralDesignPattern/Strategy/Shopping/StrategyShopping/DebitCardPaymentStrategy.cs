using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Shopping.StrategyShopping
{
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay( double amount )
        {
            Console.WriteLine( "Customer pays Rs " + amount + " using Debit Card" );
        }
    }
}
