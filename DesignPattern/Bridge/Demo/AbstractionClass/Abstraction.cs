using Bridge.Demo.ImplementationClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Demo.AbstractionClass
{
    public class Abstraction
    {
        protected IImplementation _implementation;

        string _data;

        public Abstraction( IImplementation implementation )
        {
            _implementation = implementation;
        }

        public virtual void Operation()
        {
            if ( _implementation == null ) throw new ArgumentNullException( nameof( _implementation ) );

            _data = _implementation.OperationImplementation();

        }

        public string GetData() => _data;
    }
}
