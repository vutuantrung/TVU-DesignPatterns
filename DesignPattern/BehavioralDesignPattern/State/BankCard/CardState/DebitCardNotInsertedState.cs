using State.BankCard.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.BankCard.CardState
{
    public class DebitCardNotInsertedState : ATMState
    {
        private Server _server;

        public void EjectDebitCard()
        {
            throw new InvalidOperationException( "Card not found, can not eject card." );
        }

        public bool EnterPin( string pin )
        {
            throw new InvalidOperationException( "Card not found, can not enter pin." );
        }

        public void InsertDebitCard( Card card )
        {

        }

        public bool WithdrawMoney( int amountOfMoney )
        {
            throw new InvalidOperationException( "Card not found, can not withdraw money." );
        }
    }
}
