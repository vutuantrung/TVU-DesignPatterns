﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.ShapeDraw.Class
{
    public class Circle : IShape
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