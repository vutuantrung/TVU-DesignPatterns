using Mediator.Demo.MediatorDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Demo.Class
{
    public abstract class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent( IMediator mediator = null )
        {
            _mediator = mediator;
        }

        public void SetMediator( IMediator mediator )
        {
            _mediator = mediator;
        }

        public void ReceiveMessage( string message )
        {
            Console.WriteLine( message );
        }
    }
}
