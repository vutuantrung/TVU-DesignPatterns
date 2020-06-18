using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.DateTimeConvert.Class
{
    public class YearExpression : IExpression
    {
        public void Evaluate( Context context )
        {
            string expression = context.Expression;
            context.Expression = expression.Replace( "YYYY", context.DateTime.Year.ToString() );
        }
    }
}
