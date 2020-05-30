using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComponentDemo.Class
{
    public class ConcreteComponentA : Component
    {
        public override void Operation()
        {
            Console.WriteLine( "Operation from concrete component A" );
        }
    }
}
