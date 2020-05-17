using FactoryMethod.Class;
using FactoryMethod.CreditCard.Card;
using FactoryMethod.CreditCard.Enum;
using FactoryMethod.CreditCard.Factory;
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

        [Test]
        public void test_credit_card()
        {
            // MoneyBack card
            {
                ICreditCard creditCard = new MoneyBackFactory().CreateProduct();

                Assert.That( creditCard.GetCardType() == CreditCardType.MoneyBack );
                Assert.That( creditCard.GetAnnualCharge() == 500 );
                Assert.That( creditCard.GetCreditLimit() == 15000 );
            }

            // Platium card
            {
                ICreditCard creditCard = new PlatiumFactory().CreateProduct();

                Assert.That( creditCard.GetCardType() == CreditCardType.Platium );
                Assert.That( creditCard.GetAnnualCharge() == 2000 );
                Assert.That( creditCard.GetCreditLimit() == 35000 );
            }

            // Titanium card
            {
                ICreditCard creditCard = new TitaniumFactory().CreateProduct();

                Assert.That( creditCard.GetCardType() == CreditCardType.Titanium );
                Assert.That( creditCard.GetAnnualCharge() == 1500 );
                Assert.That( creditCard.GetCreditLimit() == 25000 );
            }
        }
    }
}
