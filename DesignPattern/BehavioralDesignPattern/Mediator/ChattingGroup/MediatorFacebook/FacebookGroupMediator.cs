using Mediator.ChattingGroup.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.ChattingGroup.MediatorFacebook
{
    public class FacebookGroupMediator : IChattingGroupMediator
    {
        private List<UserAbstract> _listUser;

        public FacebookGroupMediator()
        {
            _listUser = new List<UserAbstract>();
        }

        public void RegisterUser( UserAbstract user )
        {
            user.RegisterFacebookMediator( this );
            _listUser.Add( user );
        }

        public void SendMessageToUser( string msg, UserAbstract sender )
        {
            foreach ( var user in _listUser )
            {
                if ( user != sender )
                {
                    user.ReceiveFromFacebook( msg );
                }
            }
        }
    }
}
