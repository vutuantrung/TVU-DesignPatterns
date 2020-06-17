using Command.Document.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Document.Command
{
    public class OpenCommand : ICommand
    {
        private DocumentReceiver _receiver;

        public OpenCommand( DocumentReceiver receiver )
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Open();
        }
    }
}
