using Mediator.Demo.MediatorDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Demo.Class
{
    public class ConcreteComponentB : BaseComponent
    {
        public ConcreteComponentB( IMediator mediator = null )
            : base( mediator )
        {
        }

        public void ExecutingA()
        {
            if ( _mediator == null ) throw new ArgumentNullException( nameof( _mediator ) );
            _mediator.Notify( this, "B do A" );
        }

        public void ExecutingB()
        {
            if ( _mediator == null ) throw new ArgumentNullException( nameof( _mediator ) );
            _mediator.Notify( this, "B do B" );
        }
    }
}
