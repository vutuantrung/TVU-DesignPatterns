using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Demo.ImplementationClass
{
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ImplementationA";
        }
    }
}
