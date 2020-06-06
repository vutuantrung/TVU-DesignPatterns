using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Message.ImplementationClass
{
    public class SMSMessageSender : IMessageSender
    {
        public bool SendMessage( string message )
        {
            return true;
        }
    }
}
