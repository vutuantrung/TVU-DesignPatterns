using Command.Document.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Document.Command
{
    public class SaveCommand : ICommandDocument
    {
        private DocumentReceiver _receiver;

        public SaveCommand( DocumentReceiver receiver )
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Save();
        }
    }
}
