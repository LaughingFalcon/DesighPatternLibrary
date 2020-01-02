using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Composite
{
    interface IMercenary
    {
        void payment(int value);
        void data();
        void NewMember(IMercenary andy);
    }
}
