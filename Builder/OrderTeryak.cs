using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Builder
{
    class OrderTeryak : IOrder
    {
        public Sandwish teryakSandwich;
        public OrderTeryak(string bread, bool isTosted, List<string> salad, List<string> sauce, List<string> cheese)
        {
            teryakSandwich = new Sandwish();
            chooseBread(bread, isTosted);
            chooseCheese(cheese);
            chooseMeat("TeryChicken");
            chooseSalad(salad);
            chooseSauce(sauce);
        }
        public Sandwish takeSandwish()
        {
            return teryakSandwich;
        }
        public void chooseBread(string type, bool isTosted)
        {
            teryakSandwich.IsTosted = isTosted;
            teryakSandwich.Bread = type;
        }

        public void chooseCheese(List<string> type)
        {
            teryakSandwich.Cheese = type;
        }

        public void chooseMeat(string type)
        {
            teryakSandwich.Meat = type;
        }

        public void chooseSalad(List<string> type)
        {
            teryakSandwich.Salad = type;
        }

        public void chooseSauce(List<string> type)
        {
            teryakSandwich.Sauce = type;
        }
    }
}
