using State.BankCard.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace State.BankCard.CardState
{
    public interface ATMState
    {
        void InsertDebitCard( Card card );
        void EjectDebitCard();
        bool EnterPin( string pin );
        bool WithdrawMoney( int amountOfMoney );
    }
}
