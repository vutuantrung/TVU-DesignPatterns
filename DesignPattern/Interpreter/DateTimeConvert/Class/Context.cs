using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.DateTimeConvert.Class
{
    public class Context
    {
        public string Expression { get; set; }

        public DateTime DateTime { get; set; }

        public Context( DateTime dateTime )
        {
            this.DateTime = dateTime;
        }
    }
}
