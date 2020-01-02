using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Command
{
    
    class PasteFileCommand : ICommand
    {
        private IAccessible accessible;

        public PasteFileCommand(IAccessible accessible)
        {
            this.accessible = accessible;
        }
        public void Execute()
        {
            accessible.Paste();
        }
    }
}
