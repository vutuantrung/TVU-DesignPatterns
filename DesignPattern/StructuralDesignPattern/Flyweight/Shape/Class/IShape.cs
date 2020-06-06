using Flyweight.Shape.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Shape.Class
{
    public interface IShape
    {
        IShape Draw();
        void SetColor( ShapeColor shapeColor );
    }
}
