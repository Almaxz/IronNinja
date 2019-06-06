using System;
using System.Collections.Generic;

namespace IronNinja
{
    class Buffet
    {
        public List<IConsumable> Menu;
        public Random rand;
        
        public Buffet()
        {
            this.rand = new Random();
            Menu = new List<IConsumable>()
            {
                new Food("Chick-fil-A Chicken Sandwich", 440, false, false),
                new Food("Chick-fil-A Deluxe Sandwich", 500, false, false),
                new Food("Grilled Chicken Sandwich", 310, false, false),
                new Food("Chicken Sandwich", 450, true, false),
                new Food("Delxue Sandwich", 540, true, false),
                new Food("Grilled Chicken Club", 440, false, true),
                new Food("Chick-fil-A Nuggets", 260, false, false),
                new Drink("Cookies & Cream Milkshake", 610),
                new Drink("Strawberry Milkshake", 610),
                new Drink("Chick-fil-A Lemonade", 220),
                new Drink("Sweetened Iced Tea", 120),
                new Drink("Vanilla Milkshake", 610),
                new Drink("Iced Coffee", 140),
            };
        }
         
        public IConsumable Serve()
        {
            int menuLen = Menu.Count;
            int randInt = rand.Next(menuLen);
            IConsumable randFood = Menu[randInt];

            return randFood;
        }
    }
}