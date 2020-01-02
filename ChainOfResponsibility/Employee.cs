using DesighPatternLibrary.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.ChainOfResponsibility
{
    public class Employee : IEmployee
    {
        string name;
        public int cargo;
        IEmployee higher;
        int maxMoney;

        public Employee()
        {
            cargo = -1;
        }
        public Employee(string name, int cargo, int maxMoney)
        {
            this.name = name;
            this.cargo = cargo;
            this.maxMoney = maxMoney;
            this.higher = new Employee();
        }

        public bool RequestMoney(int value)
        {
            ConnectDatabase instance = ConnectDatabase.getInstance();
            Console.WriteLine(this.name+" requisita R$"+value);
            if (value > maxMoney)
                if (higher.HasHigher())
                {
                    Console.WriteLine(this.name + " solicita ao superior");
                    return higher.RequestMoney(value);
                }
                else
                {
                    Console.WriteLine(this.name + " nega a grana");
                    return false;
                }

            else
            {
                Console.WriteLine(this.name + " libera a grana");
                return true;
            }
                
        }
        public bool HasHigher()
        {
            if (cargo < 0)
                return false;
            else
                return true;
        }
        public void SetHigher(IEmployee boss)
        {
            this.higher = boss;
        }
    }
}
