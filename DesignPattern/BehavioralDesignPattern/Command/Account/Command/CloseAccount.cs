using Command.Account.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Account.Command
{
    public class CloseAccount : ICommandAccount
    {
        private AccountReceiver _receiver;

        public CloseAccount( AccountReceiver receiver )
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Close();
        }
    }
}
