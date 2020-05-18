using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Zoo.Animal.LandAnimal
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
