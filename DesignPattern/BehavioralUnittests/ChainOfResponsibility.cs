using ChainOfResponsibility.ATM.ATMChainClass;
using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class ChainOfResponsibility
    {
        [Test]
        public void Test_ATM()
        {
            ATM atm = new ATM();

            {
                atm.WithDrawMoney( 2569.00 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 1 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 0 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 0 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 1 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 1 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 9 ) );
            }

            {
                atm.WithDrawMoney( 5946 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 2 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 1 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 4 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 0 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 4 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 6 ) );
            }

            {
                atm.WithDrawMoney( 12698 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 6 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 0 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 1 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 4 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 8 ) );
            }
        }
    }
}
