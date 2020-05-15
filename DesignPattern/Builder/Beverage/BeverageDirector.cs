using Builder.Example3.Builder;
using Builder.Example3.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3
{
    public class BeverageDirector
    {
        public BeverageRecipe MakeBeverageRecipe( BeverageBuilder builder )
        {
            builder.CreateBeverage();
            builder.SetBeverageType();
            builder.SetWater();
            builder.SetMilk();
            builder.SetSugar();
            builder.SetPowderQuantity();

            return builder.GetBeverageRecipe();
        }
    }
}
