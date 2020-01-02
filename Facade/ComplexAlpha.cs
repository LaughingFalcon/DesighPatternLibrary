using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Facade
{
    class ComplexAlpha
    {
        public int Sum(int first, int second)
        {
            ComplexBeta beta = new ComplexBeta();
            ComplesGama gama = new ComplesGama();

            int b = beta.TestValue(first);
            int g = gama.TestValue(second);

            return realSum(b,g);
        }
        public int realSum(int a, int b)
        {
            return (a + b);
        }

        public string TestText(string left)
        {
            if (String.IsNullOrEmpty(left))
                return "";
            else
                return left;
        }
    }
}
