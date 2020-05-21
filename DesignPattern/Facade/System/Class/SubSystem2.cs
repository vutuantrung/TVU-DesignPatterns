using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.System.Class
{
    public class SubSystem2
    {
        public bool IsSubSystemReady { get; set; }

        public bool IsSubSystemWorking { get; set; }

        public void Operation1()
        {
            IsSubSystemReady = true;
        }

        public void OperationZ()
        {
            IsSubSystemWorking = true;
        }
    }
}
