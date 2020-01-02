using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Service
{
    class InitialContext
    {
        public Object lookup(string name)
        {
            if (name.Equals("ServiceOne"))
            {
                Console.WriteLine("Criando ServiceOne");
                return new ServiceOne();
            }
            else if (name.Equals("ServiceTwo"))
            {
                Console.WriteLine("Criando ServiceTwo");
                return new ServiceTwo();
            }
            return null;
        }
    }
}
