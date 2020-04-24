using FactoryMethod.Class;
using FactoryMethod.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class FactoryMethodTests
    {
        [Test]
        public void get_product_1()
        {
            var creator = new ConcreteCreator1();

            var product = creator.FactoryMethod();

            Assert.That( product.GetValue() == ProductTypes.ValueProduct1 );
        }

        [Test]
        public void get_product_2()
        {
            var creator = new ConcreteCreator2();

            var product = creator.FactoryMethod();

            Assert.That( product.GetValue() == ProductTypes.ValueProduct2 );
        }
    }
}
