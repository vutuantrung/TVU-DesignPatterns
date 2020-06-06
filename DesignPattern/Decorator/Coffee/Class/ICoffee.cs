using Decorator.Coffee.Decorator;
using Decorator.Coffee.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Coffee.Class
{
    public interface ICoffee
    {
        string GetDescription();
        double GetPrice();
        List<CondimentType> GetCondimentAdded();
        void AddCondiment( CondimentType condimentType, double condimentPrice );
    }
}
