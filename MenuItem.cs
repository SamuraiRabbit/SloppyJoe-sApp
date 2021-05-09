using System;
using System.Collections.Generic;
using System.Text;

namespace SloppyJoe_sApp
{
    class MenuItem
    {
        public static Random randomizer = new Random();

        public string[] proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] condiments = { "english mustard", "american mustard", "ketchup", "french mustard", "honey mustard", "mayo", "perri perri mayo" ,"relish", "french dressing" };
        public string[] breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string description = "";
        public string price;

        public void Generate()
        {
            string randomProtein = proteins[randomizer.Next(proteins.Length)];
            string randomCondiment = condiments[randomizer.Next(condiments.Length)];
            string randomBread = breads[randomizer.Next(breads.Length)];
            description = randomProtein + " with " + randomCondiment + " on " + randomBread;

            decimal pounds = randomizer.Next(2, 5);
            decimal pence = randomizer.Next(1, 98);
            decimal cost = pounds + (pence * .01M);
            price = cost.ToString("c");
        }

    }
}
