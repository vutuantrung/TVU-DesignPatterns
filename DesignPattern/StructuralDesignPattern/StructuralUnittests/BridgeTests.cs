using Bridge.Enum;
using Bridge.TV;
using Bridge.TVRemote;
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
    }
}
