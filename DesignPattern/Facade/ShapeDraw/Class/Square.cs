using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ShapeDraw.Class
{
    public class Square : IShape
    {
        bool _isDrawn;

        public void Draw()
        {
            _isDrawn = true;
        }

        public bool IsDrawn()
        {
            return _isDrawn;
        }
    }
}
