using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Lazy
{
    public class DatabaseLoader
    {
        static int maxTuples = 100;
        Dictionary<int, DatabasePage> list;

        public DatabaseLoader()
        {
            list = new Dictionary<int, DatabasePage>();
        }

        public void loadTuples(int quant)
        {
            int id = 1;
            while (quant>0)
            {
                if (quant <= maxTuples)
                {
                    list.Add(id, new DatabasePage(quant));
                    quant = 0;
                }
                else
                {
                    list.Add(id, new DatabasePage(maxTuples));
                    quant = quant - maxTuples;

                }
                id++;
            }
        }
        public List<DatabaseTable> takeTuples(int page)
        {
            if (list.ContainsKey(page))
                return list[page].list();
            else
                return null;
        }
    }
}
