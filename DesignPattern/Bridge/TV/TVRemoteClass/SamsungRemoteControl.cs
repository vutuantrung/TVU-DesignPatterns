using Bridge.TV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.TVRemote
{
    public class SamsungRemoteControl : RemoteControl
    {
        public SamsungRemoteControl( ILEDTV ledTV ) : base( ledTV )
        {
        }

        public override void SetChannel( int channelNumber )
        {
            if ( _ledTV is SamsungLEDTV ) _ledTV.SetChannel( channelNumber );
        }

        public override void SwitchOff()
        {
            if ( _ledTV is SamsungLEDTV ) _ledTV.SwitchOff();
        }

        public override void SwitchOn()
        {
            if ( _ledTV is SamsungLEDTV ) _ledTV.SwitchOn();
        }
    }
}
