using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Adapter
{
    class MegaEvolution
    {
        public double newNumber(string tipo1, string tipo2)
        {
            var number = 1.0;
            if (tipo1.Equals("Fuego")) number = number * 2;
            if (tipo2.Equals("Vento")) number = number + 2;

            return number;
        }
    }
}
