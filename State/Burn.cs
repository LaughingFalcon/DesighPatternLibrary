using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.State
{
    class Burn : ITechnoBlast
    { 
        string nome;
        string luz;
        public Burn(string nome, string luz)
        {
            this.nome = nome;
            this.luz = luz;
        }
        public string attack()
        {
            return "Chamas queimam o inimigo!";
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
