using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MVP
{
    class Model : IModel
    {
        public string processInfo(string info)
        {
            return "Xxx" + info + "xxX";
        }
    }
}
