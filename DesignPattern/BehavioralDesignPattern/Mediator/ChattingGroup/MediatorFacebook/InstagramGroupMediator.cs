using Mediator.ChattingGroup.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.ChattingGroup.MediatorFacebook
{
    public class InstagramGroupMediator : IChattingGroupMediator
    {
        private List<UserAbstract> _listUser;

        public InstagramGroupMediator()
        {
            _listUser = new List<UserAbstract>();
        }

        public void RegisterUser( UserAbstract user )
        {
            user.RegisterInstagramMediator( this );
            _listUser.Add( user );
        }

        public void SendMessageToUser( string msg, UserAbstract sender )
        {
            foreach ( var user in _listUser )
            {
                if ( user != sender )
                {
                    user.ReceiveFromInstagram( msg );
                }
            }
        }
    }
}
