using Mediator.Demo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Demo.MediatorDemo
{
    public class ConcreteMediator : IMediator
    {
        private ConcreteComponentA _componentA;

        private ConcreteComponentB _componentB;

        public ConcreteMediator( ConcreteComponentA componentA, ConcreteComponentB componentB )
        {
            _componentA = componentA; _componentA.SetMediator( this );
            _componentB = componentB; _componentB.SetMediator( this );
        }

        public void Notify( object sender, string ev )
        {
            if ( sender is ConcreteComponentA )
            {
                _componentB.ReceiveMessage( ev );
            }
            else
            {
                _componentA.ReceiveMessage( ev );
            }

        }
    }
}
