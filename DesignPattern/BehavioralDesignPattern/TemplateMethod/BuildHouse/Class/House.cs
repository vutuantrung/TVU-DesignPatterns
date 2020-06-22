using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BuildHouse.Enum;

namespace TemplateMethod.BuildHouse.Class
{
    public class House
    {
        public FoundationMaterial Foundation { get; set; }

        public PillarMaterial Pillars { get; set; }

        public WallMaterial Wall { get; set; }

        public WindowMaterial Window { get; set; }
    }
}
