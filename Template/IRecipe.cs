using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Template
{
    interface IRecipe
    {
        string fazerBolo(string nome);
        void juntarIngredientes();
        void untarForma();
        void misturarIngredientes();
        void colocarCoisasNaForma();
        void levarFormaAoForno();
        void preaquecerForno();
        void assarBolo();
        void prepararCobertura();
        void retirarBoloForno();
        void incluirCobertura();


    }
}
