using Facade.ShapeDraw.FacadeClass;
using Facade.System.Class;
using Facade.System.FacadeClass;
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

        [Test]
        public void test_systems()
        {
            SubSystem1 subsystem1 = new SubSystem1();
            SubSystem2 subsystem2 = new SubSystem2();

            SystemController controller = new SystemController( subsystem1, subsystem2 );

            controller.Operation();

            Assert.That( subsystem1.IsSubSystemReady == true );
            Assert.That( subsystem2.IsSubSystemReady == true );

            Assert.That( subsystem1.IsSubSystemWorking == true );
            Assert.That( subsystem2.IsSubSystemWorking == true );
        }
    }
}
