using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Command
{
    interface IAccessible
    {
        void Open();
        void Close();
        void Copy();
        void Paste();
    }
}
