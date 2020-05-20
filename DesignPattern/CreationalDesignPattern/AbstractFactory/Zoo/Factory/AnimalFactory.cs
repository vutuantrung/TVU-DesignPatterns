using AbstractFactory.Zoo.Animal;
using AbstractFactory.Zoo.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Zoo.Factory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal( AnimalType animalType );

        public static AnimalFactory CreateAnimalFactory( AnimalFactoryType factoryType )
        {
            if ( factoryType == AnimalFactoryType.Land ) return new LandAnimalFactory();
            if ( factoryType == AnimalFactoryType.Sea ) return new SeaAnimalFactory();

            throw new ArgumentException( "Factory type do not exist.", nameof( factoryType ) );
        }
    }
}
