using Decorator.ComponentDemo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComponentDemo.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA( Component component ) : base( component )
        {
        }

        public override void Operation()
        {
            _component.Operation();
            AddFeature();
        }

        public void AddFeature()
        {
            Console.WriteLine( "Feature added from decorator A" );
        }
    }
}
