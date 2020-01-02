using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Command
{
    class Access
    {
        ICommand OpenCommand;
        ICommand CloseCommand;
        ICommand CopyCommand;
        ICommand PasteCommand;

        public Access(ICommand closeCommand, ICommand openCommand, ICommand copyCommand, ICommand pasteCommand)
        {
            this.OpenCommand = openCommand;
            this.CloseCommand = closeCommand;
            this.CopyCommand = copyCommand;
            this.PasteCommand = pasteCommand;
        }
        
        public void Close()
        {
            this.CloseCommand.Execute();
        }
        
        public void Open()
        {
            this.OpenCommand.Execute();
        }
        public void Copy()
        {
            this.CopyCommand.Execute();
        }
        
        public void Paste()
        {
            this.PasteCommand.Execute();
        }
    }
}
