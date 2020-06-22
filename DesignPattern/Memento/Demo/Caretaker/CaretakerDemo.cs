using Memento.Demo.Memento;
using Memento.Demo.Originator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Demo.Caretaker
{
    /// <summary>
    /// The Caretaker doesn't depend on the Concrete Memento class.
    /// Therefore, it doesn't have access to the originator's state, stored inside the memento.
    /// It works with all mementos via the base Memento interface.
    /// </summary>
    public class CaretakerDemo
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private OriginatorDemo _originator = null;

        public CaretakerDemo( OriginatorDemo originator )
        {
            _originator = originator;
        }

        /// <summary>
        /// Archived the current state into a memento and add it in list
        /// </summary>
        public void BackUp()
        {
            Console.WriteLine( "\nCaretaker: Saving Originator's state..." );

            // Current state need to be archived into a memento from originatior
            IMemento currentState = _originator.Save();

            // Add memento in list
            _mementos.Add( currentState );
        }

        /// <summary>
        /// Get the last state and restore it
        /// </summary>
        public void Undo()
        {
            // Do nothing if there is no backup state
            if ( _mementos.Count == 0 ) return;

            var memento = _mementos.Last();// Get last state
            _mementos.Remove( memento );// Remove the state from list

            try
            {
                _originator.Restore( memento );
            }
            catch ( Exception )
            {
                this.Undo();
            }
        }

        /// <summary>
        /// Show all the saved states
        /// </summary>
        public void ShowHistory()
        {
            foreach ( var memento in _mementos )
            {
                Console.WriteLine( memento.GetName() );
            }
        }

        /// <summary>
        /// Display the last state
        /// </summary>
        public void DisplayTheLastState()
        {
            Console.WriteLine( $"The last state is { _mementos.Last().GetName() }" );
        }
    }
}
