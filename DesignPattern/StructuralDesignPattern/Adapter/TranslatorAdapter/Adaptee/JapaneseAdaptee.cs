using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.TranslatorAdapter.Adaptee
{
    public class JapaneseAdaptee
    {
        public void Receive( string word )
        {
            Console.WriteLine( "Retrieving words from Adapter ..." );
            Console.WriteLine( word );
        }
    }
}
