using Decorator.Car.Class;
using Decorator.Car.Decorator;
using Decorator.Car.Enum;
using Decorator.ComponentDemo.Class;
using Decorator.ComponentDemo.Decorator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralUnittests
{
    [TestFixture]
    class DecoratorTests
    {
        [Test]
        public void test_cars()
        {
            {
                BMWCar bmwCar = new BMWCar();

                DieselCarDecorator carWithDieselEngine = new DieselCarDecorator( bmwCar );
                carWithDieselEngine.ManufactureCar();

                Assert.That( bmwCar.CarBody == "carbon fiber material" );
                Assert.That( bmwCar.CarDoor == "4 car doors" );
                Assert.That( bmwCar.CarWheels == "6 car glasses" );
                Assert.That( bmwCar.CarGlass == "4 MRF wheels" );

                Assert.That( bmwCar.Engine == EngineType.Diesel );
            }


            {
                MercedesCar merCar = new MercedesCar();

                PetrolCarDecorator carWithDieselEngine = new PetrolCarDecorator( merCar );
                carWithDieselEngine.ManufactureCar();

                Assert.That( merCar.CarBody == "carbon fiber material" );
                Assert.That( merCar.CarDoor == "2 car doors" );
                Assert.That( merCar.CarWheels == "4 car glasses" );
                Assert.That( merCar.CarGlass == "4 MRF wheels" );

                Assert.That( merCar.Engine == EngineType.Petrol );
            }
        }

        [Test]
        public void test_component_demo()
        {
            {
                ConcreteComponentA componentA = new ConcreteComponentA();
                ConcreteComponentB componentB = new ConcreteComponentB();

                ConcreteDecoratorA decoratorA = new ConcreteDecoratorA( componentA );
                decoratorA.Operation();

                decoratorA.SetComponent( componentB );
                decoratorA.Operation();
            }
        }
    }
}
