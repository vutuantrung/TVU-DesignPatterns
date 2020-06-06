using Bridge.Message.Enum;
using Bridge.Message.ImplementationClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Message.AbstractionClass
{
    public abstract class Message
    {
        protected IMessageSender messageSender;
        public abstract void SendMessage( string message );
        public abstract int GetMessageSentCount();
        public abstract SenderType GetSenderType();
    }
}
