using State.Demo.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace State.Demo.ClassState
{
    public abstract class DemoState
    {
        protected DemoContext _context;

        public void SetContext( DemoContext context )
        {
            _context = context;
        }

        public abstract void HandleA( Record record );

        public abstract void HandleB( Record record );
    }
}
