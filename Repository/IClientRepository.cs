using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Repository
{
    interface IClientRepository
    {
        Client GetClient(int idClient);
        List<Client> GetAllClient();
        void UpdateClient(int idClient, string newFruit);
    }
}
