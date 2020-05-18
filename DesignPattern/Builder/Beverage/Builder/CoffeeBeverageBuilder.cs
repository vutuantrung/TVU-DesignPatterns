using Builder.Example3.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.Builder
{
    public class CoffeeBeverageBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            GetBeverageRecipe().BeverageType = Beverage.Coffee;
        }

        public override void SetMilk()
        {
            GetBeverageRecipe().Milk = 60;
        }

        public override void SetPowderQuantity()
        {
            GetBeverageRecipe().PowderQuantity = 20;
        }

        public override void SetSugar()
        {
            GetBeverageRecipe().Sugar = 15;
        }

        public override void SetWater()
        {
            GetBeverageRecipe().Water = 50;
        }
    }
}
