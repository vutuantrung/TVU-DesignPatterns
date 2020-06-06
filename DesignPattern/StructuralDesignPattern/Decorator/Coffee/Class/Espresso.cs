using Decorator.Coffee.Decorator;
using Decorator.Coffee.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Coffee.Class
{
    public class Espresso : ICoffee
    {
        double _price;
        string _description;
        List<CondimentType> _condimentAdded;

        public Espresso()
        {
            _price = 2.99;
            _condimentAdded = new List<CondimentType>();
        }

        public void AddCondiment( CondimentType condimentType, double condimentPrice )
        {
            _price += condimentPrice;
            _condimentAdded.Add( condimentType );
            _description += $", { condimentType.ToString() }";
        }

        public string GetDescription()
        {
            return _description;
        }

        public double GetPrice()
        {
            return Math.Round( _price, 2 ); 
        }

        public List<CondimentType> GetCondimentAdded()
        {
            return _condimentAdded;
        }
    }
}
