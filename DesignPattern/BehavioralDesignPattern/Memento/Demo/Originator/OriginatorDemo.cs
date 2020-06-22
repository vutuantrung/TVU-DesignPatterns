using Memento.Demo.Class;
using Memento.Demo.Memento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Demo.Originator
{
    /// <summary>
    /// The Originator holds some important state that may change over time.
    /// It also defines a method for saving the state inside a memento and another method for restoring the state from it.
    /// </summary>
    public class OriginatorDemo
    {
        private string _currentState;

        public OriginatorDemo( string state )
        {
            _currentState = state;
        }

        /// <summary>
        /// The Originator's business logic may affect its internal state.
        /// Therefore, the client should backup the state before launching methods of the business logic via the save() method.
        /// </summary>
        public void DoSomething()
        {
            this._currentState = HelperClass.GenerateRandomString( 30 );
            Console.WriteLine( $"Originator: and my state has changed to: {_currentState}" );
        }

        /// <summary>
        /// Save the current state inside a memento.
        /// </summary>
        /// <returns>The concrete memento which hold the current state</returns>
        public IMemento Save()
        {
            return new ConcreteMementoA( _currentState );
        }

        /// <summary>
        /// Restores the Originator's state from a memento object
        /// </summary>
        /// <param name="memento">Memento hold the state which is need to be restored</param>
        public void Restore( IMemento memento )
        {
            // Throw exception if memento is not the current memento's type
            if ( !( memento is ConcreteMementoA ) )
            {
                throw new Exception( $"Unknown memento class { memento.ToString() }" );
            }

            _currentState = memento.GetState();
        }
    }
}
