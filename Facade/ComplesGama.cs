using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Facade
{
    class ComplesGama
    {
        public int TestValue(int value)
        {
            return ( ( value / value ) * value );
        }

        public string TestText(string right)
        {
            if (String.IsNullOrWhiteSpace(right))
                return "";
            else
                return right;
        }
    }
}
