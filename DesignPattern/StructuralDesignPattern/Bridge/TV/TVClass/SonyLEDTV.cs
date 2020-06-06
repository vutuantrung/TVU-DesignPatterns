using Bridge.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.TV
{
    public class SonyLEDTV : ILEDTV
    {
        private PowerTV _power;

        private int _channel;

        public SonyLEDTV()
        {
            _power = PowerTV.Off;
            _channel = 0;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public PowerTV GetPower()
        {
            return _power;
        }

        public void SetChannel( int channelNumber )
        {
            _channel = channelNumber;
        }

        public void SwitchOff()
        {
            _power = PowerTV.Off;
        }

        public void SwitchOn()
        {
            _power = PowerTV.On;
        }
    }
}
