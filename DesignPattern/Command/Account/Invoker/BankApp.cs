using Command.Account.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Account.Invoker
{
    public class BankApp
    {
        ICommandAccount _openAccount;
        ICommandAccount _closeAccount;

        public BankApp( ICommandAccount openAccount, ICommandAccount closeAccount )
        {
            _openAccount = openAccount;
            _closeAccount = closeAccount;
        }

        public void OpenAccount()
        {
            _openAccount.Execute();
        }

        public void CloseAccount()
        {
            _closeAccount.Execute();
        }
    }
}
