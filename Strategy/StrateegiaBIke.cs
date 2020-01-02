using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Strategy
{
    class StrateegiaBIke : IStrategi
    {
        public double timeTravel(int distance, bool ishorarioPico)
        {
            double time = distance / 20;

            return time;
        }
    }
}
