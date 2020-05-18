using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Zoo.Animal.SeaAnimal
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
