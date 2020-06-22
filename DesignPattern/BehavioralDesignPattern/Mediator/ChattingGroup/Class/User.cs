using Mediator.ChattingGroup.MediatorFacebook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.ChattingGroup.Class
{
    public abstract class UserAbstract
    {
        protected IChattingGroupMediator _mediatorFacebook;
        protected IChattingGroupMediator _mediatorInstagram;

        protected string _name;

        public UserAbstract( string name )
        {
            _name = name;
        }

        public abstract void SendMessageToFacebook( string message );
        public abstract void ReceiveFromFacebook( string message );
        public abstract void SendMessageToInstagram( string message );
        public abstract void ReceiveFromInstagram( string message );

        public abstract void RegisterFacebookMediator( IChattingGroupMediator mediator );
        public abstract void RegisterInstagramMediator( IChattingGroupMediator mediator );
    }
}
