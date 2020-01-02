using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.State
{
    class Shock : ITechnoBlast
    {
        string nome;
        string luz;
        public Shock(string nome, string luz)
        {
            this.nome = nome;
            this.luz = luz;
        }
        public string attack()
        {
            return "Raios paralizam o inimigo!";
        }

        public string light()
        {
            return luz;
        }

        public string name()
        {
            return nome;
        }
    }
}
