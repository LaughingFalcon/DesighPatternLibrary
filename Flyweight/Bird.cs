using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class Bird
    {
        int info;
        int anotherInfo;
        int potato;
        int numericInfo;
        public Bird(int info, int anotherInfo, int potato)
        {
            this.info = info;
            this.anotherInfo = anotherInfo;
            this.potato = potato;
            numericInfo = (info * 5) + (anotherInfo * 7) + (potato * 100);
        }

        public int size()
        {
            return numericInfo;
        }
    }
}
