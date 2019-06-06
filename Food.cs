using System;

using System.Collections.Generic;

namespace IronNinja
{
    class Food: IConsumable
        {
        public string Name{set;get;}
        public int Calories{set;get;}
        public bool IsSpicy{set;get;}
        public bool IsSweet{set;get;}
        public Food(string name, int cal, bool Spicy, bool Sweet)
        {
            this.Name = name;
            this.Calories = cal;
            this.IsSpicy = Spicy;
            this.IsSweet = Sweet;
        }
        public string GetInfo()
        {
            string desc = $"You see a ";
            if(this.IsSpicy)
            {    
                desc += "spicy ";
            }
            if(this.IsSweet)
            {
                desc += "sweet ";
            }
            return desc += this.Name + $" ({this.Calories})";
        }
    }
}