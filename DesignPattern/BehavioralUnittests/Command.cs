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

            ICommand openCommand = new OpenCommand( receiver );
            ICommand closeCommand = new CloseCommand( receiver );
            ICommand saveCommand = new SaveCommand( receiver );

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
    }
}
