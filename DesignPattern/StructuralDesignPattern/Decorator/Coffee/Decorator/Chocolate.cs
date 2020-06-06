using Decorator.Coffee.Class;
using Decorator.Coffee.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Coffee.Decorator
{
    public class Chocolate : Condiment
    {
        public Chocolate( ICoffee coffee ) : base( coffee )
        {
        }

        public void AddCondiment()
        {
            _coffee.AddCondiment( CondimentType.Chocolate, 0.99 );
        }
    }
}
