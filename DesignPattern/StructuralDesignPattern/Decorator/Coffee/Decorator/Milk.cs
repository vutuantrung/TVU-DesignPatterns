using Decorator.Coffee.Class;
using Decorator.Coffee.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Coffee.Decorator
{
    public class Milk : Condiment
    {
        public Milk( ICoffee coffee ) : base( coffee )
        {
        }

        public void AddCondiment()
        {
            _coffee.AddCondiment( CondimentType.Chocolate, 1.99 );
        }
    }
}
