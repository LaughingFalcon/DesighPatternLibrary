using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Adapter
{
    class Revest
    {
        public string newPoke(string tipo1, string tipo2)
        {
            if (tipo1.Equals("ROck")) return "metalic";
            if (tipo1.Equals("Fire")) return "shadow";

            return "normal";
        }
    }
}
