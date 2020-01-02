using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Interpreter
{
    public class Client
    {
        public string name;
        public int idade;
        public string country;

        public Client(string name, int idade, string country)
        {
            this.name=name;
            this.idade= idade;
            this.country= country;
        }
    }
}
