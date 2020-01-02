using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Bridge
{
    public class Bridge2 : IBridge
    {
        public void Function1()
        {
            Console.WriteLine("Bridge2.Function1");
        }

        public void Function2()
        {
            Console.WriteLine("Bridge2.Function2");
        }
    }
}
