using Composite.Computer.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Computer
{
    public class DeviceLeaf : IDeviceComponent
    {
        private int _price;
        private DeviceType _type;

        public DeviceLeaf( DeviceType type, int price )
        {
            _type = type;
            _price = price;
        }

        public DeviceType GetDeviceType()
        {
            return _type;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
