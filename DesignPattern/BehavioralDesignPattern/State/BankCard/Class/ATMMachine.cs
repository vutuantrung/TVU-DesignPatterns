using State.BankCard.CardState;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.BankCard.Class
{
    public class ATMMachine : ATMState
    {
        private Server _server;

        private Card _cardInserted;

        public ATMState _atmMachineState { get; set; }

        public ATMMachine( Server server )
        {
            _server = server;
            _cardInserted = null;
            _atmMachineState = new DebitCardNotInsertedState();
        }

        public void InsertDebitCard( Card card )
        {
            _cardInserted = card;
            _server.ReadInformationFromCard( card );
            _atmMachineState.InsertDebitCard( card );

            if ( _atmMachineState is DebitCardNotInsertedState )
            {
                _atmMachineState = new DebitCardInsertedState( _server );
            }
        }

        public void EjectDebitCard()
        {
            _atmMachineState.EjectDebitCard();
            _cardInserted = null;

            if ( _atmMachineState is DebitCardInsertedState )
            {
                _atmMachineState = new DebitCardNotInsertedState();
            }
        }

        public bool EnterPin( string pin )
        {
            return _atmMachineState.EnterPin( pin );
        }

        public bool WithdrawMoney( int amountOfMoney )
        {
            return _atmMachineState.WithdrawMoney( amountOfMoney );
        }

        public Card InsertedCard => _cardInserted;
    }
}
