using Composite.Computer;
using Composite.Computer.Class;
using Composite.Computer.Enum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralUnittests
{
    [TestFixture]
    class CompositeTests
    {
        [Test]
        public void Test_computer()
        {
            IDeviceComponent hardDisk = new DeviceLeaf( DeviceType.HardDisk, 2000 );
            IDeviceComponent ram = new DeviceLeaf( DeviceType.RAM, 3000 );
            IDeviceComponent cpu = new DeviceLeaf( DeviceType.CPU, 5000 );
            IDeviceComponent mouse = new DeviceLeaf( DeviceType.CPU, 1500 );
            IDeviceComponent keyboard = new DeviceLeaf( DeviceType.CPU, 2000 );

            DeviceComposite motherBoard = new DeviceComposite( DeviceType.MotherBoard );
            DeviceComposite cabinet = new DeviceComposite( DeviceType.Cabinet );
            DeviceComposite peripherals = new DeviceComposite( DeviceType.Peripherals );
            DeviceComposite computer = new DeviceComposite( DeviceType.Computer );

            motherBoard.AddComponent( cpu );
            motherBoard.AddComponent( ram );

            cabinet.AddComponent( motherBoard );
            cabinet.AddComponent( hardDisk );

            peripherals.AddComponent( mouse );
            peripherals.AddComponent( keyboard );

            computer.AddComponent( cabinet );
            computer.AddComponent( peripherals );

            Assert.That( computer.GetPrice(), Is.EqualTo( 13500 ) );
        }
    }
}
