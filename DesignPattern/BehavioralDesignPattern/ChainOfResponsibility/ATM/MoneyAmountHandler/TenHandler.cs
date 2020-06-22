using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class TenHandler : Handler
    {
        public TenHandler()
        {
            _moneyFix = 10;

            _moneyNote = new MoneyNote();
            _moneyNote.Type = MoneyNoteDenomination.Ten;
        }
    }
}
