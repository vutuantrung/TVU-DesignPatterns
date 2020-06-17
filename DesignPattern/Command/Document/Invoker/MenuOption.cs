using Command.Document.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Document.Invoker
{
    public class MenuOption
    {
        private ICommandDocument _openCommand;
        private ICommandDocument _saveCommand;
        private ICommandDocument _closeCommand;

        public MenuOption( ICommandDocument openCommand, ICommandDocument saveCommand, ICommandDocument closeCommand )
        {
            _openCommand = openCommand;
            _saveCommand = saveCommand;
            _closeCommand = closeCommand;
        }

        public void OpenClick()
        {
            _openCommand.Execute();
        }

        public void SaveClick()
        {
            _saveCommand.Execute();
        }

        public void CloseClick()
        {
            _closeCommand.Execute();
        }
    }
}
