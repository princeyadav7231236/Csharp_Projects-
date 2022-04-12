using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randon_Sandwitch_maker
{
    class MenuMaker
    {
        public Random Randomizer;    // This is a Random Variable.

        string[] meat = {"Roast Beef", "Salami", "Turkey", "Ham", "Pastrami"};
        string[] condiments = { "Yello Musturd", "Brown Musturd", "Honey Musturd",
            "Mayo", "Relish", "French Dressing" };
        string[] breads = { "Rye", "White", "Wheat", "Pumpernickel", "Italian Bread", "A roll"};

        public string GetMenuItem()
        {
            string RandomMeat = meat[Randomizer.Next(meat.Length)];
            string RandomCondiments = condiments[Randomizer.Next(condiments.Length)];
            string RandomBreads = breads[Randomizer.Next(breads.Length)];
            return RandomMeat + " With " + RandomCondiments + " on " + RandomBreads;
        }
    }
}
