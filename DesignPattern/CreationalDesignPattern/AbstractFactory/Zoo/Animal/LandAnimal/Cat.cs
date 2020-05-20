using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Zoo.Animal.LandAnimal
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }
}
