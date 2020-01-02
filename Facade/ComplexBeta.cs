using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Facade
{
    class ComplexBeta
    {
        public int TestValue(int first)
        {
            return ((first * first) / first);
        }
        public string concat(string left, string right)
        {
            ComplesGama gama = new ComplesGama();
            ComplexAlpha alpha = new ComplexAlpha();
            return alpha.TestText(left)+gama.TestText(right);
        }
    }
}
