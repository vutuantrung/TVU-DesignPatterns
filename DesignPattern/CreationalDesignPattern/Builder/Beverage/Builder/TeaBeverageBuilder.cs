using Builder.Example3.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.Builder
{
    public class TeaBeverageBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            GetBeverageRecipe().BeverageType = Beverage.Tea;
        }

        public override void SetMilk()
        {
            GetBeverageRecipe().Milk = 50;
        }

        public override void SetPowderQuantity()
        {
            GetBeverageRecipe().PowderQuantity = 15;
        }

        public override void SetSugar()
        {
            GetBeverageRecipe().Sugar = 10;
        }

        public override void SetWater()
        {
            GetBeverageRecipe().Water = 40;
        }
    }
}
