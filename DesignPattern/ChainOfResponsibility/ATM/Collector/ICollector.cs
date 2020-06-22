using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.Collector
{
    public interface ICollector
    {
        void AddMoneyNote( MoneyNote moneyNote );

        List<MoneyNote> GetMoneyNoteList();

        MoneyNote GetMoneyNote( MoneyNoteDenomination moneyNoteDenomination );

        int GetNumberNote();
    }
}
