using Decorator.Car.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Car.Decorator
{
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator( ICar car )
        {
            _car = car;
        }

        public virtual ICar ManufactureCar()
        {
            return _car.ManufactureCar();
        }
    }
}
