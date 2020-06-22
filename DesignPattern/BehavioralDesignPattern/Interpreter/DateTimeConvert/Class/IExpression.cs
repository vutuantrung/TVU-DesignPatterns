using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.DateTimeConvert.Class
{
    public interface IExpression
    {
        void Evaluate( Context context );
    }
}
