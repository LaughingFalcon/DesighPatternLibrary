using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Lazy
{
    public class DatabasePage
    {
        List<DatabaseTable> tables;
        int quant;
        public DatabasePage(int quant)
        {
            this.quant = quant;
        }

        public List<DatabaseTable> list()
        {
            List<DatabaseTable> lista = new List<DatabaseTable>();
            for (int i = 0; i < quant; i++)
            {
                lista.Add(new DatabaseTable("info1","info2","info3",i));
            }
            return lista;
        }
    }
}
