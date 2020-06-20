using Mediator.ChattingGroup.MediatorFacebook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.ChattingGroup.Class
{
    public class ConcreteUser : UserAbstract
    {
        public ConcreteUser( string name )
            : base( name )
        {
        }

        public override void ReceiveFromFacebook( string message )
        {
            Console.WriteLine( $@"{ _name } has just received message \""{ message }\"" from facebook group." );
        }

        public override void SendMessageToFacebook( string message )
        {
            if ( _mediatorFacebook == null ) throw new ArgumentNullException( nameof( _mediatorFacebook ), "This user does not participate in this facebook group." );

            _mediatorFacebook.SendMessageToUser( message, this );
        }

        public override void ReceiveFromInstagram( string message )
        {
            Console.WriteLine( $@"{ _name } has just received message \""{ message }\"" from instagram group." );
        }

        public override void SendMessageToInstagram( string message )
        {
            if ( _mediatorInstagram == null ) throw new ArgumentNullException( nameof( _mediatorInstagram ), "This user does not participate in this isntagram group." );

            _mediatorInstagram.SendMessageToUser( message, this );
        }

        public override void RegisterFacebookMediator( IChattingGroupMediator mediator )
        {
            _mediatorFacebook = mediator;
        }

        public override void RegisterInstagramMediator( IChattingGroupMediator mediator )
        {
            _mediatorInstagram = mediator;
        }
    }
}
