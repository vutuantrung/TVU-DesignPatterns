using Facade.ShapeDraw.FacadeClass;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralUnittests
{
    [TestFixture]
    class FacadeTests
    {
        [Test]
        public void test_shape_draw()
        {
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawSquare();
            shapeMaker.DrawRectangle();

            Assert.That( shapeMaker.IsCircleDrawn() == true );
            Assert.That( shapeMaker.IsSquareDrawn() == true );
            Assert.That( shapeMaker.IsRectangleDrawn() == true );
        }
    }
}
