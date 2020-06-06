using Bridge.Message.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Message.ImplementationClass
{
    public interface IMessageSender
    {
        bool SendMessage( string message );
    }
}
