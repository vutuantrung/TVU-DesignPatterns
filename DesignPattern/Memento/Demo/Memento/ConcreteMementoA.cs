using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Demo.Memento
{
    /// <summary>
    /// The Concrete Memento contains the infrastructure for storing the Originator's state.
    /// </summary>
    public class ConcreteMementoA : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMementoA( string state )
        {
            _state = state;
            _date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring( 0, 9 )})...";
        }

        /// <summary>
        /// This methode is used when restoring its state.
        /// </summary>
        /// <returns>Restored state</returns>
        public string GetState()
        {
            return _state;
        }
    }
}
