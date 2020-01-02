using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.State
{
    class NoDrive : ITechnoBlast
    {
        string nome;
        string luz;
        public NoDrive(string nome, string luz)
        {
            this.nome = nome;
            this.luz = luz;
        }
        public string attack()
        {
            return "Uma rajada de energia se choca com o inimigo!";
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
