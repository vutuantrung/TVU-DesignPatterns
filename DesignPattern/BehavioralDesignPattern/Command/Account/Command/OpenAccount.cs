using Command.Account.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Account.Command
{
    public class OpenAccount : ICommandAccount
    {
        private AccountReceiver _receiver;

        public OpenAccount( AccountReceiver receiver )
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Open();
        }
    }
}
