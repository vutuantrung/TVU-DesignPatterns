using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Shopping.StrategyShopping
{
    public class CashCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay( double amount )
        {
            Console.WriteLine( "Customer pays Rs " + amount + " using Cash Card" );
        }
    }
}
