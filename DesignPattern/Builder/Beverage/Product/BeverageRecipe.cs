using Builder.Example3.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example3.Product
{
    public class BeverageRecipe
    {
        public int Water { get; set; }

        public int Milk { get; set; }

        public int Sugar { get; set; }

        public int PowderQuantity { get; set; }

        public Beverage BeverageType { get; set; }

        public string ShowRecipe()
        {
            return $@"Name: { BeverageType }:
                        Water:  { Water } ml,
                        Milk:   { Milk } ml,
                        Sugar: { Sugar } ml,
                        PowderQuantity: { PowderQuantity } g";
        }
    }
}
