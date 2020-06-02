using Composite.Computer.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Computer.Class
{
    public class DeviceComposite : IDeviceComponent
    {
        private DeviceType _type;

        List<IDeviceComponent> _components;

        public DeviceComposite( DeviceType type )
        {
            _type = type;
            _components = new List<IDeviceComponent>();
        }

        public void AddComponent( IDeviceComponent component )
        {
            _components.Add( component );
        }

        public DeviceType GetDeviceType()
        {
            return _type;
        }

        public int GetPrice()
        {
            int totalPrice = 0;

            foreach ( IDeviceComponent component in _components )
            {
                totalPrice += component.GetPrice();
            }

            return totalPrice;
        }
    }
}
