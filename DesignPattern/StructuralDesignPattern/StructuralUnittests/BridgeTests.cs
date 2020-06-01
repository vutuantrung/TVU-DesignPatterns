using Bridge.Demo.AbstractionClass;
using Bridge.Demo.ImplementationClass;
using Bridge.Enum;
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
    }
}
