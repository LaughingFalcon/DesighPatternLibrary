using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.State
{
    class Genesect
    {
        public string name;
        ITechnoBlast state;

        public Genesect(string name)
        {
            this.name = name;
            state = new NoDrive("Padraum","Branca");
        }

        public void attack()
        {
            Console.WriteLine(name + " ataca com seu canhão!");
            Console.WriteLine("Uma luz "+state.light()+" surge!");
            Console.WriteLine(state.attack());
        }
        public void setDrive(ITechnoBlast newState)
        {
            this.state = newState;
            Console.WriteLine(name+" alterou o Drive para o "+ newState.name());
        }
    }
}
