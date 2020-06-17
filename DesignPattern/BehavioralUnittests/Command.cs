using Command.Account.Command;
using Command.Account.Invoker;
using Command.Account.Receiver;
using Command.Document.Command;
using Command.Document.Invoker;
using Command.Document.Receiver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Command
    {
        [Test]
        public void Test_Document()
        {
            DocumentReceiver receiver = new DocumentReceiver();

            ICommandDocument openCommand = new OpenCommand( receiver );
            ICommandDocument closeCommand = new CloseCommand( receiver );
            ICommandDocument saveCommand = new SaveCommand( receiver );

            MenuOption menu = new MenuOption
            ( 
                openCommand: openCommand, 
                saveCommand: saveCommand, 
                closeCommand: closeCommand
            );

            menu.OpenClick();
            menu.SaveClick();
            menu.CloseClick();
        }

        [Test]
        public void Test_Account()
        {
            AccountReceiver receiver = new AccountReceiver( "Tuan Trung" );

            ICommandAccount openAccount = new OpenAccount( receiver );
            ICommandAccount closeAccount = new CloseAccount( receiver );

            BankApp bankApp = new BankApp
            ( 
                openAccount: openAccount, 
                closeAccount: closeAccount 
            );

            bankApp.OpenAccount();
            bankApp.CloseAccount();
        }
    }
}
