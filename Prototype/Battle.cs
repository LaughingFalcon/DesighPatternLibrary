using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Prototype
{
    public class Battle : IRobot
    {
        public string name;
        public int cannons;
        bool hasBlades;
        public Battle(string name, int cannons, bool hasBlades)
        {
            this.name = name;
            this.cannons = cannons;
            this.hasBlades = hasBlades;
        }
        public IRobot Clone()
        {
            return new Battle(name,cannons,hasBlades);
        }
        public string info()
        {
            return "Nome: " + name + " Quantidade de Canhões: " + cannons;
        }
    }
}
