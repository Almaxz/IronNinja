namespace IronNinja
{
    class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        
        public Drink(string Name, int Cal)
        {
            this.Name = Name;
            this.Calories = Cal;
            this.IsSpicy = false;
            this.IsSweet = true;
        }
        public string GetInfo()
        {
            string desc = $"You see a(n) ";
            if(this.IsSweet)
            {
                desc += "sweet ";
            }
            return desc += $"{this.Name} ({this.Calories})";
        }
    }  
}