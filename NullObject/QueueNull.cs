using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.NullObject
{
    public class QueueNull : IQueue
    {
        public QueueNull()
        {

        }
        public int GetValue()
        {
            return 0;
        }
    }
}
