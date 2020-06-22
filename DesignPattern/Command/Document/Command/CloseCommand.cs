using Command.Document.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Document.Command
{
    public class CloseCommand : ICommandDocument
    {
        private DocumentReceiver _receiver;

        public CloseCommand( DocumentReceiver receiver )
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Close();
        }
    }
}
