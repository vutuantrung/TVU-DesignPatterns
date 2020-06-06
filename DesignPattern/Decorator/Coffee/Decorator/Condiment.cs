using Decorator.Coffee.Class;
using Decorator.Coffee.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Coffee.Decorator
{
    public abstract class Condiment : ICoffee
    {
        protected ICoffee _coffee;

        public Condiment( ICoffee coffee )
        {
            _coffee = coffee;
        }

        public virtual void AddCondiment( CondimentType condimentType, double condimentPrice )
        {
            _coffee.AddCondiment( condimentType, condimentPrice );
        }

        public List<CondimentType> GetCondimentAdded()
        {
            return _coffee.GetCondimentAdded();
        }

        public string GetDescription()
        {
            return _coffee.GetDescription();
        }

        public double GetPrice()
        {
            return _coffee.GetPrice();
        }
    }
}
