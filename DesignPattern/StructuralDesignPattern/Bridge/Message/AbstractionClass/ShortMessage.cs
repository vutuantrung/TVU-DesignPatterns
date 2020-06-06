using Bridge.Message.Enum;
using Bridge.Message.ImplementationClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Message.AbstractionClass
{
    public class ShortMessage : Message
    {
        int _messageSentCount;
        SenderType _senderType;
        IMessageSender _messageSender;

        public ShortMessage( IMessageSender messageSender )
        {
            _messageSender = messageSender;
            _messageSentCount = 0;

            if ( messageSender is EmailMessageSender )
            {
                _senderType = SenderType.Email;
            }
            else if ( messageSender is SMSMessageSender )
            {
                _senderType = SenderType.SMS;
            }
        }

        public override int GetMessageSentCount()
        {
            return _messageSentCount;
        }

        public override SenderType GetSenderType()
        {
            return _senderType;
        }

        public override void SendMessage( string message )
        {
            if ( string.IsNullOrEmpty( message ) ) throw new ArgumentNullException( nameof( message ), "Invalid message." );
            if ( message.Length > 10 ) throw new ArgumentException( "Invalid message: message is too long.", nameof( message ) );

            bool success = _messageSender.SendMessage( message );

            if ( success ) _messageSentCount++;
        }
    }
}
