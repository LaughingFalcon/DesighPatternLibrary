using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Strategy
{
    class EstrategiaBus : IStrategi
    {
        public double timeTravel(int distance, bool ishorarioPico)
        {
            double time = distance / 40;
            if (ishorarioPico)
                time = (time * 4)/3;

            return time;
        }
    }
}
