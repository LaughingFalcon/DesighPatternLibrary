using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.ChainOfResponsibility
{
    public class Company
    {
        Dictionary<string, IEmployee> employees;
        public Company()
        {
            employees = new Dictionary<string,IEmployee>();
            employees.Add("Fred", new Employee("Frederiquison",0,10000000));
            employees.Add("Mari", new Employee("Marisqueida", 1, 10000));
            employees["Mari"].SetHigher(employees["Fred"]);
            employees.Add("Anti", new Employee("Antonielson", 1, 1000));
            employees["Anti"].SetHigher(employees["Fred"]);
            employees.Add("Tina", new Employee("Antonitina", 2, 10));
            employees["Tina"].SetHigher(employees["Mari"]);
            employees.Add("Bobi", new Employee("Bobismaisley", 2, 10));
            employees["Bobi"].SetHigher(employees["Mari"]);
            employees.Add("Timy", new Employee("Timlierson", 2, 1));
            employees["Timy"].SetHigher(employees["Anti"]);
        }
        public Dictionary<string,IEmployee> GetEmployees()
        {
            return employees;
        }
    }
}
