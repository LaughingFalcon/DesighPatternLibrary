using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Decorator
{
    class Link : IHero
    {
        double underwater;
        double vulcano;
        double all;
        public Link()
        {
            underwater = 0.1;
            vulcano = 0.3;
            all = 0.9;
        }
        public double skillAllRound()
        {
            return all;
        }

        public double skillUnderwater()
        {
            return underwater;
        }

        public double skillVulcano()
        {
            return vulcano;
        }
    }
}
