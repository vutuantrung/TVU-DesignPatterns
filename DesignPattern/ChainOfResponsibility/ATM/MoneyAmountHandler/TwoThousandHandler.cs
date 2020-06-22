using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class TwoThousandHandler : Handler
    {
        public TwoThousandHandler()
        {
            _moneyFix = 2000;

            _moneyNote = new MoneyNote();
            _moneyNote.Type = MoneyNoteDenomination.TwoThousand;
        }
    }
}
