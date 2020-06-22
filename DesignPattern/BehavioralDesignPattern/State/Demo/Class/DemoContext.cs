using State.Demo.ClassState;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.Demo.Class
{
    public class DemoContext
    {
        private DemoState _state = null;

        public DemoContext( DemoState state )
        {
            _state = state;
        }

        public void TransitorTo( DemoState state )
        {
            _state = state;
            _state.SetContext( this );
        }

        public void RequestA( Record record )
        {
            _state.HandleA( record );
        }

        public void RequestB( Record record )
        {
            _state.HandleB( record );
        }
    }
}
