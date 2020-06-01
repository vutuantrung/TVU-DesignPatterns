using Bridge.Demo.AbstractionClass;
using Bridge.Demo.ImplementationClass;
using Bridge.Enum;
using Bridge.Message.AbstractionClass;
using Bridge.Message.Enum;
using Bridge.Message.ImplementationClass;
using Bridge.TV;
using Bridge.TVRemote;
using Decorator.ComponentDemo.Class;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralUnittests
{
    [TestFixture]
    class BridgeTests
    {
        [Test]
        public void Test_tv()
        {
            {
                ILEDTV samsungTV = new SamsungLEDTV();

                SamsungRemoteControl samsungRemote = new SamsungRemoteControl( samsungTV );
                samsungRemote.SwitchOn();

                Assert.That( samsungTV.GetPower() == PowerTV.On );

                samsungRemote.SetChannel( 56 );

                Assert.That( samsungTV.GetChannel() == 56 );

                samsungRemote.SwitchOff();

                Assert.That( samsungTV.GetPower() == PowerTV.Off );
            }

            {
                ILEDTV sonyTV = new SonyLEDTV();

                SamsungRemoteControl samsungRemote = new SamsungRemoteControl( sonyTV );
                samsungRemote.SwitchOn();

                Assert.That( sonyTV.GetPower() != PowerTV.On );

                samsungRemote.SetChannel( 56 );

                Assert.That( sonyTV.GetChannel() != 56 );

            }
        }

        [Test]
        public void Test_demo()
        {
            {
                IImplementation implementationA = new ConcreteImplementationA();

                Abstraction abstraction = new Abstraction( implementationA );

                abstraction.Operation();

                Assert.That( abstraction.GetData() == "ImplementationA" );
            }

            {
                IImplementation implementationA = new ConcreteImplementationA();
                IImplementation implementationB = new ConcreteImplementationB();

                Abstraction abstraction = new Abstraction( implementationB );
                abstraction.Operation();

                Assert.That( abstraction.GetData() == "ImplementationB" );


                abstraction = new Abstraction( implementationA );
                abstraction.Operation();

                Assert.That( abstraction.GetData() == "ImplementationA" );
            }
        }

        [Test]
        public void Test_message()
        {
            string longM = "this is a very very very long message...";
            string shortM = "short SMS";

            IMessageSender smsMessageSender = new SMSMessageSender();
            IMessageSender emailMessageSender = new EmailMessageSender();

            // Short message
            ShortMessage shortMessage = new ShortMessage( smsMessageSender );
            {
                shortMessage.SendMessage( shortM );
                Assert.That( shortMessage.GetMessageSentCount(), Is.EqualTo( 1 ) );

                shortMessage.SendMessage( shortM );
                shortMessage.SendMessage( shortM );
                shortMessage.SendMessage( shortM );
                shortMessage.SendMessage( shortM );

                Assert.That( shortMessage.GetMessageSentCount(), Is.EqualTo( 5 ) );

                Assert.That( shortMessage.GetSenderType(), Is.EqualTo( SenderType.SMS ) );
                Assert.That( shortMessage.GetSenderType(), !Is.EqualTo( SenderType.Email ) );
            }

            // Null message
            {
                var ex = Assert.Throws<ArgumentNullException>( () => { shortMessage.SendMessage( string.Empty ); } );
                Assert.That( ex.Message, Is.EqualTo( "Invalid message. (Parameter 'message')" ) );
            }

            // Long message
            {
                var ex = Assert.Throws<ArgumentException>( () => { shortMessage.SendMessage( longM ); } );
                Assert.That( ex.Message, Is.EqualTo( "Invalid message: message is too long. (Parameter 'message')" ) );
            }

            // Long message
            LongMessage longMessage = new LongMessage( emailMessageSender );
            {
                longMessage.SendMessage( longM );
                Assert.That( longMessage.GetMessageSentCount(), Is.EqualTo( 1 ) );

                longMessage.SendMessage( longM );
                longMessage.SendMessage( longM );
                Assert.That( longMessage.GetMessageSentCount(), Is.EqualTo( 3 ) );

                Assert.That( longMessage.GetSenderType(), !Is.EqualTo( SenderType.SMS ) );
                Assert.That( longMessage.GetSenderType(), Is.EqualTo( SenderType.Email ) );
            }

            // Null message
            {
                var ex = Assert.Throws<ArgumentNullException>( () => { longMessage.SendMessage( string.Empty ); } );
                Assert.That( ex.Message, Is.EqualTo( "Invalid message. (Parameter 'message')" ) );
            }

            // Long message
            {
                var ex = Assert.Throws<ArgumentException>( () => { longMessage.SendMessage( shortM ); } );
                Assert.That( ex.Message, Is.EqualTo( "Invalid message: message is too short. (Parameter 'message')" ) );
            }
        }
    }
}
