using Mediator.Demo.MediatorDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.Demo.Class
{
    public class ConcreteComponentA : BaseComponent
    {
        public ConcreteComponentA( IMediator mediator = null )
            : base( mediator )
        {
        }

        public void ExecutingA()
        {
            if ( _mediator == null ) throw new ArgumentNullException( nameof( _mediator ) );
            _mediator.Notify( this, "A do A" );
        }

        public void ExecutingB()
        {
            if ( _mediator == null ) throw new ArgumentNullException( nameof( _mediator ) );
            _mediator.Notify( this, "A do B" );
        }
    }
}
