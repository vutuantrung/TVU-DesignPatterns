using FactoryDesign.Card;
using FactoryDesign.Enum;
using FactoryDesign.Factory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class FactoryDesignTests
    {
        [Test]
        public void test_credit_card()
        {
            // MoneyBack card
            {
                CreditCard creditCard = CreditCardFactory.GetCreditCard( CreditCardType.MoneyBack );

                Assert.That( creditCard.GetCardType() == CreditCardType.MoneyBack );
                Assert.That( creditCard.GetAnnualCharge() == 20000 );
                Assert.That( creditCard.GetCreditLimit() == 1000 );
            }

            // Platium card
            {
                CreditCard creditCard = CreditCardFactory.GetCreditCard( CreditCardType.Platium );

                Assert.That( creditCard.GetCardType() == CreditCardType.Platium );
                Assert.That( creditCard.GetAnnualCharge() == 30000 );
                Assert.That( creditCard.GetCreditLimit() == 1500 );
            }

            // Titanium card
            {
                CreditCard creditCard = CreditCardFactory.GetCreditCard( CreditCardType.Titanium );

                Assert.That( creditCard.GetCardType() == CreditCardType.Titanium );
                Assert.That( creditCard.GetAnnualCharge() == 35000 );
                Assert.That( creditCard.GetCreditLimit() == 2000 );
            }
        }
    }
}
