using AbstractFactory.Zoo.Animal;
using AbstractFactory.Zoo.Animal.LandAnimal;
using AbstractFactory.Zoo.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Zoo.Factory
{
    class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal( AnimalType animalType )
        {
            if ( animalType == AnimalType.Cat ) return new Cat();
            if ( animalType == AnimalType.Wolf ) return new Woft();
            if ( animalType == AnimalType.Lion ) return new Lion();

            throw new ArgumentException( "Animal type do not exist.", nameof( animalType ) );
        }
    }
}
