using Decorator.ComponentDemo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ComponentDemo.Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator( Component component )
        {
            _component = component;
        }

        public void SetComponent( Component component )
        {
            _component = component;
        }

        public override void Operation()
        {
            if ( _component != null )
            {
                _component.Operation();
            }

            throw new ArgumentNullException( nameof( _component ) );
        }
    }
}
