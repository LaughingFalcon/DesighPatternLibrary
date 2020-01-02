using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.MVP
{
    class Presenter
    {

        public void analyzeInfo(string info)
        {
            IModel model;
            if (info.Length > 5)
            {
                model = new Model();
            }
            else
            {
                model = new AnotherModel();
            }
            
            View view = new View();
            view.show(model.processInfo(info));
        }
    }
}
