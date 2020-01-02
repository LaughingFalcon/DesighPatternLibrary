using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class Featherweight
    {
        int info;
        public int numericInfo;
        public Featherweight(int info)
        {
            this.info = info;
            numericInfo = info * 5;
        }
    }
}
