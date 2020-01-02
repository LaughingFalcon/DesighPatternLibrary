using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Composite
{
    class Mercenary: IMercenary
    {
        string name;
        int money;
        
        public Mercenary(string name)
        {
            this.name = name;
            money = 0;
        }
        public void data()
        {
            Console.WriteLine("Nome: "+name+" Grana: "+money);
        }

        public void NewMember(IMercenary andy)
        {
            throw new NotImplementedException();
        }

        public void payment(int value)
        {
            money += value;
        }
    }
}
