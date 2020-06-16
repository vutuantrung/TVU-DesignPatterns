using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BuildHouse.Enum;
using TemplateMethod.BuildHouse.Template;

namespace TemplateMethod.BuildHouse.Class
{
    public class WoodHouseBuild : HouseTemplate
    {
        private House _house;

        public WoodHouseBuild( House house )
        {
            _house = house;
        }

        public override void BuildFoundation()
        {
            _house.Foundation = FoundationMaterial.Wood;
        }

        public override void BuildPillars()
        {
            _house.Pillars = PillarMaterial.Wood;
        }

        public override void BuildWalls()
        {
            _house.Wall = WallMaterial.Wood;
        }

        public override void BuildWindows()
        {
            _house.Window = WindowMaterial.Wood;
        }
    }
}
