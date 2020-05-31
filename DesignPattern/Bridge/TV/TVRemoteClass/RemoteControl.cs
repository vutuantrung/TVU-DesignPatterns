using Bridge.TV;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.TVRemote
{
    public abstract class RemoteControl
    {
        protected ILEDTV _ledTV;

        protected RemoteControl( ILEDTV ledTV )
        {
            _ledTV = ledTV;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel( int channelNumber );

    }
}
