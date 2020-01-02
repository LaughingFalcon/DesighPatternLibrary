using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Repository
{
    public class Client
    {
        public string name;
        public int id;
        public string fruit;
        public Client(string name, int id, string fruit)
        {
            this.name = name;
            this.id = id;
            this.fruit = fruit;
        }
    }
}
