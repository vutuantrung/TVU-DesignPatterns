using Mediator.ChattingGroup.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Mediator.ChattingGroup.MediatorFacebook
{
    public interface IChattingGroupMediator
    {
        void SendMessageToUser( string msg, UserAbstract sender );
        void RegisterUser( UserAbstract user );
    }
}
