using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class FiveHundredHandler : Handler
    {
        public FiveHundredHandler()
        {
            _moneyFix = 500;

            _moneyNote = new MoneyNote();
            _moneyNote.Type = MoneyNoteDenomination.FiveHundred;
        }
    }
}
