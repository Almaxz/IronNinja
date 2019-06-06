using System;

using System.Collections.Generic;

namespace IronNinja
{
    abstract class Ninja 
    {
        private int calorieIntake;
        public string name;
        public int calorieLimit;
        public List<IConsumable> Consumption;
        
        public Ninja( string name)
        {
            this.name = name;
            this.calorieLimit = 1500;
            this.calorieIntake = 0;
            this.Consumption = new List<IConsumable>();
        }
        public bool IsFull
        {
            get
            {
                return calorieIntake >= this.calorieLimit;
            }
        }

        public virtual void Consume(IConsumable item)
        {
            Console.WriteLine(item.GetInfo());
            if( this.IsFull)
            {
                Console.WriteLine($"Warning! {this.name}'s stomach is about to explode from consuming over {this.calorieIntake} KCal, please keep a safe distance!!");
                return;
            }
            this.calorieIntake += item.Calories;
            this.Consumption.Add(item);
            if (item is Food)
            {
                Console.WriteLine($"Woah!!! {this.name} just swallowed {item.Name} as a whole!");
            }
            else
            {
                Console.WriteLine($"Woah!!! {this.name} just finish the {item.Name} in 1 sip!!");
            }
        }
    }
}