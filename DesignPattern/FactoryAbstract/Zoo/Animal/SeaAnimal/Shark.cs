using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Zoo.Animal.SeaAnimal
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "Cannot Speak";
        }
    }
}
