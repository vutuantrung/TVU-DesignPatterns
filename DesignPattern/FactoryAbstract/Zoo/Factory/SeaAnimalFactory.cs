using AbstractFactory.Zoo.Animal;
using AbstractFactory.Zoo.Animal.SeaAnimal;
using AbstractFactory.Zoo.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Zoo.Factory
{
    class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal( AnimalType animalType )
        {
            if ( animalType == AnimalType.Octopus ) return new Octopus();
            if ( animalType == AnimalType.Shark ) return new Shark();

            throw new ArgumentException( "Animal type do not exist.", nameof( animalType ) );
        }
    }
}
