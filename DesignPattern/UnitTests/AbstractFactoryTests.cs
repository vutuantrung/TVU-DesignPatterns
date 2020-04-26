using FactoryAbstract.Factory;
using FactoryAbstract.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class AbstractFactoryTests
    {
        [Test]
        public void get_product_A()
        {
            {
                ConcreteFactory1 Factory = new ConcreteFactory1();

                IAbstractProductA Product = Factory.CreateProductA();

                Assert.That( Product.GetValue() == ProductsType.ProductA1 );
            }

            {
                ConcreteFactory2 Factory = new ConcreteFactory2();

                IAbstractProductA Product = Factory.CreateProductA();

                Assert.That( Product.GetValue() == ProductsType.ProductA2 );
            }
        }

        [Test]
        public void get_product_B()
        {
            {
                ConcreteFactory1 Factory = new ConcreteFactory1();

                IAbstractProductB Product = Factory.CreateProductB();

                Assert.That( Product.GetValue() == ProductsType.ProductB1 );
            }

            {
                ConcreteFactory2 Factory = new ConcreteFactory2();

                IAbstractProductB Product = Factory.CreateProductB();

                Assert.That( Product.GetValue() == ProductsType.ProductB2 );
            }
        }

    }
}
