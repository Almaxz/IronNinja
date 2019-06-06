using System;
using System.Collections.Generic;

namespace IronNinja
{
    class SpiceHound: Ninja
    {
        public SpiceHound(string name) : base(name)
        {

        }
        public override void Consume(IConsumable item)
        {
            if(item.IsSpicy)
            {
                item.Calories -= 100;
            }
            base.Consume(item);
        }
    }
}