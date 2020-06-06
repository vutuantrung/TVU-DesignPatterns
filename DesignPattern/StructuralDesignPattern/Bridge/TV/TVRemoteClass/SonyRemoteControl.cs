using Bridge.TV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.TVRemote
{
    public class SonyRemoteControl : RemoteControl
    {
        public SonyRemoteControl( ILEDTV ledTV ) : base( ledTV )
        {
        }

        public override void SetChannel( int channelNumber )
        {
            if ( _ledTV is SonyLEDTV ) _ledTV.SetChannel( channelNumber );
        }

        public override void SwitchOff()
        {
            if ( _ledTV is SonyLEDTV ) _ledTV.SwitchOff();
        }

        public override void SwitchOn()
        {
            if ( _ledTV is SonyLEDTV ) _ledTV.SwitchOn();
        }
    }
}
