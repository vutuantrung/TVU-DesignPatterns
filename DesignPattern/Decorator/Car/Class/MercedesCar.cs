using Decorator.Car.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Car.Class
{
    public class MercedesCar : ICar
    {
        private string CarName = "Mescedes";

        public string CarBody { get; set; }

        public string CarDoor { get; set; }

        public string CarWheels { get; set; }

        public string CarGlass { get; set; }

        public EngineType Engine { get; set; }

        public override string ToString()
        {
            return $@"MescedesCar [CarName={ CarName }, CarBody={ CarBody }, CarDoor={ CarDoor }, CarWheels={ CarWheels }, CarGlass={ CarGlass }, Engine={ Engine }]";
        }

        public ICar ManufactureCar()
        {
            CarBody = "carbon fiber material";
            CarDoor = "2 car doors";
            CarWheels = "4 car glasses";
            CarGlass = "4 MRF wheels";
            return this;
        }
    }
}
