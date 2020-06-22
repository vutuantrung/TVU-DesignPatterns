using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class FiftyHandler : Handler
    {
        public FiftyHandler()
        {
            _moneyFix = 50;

            _moneyNote = new MoneyNote();
            _moneyNote.Type = MoneyNoteDenomination.Fifty;
        }
    }
}
