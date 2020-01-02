using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class Birdweight
    {
        List<Featherweight> feather;
        List<AnotherFeatherweight> aFeather;
        int potato;
        public int numericInfo;
        public Birdweight(int info, int anotherInfo, int potato)
        {
            feather = new List<Featherweight>();
            aFeather = new List<AnotherFeatherweight>();
            feather.Add(new Featherweight(info));
            aFeather.Add(new AnotherFeatherweight(anotherInfo));
            this.potato = potato;
            numericInfo = 0;
            calcSize();
        }
        void calcSize()
        {
            numericInfo = potato*100;
            foreach (Featherweight feat in feather)
            {
                numericInfo = numericInfo + feat.numericInfo;
            }
            foreach (AnotherFeatherweight afeat in aFeather)
            {
                numericInfo = numericInfo + afeat.numericInfo;
            }
        }
        public void addInfo(int info, int anotherInfo)
        {
            feather.Add(new Featherweight(info));
            aFeather.Add(new AnotherFeatherweight(anotherInfo));
            calcSize();
        }

        public int size()
        {
            return numericInfo;
        }
    }
}
