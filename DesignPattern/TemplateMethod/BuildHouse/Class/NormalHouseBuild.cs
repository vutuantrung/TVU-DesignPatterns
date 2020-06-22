using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BuildHouse.Enum;
using TemplateMethod.BuildHouse.Template;

namespace TemplateMethod.BuildHouse.Class
{
    public class NormalHouseBuild : HouseTemplate
    {
        private House _house;

        public NormalHouseBuild(House house )
        {
            _house = house;
        }

        public override void BuildFoundation()
        {
            _house.Foundation = FoundationMaterial.Normal;
        }

        public override void BuildPillars()
        {
            _house.Pillars = PillarMaterial.Normal;
        }

        public override void BuildWalls()
        {
            _house.Wall = WallMaterial.Normal;
        }

        public override void BuildWindows()
        {
            _house.Window = WindowMaterial.Normal;
        }
    }
}
