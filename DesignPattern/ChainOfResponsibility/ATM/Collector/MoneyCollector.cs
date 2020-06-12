using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility.ATM.Collector
{
    public class MoneyCollector : ICollector
    {
        private List<MoneyNote> _listMoney = new List<MoneyNote>();

        public void AddMoneyNote( MoneyNote moneyNote )
        {
            _listMoney.Add( moneyNote );
        }

        public void Reset()
        {
            _listMoney = new List<MoneyNote>();
        }

        public MoneyNote GetMoneyNote( MoneyNoteDenomination moneyNoteDenomination )
        {
            return _listMoney.First( s => s.Type == moneyNoteDenomination );
        }

        public List<MoneyNote> GetMoneyNoteList() => _listMoney;
    }
}
