using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Command
{
    class CloseFileCommand : ICommand
    {
        private IAccessible accessible;

        public CloseFileCommand(IAccessible accessible)
        {
            this.accessible = accessible;
        }
        public void Execute()
        {
            accessible.Close();
        }
    }
}
