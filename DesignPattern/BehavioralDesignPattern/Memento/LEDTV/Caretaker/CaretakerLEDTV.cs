using Memento.LEDTV.Class;
using Memento.LEDTV.Memento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.LEDTV.Caretaker
{
    /// <summary>
    /// The caretaker is used to maintain the memento objects.
    /// This is the storeroom which is used to hold the led TVs.
    /// </summary>
    public class CaretakerLEDTV
    {
        List<MementoLEDTV> _listMemento = new List<MementoLEDTV>();

        /// <summary>
        /// The AddMemento method is used to add memento into the ledTvList properties
        /// </summary>
        /// <param name="m">Memento need to be added</param>
        public void AddMemento( MementoLEDTV m )
        {
            _listMemento.Add( m );
        }

        /// <summary>
        /// The GetMemento method is used to return the memento object.
        /// </summary>
        /// <param name="index">Index of list</param>
        /// <returns>Memento object</returns>
        public MementoLEDTV GetMemento( int index )
        {
            return _listMemento[index];
        }
    }
}
