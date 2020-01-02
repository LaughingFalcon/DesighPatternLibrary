using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MVP
{
    class AnotherModel : IModel
    {
        public string processInfo(string info)
        {
            return "Supah " + info + " from Hell";
        }
    }
}
