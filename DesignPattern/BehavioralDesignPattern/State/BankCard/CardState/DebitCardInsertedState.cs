using State.BankCard.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.BankCard.CardState
{
    public class DebitCardInsertedState : ATMState
    {
        private Server _server;

        public DebitCardInsertedState( Server server )
        {
            _server = server;
        }

        public void EjectDebitCard()
        {
            _server = null;
        }

        public bool EnterPin( string pin )
        {
            return _server.ValidInformation( pin );
        }

        public void InsertDebitCard( Card card )
        {
            throw new InvalidOperationException( "Card already in machine, can not insert more than 1 card." );
        }

        public bool WithdrawMoney( int amountOfMoney )
        {
            return _server.GetMoney( amountOfMoney );
        }
    }
}
