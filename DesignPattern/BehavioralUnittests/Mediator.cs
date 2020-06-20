using Mediator.ChattingGroup.Class;
using Mediator.ChattingGroup.MediatorFacebook;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Mediator
    {
        [Test]
        public void Test_Facebook_chat()
        {
            IChattingGroupMediator fbMediator = new FacebookGroupMediator();
            IChattingGroupMediator instMediator = new InstagramGroupMediator();

            var userA = new ConcreteUser( "User_name_A" );
            var userB = new ConcreteUser( "User_name_B" );
            var userC = new ConcreteUser( "User_name_C" );
            var userD = new ConcreteUser( "User_name_D" );
            var userE = new ConcreteUser( "User_name_E" );
            var userF = new ConcreteUser( "User_name_F" );
            var userG = new ConcreteUser( "User_name_G" );

            fbMediator.RegisterUser( userA );
            fbMediator.RegisterUser( userC );
            fbMediator.RegisterUser( userE );
            fbMediator.RegisterUser( userF );

            instMediator.RegisterUser( userA );
            instMediator.RegisterUser( userB );
            instMediator.RegisterUser( userC );
            instMediator.RegisterUser( userD );
            instMediator.RegisterUser( userG );

            userA.SendMessageToFacebook( "This is msg from userA" );
            userE.SendMessageToFacebook( "This is msg from userE" );

            Assert.Throws<ArgumentNullException>( () => { userD.SendMessageToFacebook( "This is msg from userA" ); }, "This user does not participate in this facebook group.  (Parameter '_mediatorFacebook')" );

            userA.SendMessageToInstagram( "This is msg from userA" );
            userB.SendMessageToInstagram( "This is msg from userB" );

            Assert.Throws<ArgumentNullException>( () => { userE.SendMessageToInstagram( "This is msg from userA" ); }, "This user does not participate in this instagram group.  (Parameter '_mediatorInstagram')" );
        }

    }
}
