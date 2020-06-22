using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.BuildHouse.Template
{
    public abstract class HouseTemplate
    {
        public void BuildHouse()
        {
            BuildFoundation();
            BuildPillars();
            BuildWalls();
            BuildWindows();
        }

        public abstract void BuildFoundation();
        public abstract void BuildPillars();
        public abstract void BuildWalls();
        public abstract void BuildWindows();

    }
}
