using System;
using System.Collections.Generic;
using System.Text;

namespace SloppyJoe_sApp
{
    class MenuItem
    {
        public Random randomizer = new Random();

        public string[] proteins = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami", "Tofu" };
        public string[] condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        public string[] breads = { "rye", "white", "wheat", "pumpernickel", "a roll" };

        public string description = "";
        public string price;
    }
}
