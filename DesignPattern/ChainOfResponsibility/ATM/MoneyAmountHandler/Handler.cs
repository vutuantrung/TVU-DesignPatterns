using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public abstract class Handler
    {
        protected ICollector _collector;

        protected int _moneyFix;

        protected MoneyNote _moneyNote;

        protected Handler _nextHandler;

        public void SetNextHandler( Handler nextHandler )
        {
            _nextHandler = nextHandler;
        }

        public void SetCollector( ICollector collector )
        {
            _collector = collector;
            _collector.AddMoneyNote( _moneyNote );
        }

        public void DispatchMoney( double requestAmount )
        {
            int numberOfNotes = (int)requestAmount / _moneyFix;
            double pendingAmount = (double)requestAmount % _moneyFix;

            _moneyNote.Count = numberOfNotes;

            if ( pendingAmount > 0 )
            {
                _nextHandler.DispatchMoney( pendingAmount );
            }
        }
    }
}
