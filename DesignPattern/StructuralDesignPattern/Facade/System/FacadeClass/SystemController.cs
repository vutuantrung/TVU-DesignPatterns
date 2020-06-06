using Facade.System.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.System.FacadeClass
{
    public class SystemController
    {
        protected SubSystem1 _subsystem1;

        protected SubSystem2 _subsystem2;

        public SystemController( SubSystem1 subsystem1, SubSystem2 subsystem2 )
        {
            _subsystem1 = subsystem1;
            _subsystem2 = subsystem2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public void Operation()
        {
            _subsystem1.Operation1();
            _subsystem2.Operation1();

            _subsystem1.OperationN();
            _subsystem2.OperationZ();
        }
    }
}
