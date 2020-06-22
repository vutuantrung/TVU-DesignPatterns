using Memento.LEDTV.Class;
using Memento.LEDTV.Memento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.LEDTV.Originator
{
    /// <summary>
    /// This is nothing but the Hall in our example where we need to place the led TV.
    /// </summary>
    public class OriginatorLEDTV
    {
        public TVLED TVLED { get; set; }

        /// <summary>
        /// The CreateMemento method is used to set the internal state of the memento object to led tv.
        /// </summary>
        /// <returns>New memento LEDTV</returns>
        public MementoLEDTV CreateMemento()
        {
            return new MementoLEDTV( this.TVLED );
        }

        /// <summary>
        /// The SetMemento method is used to restore or roll backthe memento
        /// </summary>
        /// <param name="memento">Memento need to be displayed</param>
        public void SetMemento( MementoLEDTV memento )
        {
            this.TVLED = memento.TVLED;
        }
    }
}
