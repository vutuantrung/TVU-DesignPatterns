using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Memento.Demo.Class
{
    public static class HelperClass
    {
        public static string GenerateRandomString( int length = 10 )
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while ( length > 0 )
            {
                result += allowedSymbols[new Random().Next( 0, allowedSymbols.Length )];

                Thread.Sleep( 12 );

                length--;
            }

            return result;
        }
    }
}
