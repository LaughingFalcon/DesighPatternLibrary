using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Mediator
{
    public class Worker
    {
        public string name;
        IPostman mediator;
        public string[] lastMessage;

        public Worker(string name, IPostman mediator)
        {
            this.name = name;
            this.mediator = mediator;
            lastMessage = new string[2];
        }

        public void sendMessage(int address, string message)
        {
            string[] text = { name , message };
            mediator.sendMessage(address,text);
        }
    }
}
