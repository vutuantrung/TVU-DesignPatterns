using Command.Document.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Document.Invoker
{
    public class MenuOption
    {
        private ICommand _openCommand;
        private ICommand _saveCommand;
        private ICommand _closeCommand;

        public MenuOption( ICommand openCommand, ICommand saveCommand, ICommand closeCommand )
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
