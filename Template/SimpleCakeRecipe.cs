using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Template
{
    class SimpleCakeRecipe : IRecipe
    {
        public string fazerBolo(string nome)
        {
            juntarIngredientes();
            return nome+" pronto.";
        }
        public void assarBolo()
        {
            Console.WriteLine("Assando o Bolo...");
            retirarBoloForno();
        }

        public void colocarCoisasNaForma()
        {
            Console.WriteLine("Colocando mistura na forma...");
            levarFormaAoForno();
        }

        public void incluirCobertura()
        {
            throw new NotImplementedException();
        }

        public void juntarIngredientes()
        {
            Console.WriteLine("Juntando os ingredientes...");
            preaquecerForno();
        }

        public void levarFormaAoForno()
        {
            Console.WriteLine("Levando forma ao forno...");
            assarBolo();
        }

        public void misturarIngredientes()
        {
            Console.WriteLine("Misturando tudo...");
            untarForma();
        }

        public void preaquecerForno()
        {
            Console.WriteLine("Preaquecendo o forno...");
            misturarIngredientes();

        }

        public void prepararCobertura()
        {
            throw new NotImplementedException();
        }

        public void retirarBoloForno()
        {
            Console.WriteLine("Retirando o Bolo do forno...");
        }

        public void untarForma()
        {
            Console.WriteLine("Untando Forma...");
            colocarCoisasNaForma();
        }
    }
}
