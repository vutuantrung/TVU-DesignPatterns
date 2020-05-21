using Facade.System.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.System.FacadeClass
{
    public class Facade
    {
        protected SubSystem1 _subsystem1;

        protected SubSystem2 _subsystem2;

        public Facade( SubSystem1 subsystem1, SubSystem2 subsystem2 )
        {
            this._subsystem1 = subsystem1;
            this._subsystem2 = subsystem2;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.Operation1();
            result += this._subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.OperationN();
            result += this._subsystem2.OperationZ();
            return result;
        }
    }
}
