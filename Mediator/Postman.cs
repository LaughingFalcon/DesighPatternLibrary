using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Mediator
{
    public class Postman : IPostman
    {
        Dictionary<int,Worker> gang;

        public Postman()
        {
            gang = new Dictionary<int,Worker>();
        }
        public void sendMessage(int sender, string[] message)
        {
            gang[sender].lastMessage = message;
        }
        public void add(int address, Worker newGuy)
        {
            gang.Add(address,newGuy);
        }
    }
}
