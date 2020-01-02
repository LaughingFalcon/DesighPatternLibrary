using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Command
{
    class OpenFileCommand : ICommand
    {
        private IAccessible accessible;

        public OpenFileCommand(IAccessible accessible)
        {
            this.accessible = accessible;
        }
        public void Execute()
        {
            accessible.Open();
        }
    }
}
