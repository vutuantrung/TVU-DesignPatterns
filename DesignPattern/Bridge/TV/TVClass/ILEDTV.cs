using Bridge.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.TV
{
    public interface ILEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel( int channelNumber );

        PowerTV GetPower();
        int GetChannel();
    }
}
