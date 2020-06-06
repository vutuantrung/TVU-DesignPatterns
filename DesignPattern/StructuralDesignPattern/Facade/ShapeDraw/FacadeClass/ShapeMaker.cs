using Facade.ShapeDraw.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ShapeDraw.FacadeClass
{
    public class ShapeMaker
    {
        private IShape _circle;
        private IShape _rectangle;
        private IShape _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }

        public bool IsCircleDrawn() => _circle.IsDrawn();
        public bool IsSquareDrawn() => _square.IsDrawn();
        public bool IsRectangleDrawn() => _rectangle.IsDrawn();
    }
}
