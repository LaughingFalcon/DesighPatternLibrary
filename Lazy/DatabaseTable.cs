using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Lazy
{
    public class DatabaseTable
    {
        public string column1;
        string column2;
        string column3;
        public int id;

        public DatabaseTable(string column1, string column2, string column3, int id)
        {
            this.column1 = column1;
            this.column2 = column2;
            this.column3 = column3;
            this.id = id;
        }
    }
}
