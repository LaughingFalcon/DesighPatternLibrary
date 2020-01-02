using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Service
{
    class ServiceTwo: IService
    {
        public void execute()
        {
            Console.WriteLine("Rodando ServiceTwo");
        }

        public String getName()
        {
            return "ServiceTwo";
        }
    }
}
