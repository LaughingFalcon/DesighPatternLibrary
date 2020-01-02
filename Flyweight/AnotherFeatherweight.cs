using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class AnotherFeatherweight
    {
        int anotherInfo;
        public int numericInfo;
        public AnotherFeatherweight(int anotherInfo)
        {
            this.anotherInfo = anotherInfo;
            numericInfo = anotherInfo * 7;
        }
    }
}
