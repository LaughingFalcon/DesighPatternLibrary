using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Command
{
    class Archive : IAccessible
    {
        bool copyEnabled;
        bool opened;
        public Archive()
        {
            copyEnabled = false;
            opened = false;
        }
        public void Close()
        {
            if (opened)
            {
                Console.WriteLine("Arquivo fechado");
                opened = false;
            }
            else
                Console.WriteLine("Arquivo já estava fechado");
        }

        public void Copy()
        {
            if (copyEnabled)
                Console.WriteLine("Já solicitou a cópia");
            else
            {
                Console.WriteLine("Solicitação de cópia aceita");
                copyEnabled = true;
            }
                
        }

        public void Open()
        {
            if (opened)
                Console.WriteLine("Arquivo já estava aberto");
            else
            {
                Console.WriteLine("Arquivo aberto");
                opened = true;
            }
                
        }

        public void Paste()
        {
            if (copyEnabled)
            {
                Console.WriteLine("Novo arquico criado");
                copyEnabled = false;
            }
            else
                Console.WriteLine("Necessário solicitar cópia antes");
        }
    }
}
