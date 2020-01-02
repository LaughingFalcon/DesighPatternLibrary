using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Facade
{
    public class Facadex
    {
        ComplexAlpha alpha;
        ComplexBeta beta;
        ComplesGama gama;
        public Facadex()
        {
            alpha = new ComplexAlpha();
            beta = new ComplexBeta();
            gama = new ComplesGama();
        }
        public int sum(int aa, int bb)
        {
            return alpha.Sum(aa,bb);
        }
        public string concat(string left, string right)
        {
            return beta.concat(left, right);
        }

    }
}
