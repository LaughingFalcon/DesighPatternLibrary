using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Service
{
    class ServiceLocator
    {
        private static Cache cache = new Cache();

        public static IService getService(String name)
        {
            IService service = cache.getService(name);

            if (service != null)
            {
                return service;
            }

            InitialContext context = new InitialContext();
            IService ServiceOne = (IService)context.lookup(name);
            cache.addService(ServiceOne);
            return ServiceOne;
        }
    }   
}
