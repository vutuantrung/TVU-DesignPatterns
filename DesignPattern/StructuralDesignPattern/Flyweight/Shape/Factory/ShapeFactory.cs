using Flyweight.Shape.Class;
using Flyweight.Shape.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Shape.Factory
{
    public class ShapeFactory
    {
        private static Dictionary<ShapeType, IShape> shapeMap = new Dictionary<ShapeType, IShape>();

        public static IShape GetShapeObject( ShapeType shapeType )
        {
            IShape shape = null;

            // Check if existe this type of shape in dictionary
            if ( !shapeMap.TryGetValue( shapeType, out shape ) )
            {
                // Create this new type of shape
                switch ( shapeType )
                {
                    case ShapeType.Circle:
                        shape = new Circle();
                        break;
                    case ShapeType.Rectangle:
                        shape = new Rectangle();
                        break;
                    case ShapeType.Triangle:
                        shape = new Triangle();
                        break;
                    case ShapeType.Square:
                        shape = new Square();
                        break;
                    default: break;
                }

                // Store the new shape into dictionary
                shapeMap.Add( shapeType, shape );
            }

            return shape;
        }

        public static Dictionary<ShapeType, IShape> GetDictionary() => shapeMap;
    }
}
