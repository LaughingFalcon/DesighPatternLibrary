using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Builder
{
    public class OrderVegan : IOrder
    {
        public Sandwish veganSandwich;
        public OrderVegan(bool isTosted, List<string> salad, List<string> sauce)
        {
            veganSandwich = new Sandwish();
            chooseBread("veganBread", isTosted);
            List<string> queijo = new List<string>();
            queijo.Add("No cheese");
            chooseCheese(queijo);
            chooseMeat("No meat");
            chooseSalad(salad);
            chooseSauce(sauce);
        }

        public Sandwish takeSandwish()
        {
            return veganSandwich;
        }
        public void chooseBread(string type, bool isTosted)
        {
            veganSandwich.IsTosted = isTosted;
            veganSandwich.Bread = type;
        }

        public void chooseCheese(List<string> type)
        {
            veganSandwich.Cheese = type;
        }

        public void chooseMeat(string type)
        {
            veganSandwich.Meat = type;
        }

        public void chooseSalad(List<string> type)
        {
            veganSandwich.Salad = type;
        }

        public void chooseSauce(List<string> type)
        {
            veganSandwich.Sauce = type;
        }
    }
}
