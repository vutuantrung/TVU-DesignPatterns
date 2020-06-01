using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Demo.ImplementationClass
{
    public class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ImplementationB";
        }
    }
}
