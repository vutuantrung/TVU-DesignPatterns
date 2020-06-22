using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Document.Receiver
{
    public class DocumentReceiver
    {
        public void Open()
        {
            Console.WriteLine( "Document opened." );
        }

        public void Save()
        {
            Console.WriteLine( "Document saved." );
        }

        public void Close()
        {
            Console.WriteLine( "Document closed." );
        }
    }
}
