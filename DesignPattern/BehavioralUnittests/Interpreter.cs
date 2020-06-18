using Interpreter.DateTimeConvert.Class;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Interpreter
    {
        [TestCase( "MM DD YYYY" )]
        [TestCase( "YYYY MM DD" )]
        [TestCase( "DD MM YYYY" )]
        public void Test_Date_time_convert( string dateTimeType )
        {
            List<IExpression> objExpressions = new List<IExpression>();
            Context context = new Context( DateTime.Now );

            context.Expression = dateTimeType;
            string[] strArray = context.Expression.Split( ' ' );

            // Treating day, month and year of datetime
            foreach ( string item in strArray )
            {
                if ( item == "DD" )
                {
                    objExpressions.Add( new DayExpression() );
                }
                else if ( item == "MM" )
                {
                    objExpressions.Add( new MonthExpression() );
                }
                else if ( item == "YYYY" )
                {
                    objExpressions.Add( new YearExpression() );
                }
            }

            // Adding separator expression
            objExpressions.Add( new SeparatorExpression() );

            foreach ( var obj in objExpressions )
            {
                obj.Evaluate( context );
            }

            Console.WriteLine( context.Expression );
        }
    }
}
