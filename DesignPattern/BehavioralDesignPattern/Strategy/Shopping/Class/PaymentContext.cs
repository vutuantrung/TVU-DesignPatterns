using Strategy.Shopping.StrategyShopping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Shopping.Class
{
    public class PaymentContext
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentContext( IPaymentStrategy paymentStrategy )
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy( IPaymentStrategy paymentStrategy )
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Pay( double amount )
        {
            _paymentStrategy.Pay( amount );
        }
    }
}
