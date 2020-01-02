using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Service
{
    class Cache
    {
        private List<IService> services;

        public Cache()
        {
            services = new List<IService>();
        }

        public IService getService(String serviceName)
        {
            foreach (IService service in services)
            {
                if (service.getName().Equals(serviceName))
                {
                    Console.WriteLine("Retornando do cache "
                                       + serviceName);
                    return service;
                }
            }
            return null;
        }

        public void addService(IService newService)
        {
            bool exists = false;
            foreach (IService service in services)
            {
                if (service.getName().Equals(newService.getName()))
                {
                    exists = true;
                }
            }
            if (!exists)
            {
                services.Add(newService);
            }
        }
    }
}
