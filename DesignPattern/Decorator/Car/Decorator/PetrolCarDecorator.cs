using Decorator.Car.Class;
using Decorator.Car.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Car.Decorator
{
    public class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator( ICar car ) : base( car )
        {
        }

        public override ICar ManufactureCar()
        {
            _car.ManufactureCar();
            AddEngine( _car );
            return base.ManufactureCar();
        }

        public void AddEngine( ICar car )
        {
            if ( car is MercedesCar )
            {
                MercedesCar mercedesCar = (MercedesCar)car;
                mercedesCar.Engine = EngineType.Petrol;
            }
        }
    }
}
