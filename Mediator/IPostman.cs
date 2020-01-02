using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Mediator
{
    public interface IPostman
    {
        void sendMessage(int sender, string[] message);
        void add(int address, Worker newGuy);
    }
}
