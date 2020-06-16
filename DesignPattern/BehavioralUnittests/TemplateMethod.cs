using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.BuildHouse.Class;
using TemplateMethod.BuildHouse.Enum;
using TemplateMethod.BuildHouse.Template;

namespace BehavioralUnittests
{
    [TestFixture]
    public class TemplateMethod
    {
        [Test]
        public void Test_house()
        {
            {
                House house = new House();
                HouseTemplate template = new NormalHouseBuild( house );
                template.BuildHouse();

                Assert.That( house.Foundation, Is.EqualTo( FoundationMaterial.Normal ) );
                Assert.That( house.Wall, Is.EqualTo( WallMaterial.Normal ) );
                Assert.That( house.Pillars, Is.EqualTo( PillarMaterial.Normal ) );
                Assert.That( house.Window, Is.EqualTo( WindowMaterial.Normal ) );
            }

            {
                House house = new House();
                HouseTemplate template = new WoodHouseBuild( house );
                template.BuildHouse();

                Assert.That( house.Foundation, Is.EqualTo( FoundationMaterial.Wood ) );
                Assert.That( house.Wall, Is.EqualTo( WallMaterial.Wood ) );
                Assert.That( house.Pillars, Is.EqualTo( PillarMaterial.Wood ) );
                Assert.That( house.Window, Is.EqualTo( WindowMaterial.Wood ) );
            }
        }
    }
}
