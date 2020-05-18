using AbstractFactory.Zoo.Animal;
using AbstractFactory.Zoo.Enum;
using AbstractFactory.Zoo.Factory;
using FactoryAbstract.Factory;
using FactoryAbstract.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class AbstractFactoryTests
    {
        [Test]
        public void get_product_A()
        {
            {
                IAbstractProductA prod = GetProduct( factory: new ConcreteFactory1() );

                Assert.That( prod.GetValue() == ProductTypes.ProductA1 );
            }

            {
                IAbstractProductA prod = GetProduct( factory: new ConcreteFactory2() );

                Assert.That( prod.GetValue() == ProductTypes.ProductA2 );
            }

            IAbstractProductA GetProduct( IAbstractFactory factory ) => factory.CreateProductA();
        }

        [Test]
        public void get_product_B()
        {
            {

                IAbstractProductB prod = GetProduct( factory: new ConcreteFactory1() );

                Assert.That( prod.GetValue() == ProductTypes.ProductB1 );
            }

            {
                IAbstractProductB prod = GetProduct( factory: new ConcreteFactory2() );

                Assert.That( prod.GetValue() == ProductTypes.ProductB2 );
            }

            IAbstractProductB GetProduct( IAbstractFactory factory ) => factory.CreateProductB();
        }

        [Test]
        public void test_zoo()
        {
            IAnimal animal;
            AnimalFactory animalFactory = null;

            {
                animalFactory = AnimalFactory.CreateAnimalFactory( AnimalFactoryType.Land );

                animal = animalFactory.GetAnimal( AnimalType.Cat );
                Assert.That( animal.Speak() == "Meow Meow Meow" );
                animal = animalFactory.GetAnimal( AnimalType.Lion );
                Assert.That( animal.Speak() == "Roar" );
                animal = animalFactory.GetAnimal( AnimalType.Wolf );
                Assert.That( animal.Speak() == "Bark bark" );

                Assert.Throws<ArgumentException>( () => animal = animalFactory.GetAnimal( AnimalType.Octopus ) );
                Assert.Throws<ArgumentException>( () => animal = animalFactory.GetAnimal( AnimalType.Shark ) );
            }

            {
                animalFactory = AnimalFactory.CreateAnimalFactory( AnimalFactoryType.Sea );

                animal = animalFactory.GetAnimal( AnimalType.Octopus );
                Assert.That( animal.Speak() == "SQUAWCK" );
                animal = animalFactory.GetAnimal( AnimalType.Shark );
                Assert.That( animal.Speak() == "Cannot Speak" );

                Assert.Throws<ArgumentException>( () => animal = animalFactory.GetAnimal( AnimalType.Cat ) );
                Assert.Throws<ArgumentException>( () => animal = animalFactory.GetAnimal( AnimalType.Lion ) );
                Assert.Throws<ArgumentException>( () => animal = animalFactory.GetAnimal( AnimalType.Wolf ) );
            }
        }
    }
}
