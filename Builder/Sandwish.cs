using System;
using System.Collections.Generic;
using System.Text;

namespace DesighPatternLibrary.Builder
{
    public class Sandwish
    {
        string bread;
        List<string> cheese;
        string meat;
        List<string> salad;
        List<string> sauce;
        bool isTosted;

        public Sandwish()
        {

        }
        Sandwish(string bread, List<string> cheese, string meat, List<string> salad, List<string> sauce, bool isTosted)
        {
            this.Bread = bread;
            this.Cheese = cheese;
            this.Meat = meat;
            this.Salad = salad;
            this.Sauce = sauce;
            this.IsTosted = isTosted;
        }

        public string Bread { get => bread; set => bread = value; }
        public List<string> Cheese { get => cheese; set => cheese = value; }
        public string Meat { get => meat; set => meat = value; }
        public List<string> Salad { get => salad; set => salad = value; }
        public List<string> Sauce { get => sauce; set => sauce = value; }
        public bool IsTosted { get => isTosted; set => isTosted = value; }
    }
}
