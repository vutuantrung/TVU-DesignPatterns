using Builder.Example3.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.Builder
{
    public abstract class BeverageBuilder
    {
        protected BeverageRecipe _beverageRecipe;

        public abstract void SetBeverageType();

        public abstract void SetWater();

        public abstract void SetMilk();

        public abstract void SetSugar();

        public abstract void SetPowderQuantity();

        public void CreateBeverage()
        {
            _beverageRecipe = new BeverageRecipe();
        }

        public BeverageRecipe GetBeverageRecipe() => _beverageRecipe;
    }
}
