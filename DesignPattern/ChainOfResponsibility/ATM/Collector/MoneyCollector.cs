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
            return _listMoney.FirstOrDefault( s => s.Type == moneyNoteDenomination );
        }

        public int GetNumberNote()
        {
            int total = 0;

            foreach(MoneyNote note in _listMoney )
            {
                total += note.Count;
            }

            return total;
        }

        public List<MoneyNote> GetMoneyNoteList() => _listMoney;
    }
}
