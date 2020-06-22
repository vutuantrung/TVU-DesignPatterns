using Memento.LEDTV.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.LEDTV.Memento
{
    /// <summary>
    /// The Memento object is used to store the internal state of the originator.
    /// The originator has TVLED as an internal state and we are initializing that TVLED internal state using the constructor.
    /// </summary>
    public class MementoLEDTV
    {
        public TVLED TVLED { get; set; }

        public MementoLEDTV( TVLED tvLed = null )
        {
            TVLED = tvLed;
        }
    }
}
