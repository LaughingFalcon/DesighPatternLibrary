using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Singleton
{
    public class ConnectDatabase
    {
        private static ConnectDatabase instance;
        private ConnectDatabase()
        {

        }

        public static ConnectDatabase getInstance()
        {
            if (instance == null)
            {
                Console.WriteLine("Criada nova instância");
                instance = new ConnectDatabase();
            }else
                Console.WriteLine("Instância reutilizada");

            return instance;
        }
    }
}
