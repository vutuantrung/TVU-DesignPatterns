using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Account.Receiver
{
    public class AccountReceiver
    {
        private string Name { get; set; }

        public AccountReceiver(string name)
        {
            Name = name;
        }

        public void Open()
        {
            Console.WriteLine( "Open account." );
        }

        public void Close()
        {
            Console.WriteLine( "Close account." );
        }
    }
}
