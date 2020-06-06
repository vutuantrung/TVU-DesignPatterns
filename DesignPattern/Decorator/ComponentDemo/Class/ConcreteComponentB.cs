using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComponentDemo.Class
{
    public class ConcreteComponentB : Component
    {
        public override void Operation()
        {
            Console.WriteLine( "Operation from concrete component B" );
        }
    }
}
