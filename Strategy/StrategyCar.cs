using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Strategy
{
    class StrategyCar : IStrategi
    {
        public double timeTravel(int distance, bool ishorarioPico)
        {
            double time = distance / 50;
            if (ishorarioPico)
                time = time * 2;

            return time;
        }
    }
}
