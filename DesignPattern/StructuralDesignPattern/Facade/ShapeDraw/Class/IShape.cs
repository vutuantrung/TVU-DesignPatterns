using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ShapeDraw.Class
{
    public interface IShape
    {
        void Draw();
        bool IsDrawn();
    }
}
