using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class OneHundredHandler : Handler
    {
        public OneHundredHandler()
        {
            _moneyFix = 100;

            _moneyNote = new MoneyNote();
            _moneyNote.Type = MoneyNoteDenomination.OneHundred;
        }
    }
}
