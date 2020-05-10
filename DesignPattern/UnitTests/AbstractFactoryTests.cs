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
                IAbstractProductA prod = GetProduct( factory: new ConcreteFactory1() );

                Assert.That( prod.GetValue() == ProductEnum.ProductA1 );
            }

            {
                IAbstractProductA prod = GetProduct( factory: new ConcreteFactory2() );

                Assert.That( prod.GetValue() == ProductEnum.ProductA2 );
            }

            IAbstractProductA GetProduct( IAbstractFactory factory ) => factory.CreateProductA();
        }

        [Test]
        public void get_product_B()
        {
            {

                IAbstractProductB prod = GetProduct( factory: new ConcreteFactory1() );

                Assert.That( prod.GetValue() == ProductEnum.ProductB1 );
            }

            {
                IAbstractProductB prod = GetProduct( factory: new ConcreteFactory2() );

                Assert.That( prod.GetValue() == ProductEnum.ProductB2 );
            }

            IAbstractProductB GetProduct( IAbstractFactory factory ) => factory.CreateProductB();
        }

    }
}
