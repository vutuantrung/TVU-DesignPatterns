using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class OneHandler : Handler
    {
        public OneHandler()
        {
            _moneyFix = 1;

            _moneyNote = new MoneyNote();
            _moneyNote.Type = MoneyNoteDenomination.One;
        }
    }
}
