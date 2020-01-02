using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Prototype
{
    public class Homy : IRobot
    {
        private string name;
        public int soapTank;
        bool hasBroom;

        public string Name { get => name; set => name = value; }

        public Homy(string name, int soapTank, bool hasBroom)
        {
            this.name = name;
            this.soapTank = soapTank;
            this.hasBroom = hasBroom;
        }
        public IRobot Clone()
        {
            return new Homy(name, soapTank, hasBroom);
        }

        public string info()
        {
            return "Nome: " + name+ " Capacidade do tank: " + soapTank;
        }
    }
}
