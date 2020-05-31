using Decorator.Car.Class;
using Decorator.Car.Decorator;
using Decorator.Car.Enum;
using Decorator.Coffee.Class;
using Decorator.Coffee.Decorator;
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
            ConcreteComponentA componentA = new ConcreteComponentA();
            ConcreteComponentB componentB = new ConcreteComponentB();

            ConcreteDecoratorA decoratorA = new ConcreteDecoratorA( componentA );
            decoratorA.Operation();

            decoratorA.SetComponent( componentB );
            decoratorA.Operation();
        }

        [Test]
        public void test_coffee()
        {
            {
                ICoffee coffee = new Espresso();

                Chocolate decoratorChocolate = new Chocolate( coffee );
                decoratorChocolate.AddCondiment();

                Assert.That( coffee.GetPrice() == 3.98 );

                Milk decoratorMilk = new Milk( coffee );
                decoratorMilk.AddCondiment();

                Assert.That( coffee.GetPrice() == 5.97 );
            }

            {
                ICoffee coffee = new Espresso();

                Chocolate decoratorChocolate = new Chocolate( coffee );
                decoratorChocolate.AddCondiment();

                Milk decoratorMilk = new Milk( decoratorChocolate );
                decoratorMilk.AddCondiment();

                Assert.That( coffee.GetPrice() == 5.97 );
            }
        }
    }
}
