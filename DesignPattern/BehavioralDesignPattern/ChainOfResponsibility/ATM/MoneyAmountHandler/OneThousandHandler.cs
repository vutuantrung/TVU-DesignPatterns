using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class OneThousandHandler : Handler
    {
        public OneThousandHandler()
        {
            _moneyFix = 1000;

            _moneyNote = new MoneyNote();
            _moneyNote.Type = MoneyNoteDenomination.OneThousand;
        }
    }
}
