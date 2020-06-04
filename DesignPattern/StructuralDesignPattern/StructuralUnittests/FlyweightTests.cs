using Flyweight.Shape.Class;
using Flyweight.Shape.Enum;
using Flyweight.Shape.Factory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralUnittests
{
    [TestFixture]
    public class FlyweightTests
    {
        [Test]
        public void Test_shape()
        {
            for ( int i = 0; i < 4; i++ )
            {
                IShape circle = (Circle)ShapeFactory.GetShapeObject( ShapeType.Circle );
                circle.SetColor( ShapeColor.Black );
                circle.Draw();
            }

            for ( int i = 0; i < 3; i++ )
            {
                IShape triangle = (Triangle)ShapeFactory.GetShapeObject( ShapeType.Triangle );
                triangle.SetColor( ShapeColor.Orange );
                triangle.Draw();
            }

            for ( int i = 0; i < 2; i++ )
            {
                IShape rectangle = (Rectangle)ShapeFactory.GetShapeObject( ShapeType.Rectangle );
                rectangle.SetColor( ShapeColor.White );
                rectangle.Draw();
            }

            for ( int i = 0; i < 5; i++ )
            {
                IShape square = (Square)ShapeFactory.GetShapeObject( ShapeType.Square );
                square.SetColor( ShapeColor.White );
                square.Draw();
            }

            Dictionary<ShapeType, IShape> shapeDict = ShapeFactory.GetDictionary();

            Assert.That( shapeDict.Count, Is.EqualTo( 4 ) );
        }
    }
}
