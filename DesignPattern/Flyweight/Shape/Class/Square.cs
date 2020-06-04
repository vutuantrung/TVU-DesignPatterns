using Flyweight.Shape.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Shape.Class
{
    public class Square : IShape
    {
        public ShapeColor Color { get; set; }

        public void SetColor( ShapeColor color )
        {
            Color = color;
        }

        public IShape Draw()
        {
            return this;
        }
    }
}
