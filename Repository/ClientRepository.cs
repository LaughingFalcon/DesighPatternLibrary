using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesighPatternLibrary.Repository
{
    class ClientRepository : IClientRepository
    {
        Dictionary<int, Client> clients;
        Client primeiro;
        Client segundo;
        Client terceiro;
        public ClientRepository()
        {
            primeiro = new Client("Joaquina", 1, "Banana");
            segundo = new Client("Francisco", 2, "Kiwi");
            terceiro = new Client("Roberlando", 3, "Abacate");
            clients = new Dictionary<int, Client>();
            clients.Add(1, primeiro);
            clients.Add(2, segundo);
            clients.Add(3, terceiro);
        }
        public List<Client> GetAllClient()
        {
            List<Client> temp = new List<Client>();
            temp.Add(primeiro);
            temp.Add(segundo);
            temp.Add(terceiro);
            return temp;
        }

        public Client GetClient(int idClient)
        {
            if (clients.ContainsKey(idClient))
                return clients[idClient];
            else
                return null;
               
        }

        public void UpdateClient(int idClient, string newFruit)
        {
            clients[idClient].fruit = newFruit;
        }
    }
}
