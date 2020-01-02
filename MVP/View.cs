using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MVP
{
    public class View
    {
        Presenter presenter;
        public View()
        {

        }
        public View(string info)
        {
            presenter = new Presenter();
            presenter.analyzeInfo(info);
        }
        public void show(string info)
        {
            Console.WriteLine("Eu exibo o texto: "+info);
        }
        public void update()
        {
            Console.WriteLine("Me diga qual é a nova base: ");
            presenter.analyzeInfo(Console.ReadLine());
        }
    }
}
