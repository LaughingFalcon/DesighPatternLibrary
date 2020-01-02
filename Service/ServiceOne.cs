using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Service
{
    class ServiceOne : IService
    {
        public void execute()
        {
            Console.WriteLine("Rodando ServiceOne");
        }
        
        public String getName()
        {
            return "ServiceOne";
        }
    }
}
