using Decorator.Car.Class;
using Decorator.Car.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Car.Decorator
{
    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator( ICar car ) : base( car )
        {
        }

        public override ICar ManufactureCar()
        {
            _car.ManufactureCar();
            AddEngine( _car );
            return _car;
        }

        public void AddEngine( ICar car )
        {
            if ( car is BMWCar )
            {
                BMWCar bmwCar = (BMWCar)car;
                bmwCar.Engine = EngineType.Diesel;
            }
        }
    }
}
