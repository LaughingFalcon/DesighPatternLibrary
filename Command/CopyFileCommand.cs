using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Command
{
    class CopyFileCommand : ICommand
    {
        private IAccessible accessible;

        public CopyFileCommand(IAccessible accessible)
        {
            this.accessible = accessible;
        }
        public void Execute()
        {
            accessible.Copy();
        }
    }
}
