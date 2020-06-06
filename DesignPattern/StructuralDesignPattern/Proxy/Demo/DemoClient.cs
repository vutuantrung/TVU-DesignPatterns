using Proxy.Demo.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Demo
{
    public class DemoClient
    {
        public void ClientCode( ISubject subject )
        {
            subject.Request();
        }
    }
}
