using Bridge.Message.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Message.ImplementationClass
{
    public class EmailMessageSender : IMessageSender
    {
        public bool SendMessage( string message )
        {
            return true;
        }
    }
}
