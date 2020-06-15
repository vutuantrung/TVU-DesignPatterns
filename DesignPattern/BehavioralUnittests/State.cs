using NUnit.Framework;
using State.BankCard.Class;
using State.Demo.Class;
using State.Demo.ClassState;
using State.Demo.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class State
    {
        [Test]
        public void Test_bank_card()
        {
            Server server = new Server.Builder().SetCardNumberDB( "9856 4587 5656 2325" )
                                                .SetOwnerNameDB( "John Smith" )
                                                .SetMoneyDB( 100000 )
                                                .SetPinDB( "6981" )
                                                .Build();

            ATMMachine machine = new ATMMachine( server );

            Card cardA = new Card { CardNumber = "9856 4587 5656 2325", OnwerName = "John Smith" };
            Card cardB = new Card { CardNumber = "9476 4587 1666 2345", OnwerName = "John Smith" };
            Card cardC = new Card { CardNumber = "9856 4587 5656 2325", OnwerName = "Mary Smith" };

            {
                machine.InsertDebitCard( card: cardA );

                Assert.That( machine.EnterPin( "6981" ), Is.EqualTo( true ) );
                Assert.That( machine.WithdrawMoney( 5000 ), Is.EqualTo( true ) );
                Assert.That( machine.WithdrawMoney( 200000 ), Is.EqualTo( false ) );

                Assert.Throws<InvalidOperationException>( () => machine.InsertDebitCard( card: cardA ), "Card already in machine, can not insert more than 1 card." );

                machine.EjectDebitCard();

                Assert.Throws<InvalidOperationException>( () => machine.EnterPin( "15354" ), "Card not found, can not enter pin." );
                Assert.Throws<InvalidOperationException>( () => machine.EjectDebitCard(), "Card not found, can not eject card." );
            }

            {
                Assert.Throws<ArgumentException>( () => machine.InsertDebitCard( card: cardB ), "Card with this number does not exist in DB." );
            }

            {
                Assert.Throws<ArgumentException>( () => machine.InsertDebitCard( card: cardC ), "Card with this name does not exist in DB." );
            }
        }

        [Test]
        public void Test_demo()
        {
            Record record = new Record();

            StateA stateA = new StateA();
            StateB stateB = new StateB();

            DemoContext context = new DemoContext( stateA );

            {
                context.RequestA( record );
                Assert.That( record.HandlerType, Is.EqualTo( HandlerType.A ) );
                Assert.That( record.StateType, Is.EqualTo( StateType.A ) );
            }
            {
                context.RequestB( record );
                Assert.That( record.HandlerType, Is.EqualTo( HandlerType.B ) );
                Assert.That( record.StateType, Is.EqualTo( StateType.A ) );
            }

            context.TransitorTo( stateB );

            {
                context.RequestA( record );
                Assert.That( record.HandlerType, Is.EqualTo( HandlerType.A ) );
                Assert.That( record.StateType, Is.EqualTo( StateType.B ) );
            }
            {
                context.RequestB( record );
                Assert.That( record.HandlerType, Is.EqualTo( HandlerType.B ) );
                Assert.That( record.StateType, Is.EqualTo( StateType.B ) );
            }

        }
    }
}
