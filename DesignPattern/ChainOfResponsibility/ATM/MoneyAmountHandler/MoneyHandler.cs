using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.MoneyAmountHandler
{
    public class MoneyHandler
    {
        private MoneyNote _moneyNote;

        private ICollector _collector;

        private MoneyHandler _nextHandler;

        public MoneyHandler( Builder builder )
        {
            _moneyNote = new MoneyNote();

            _collector = builder.collector;
            _nextHandler = builder.nextHandler;
            _moneyNote = builder.moneyNote;
        }

        public class Builder
        {
            public MoneyNote moneyNote;

            public MoneyHandler nextHandler;

            public ICollector collector;

            public Builder SetNextHandler( MoneyHandler nextHandler )
            {
                this.nextHandler = nextHandler;
                return this;
            }

            public Builder SetMoneyNote( MoneyNoteDenomination denomination, int moneyFix )
            {
                if(this.moneyNote == null) this.moneyNote = new MoneyNote();

                this.moneyNote.MoneyFix = moneyFix;
                this.moneyNote.Type = denomination;

                if ( canAddMoneyNote() ) this.collector.AddMoneyNote( this.moneyNote );

                return this;
            }

            public Builder SetCollector( ICollector collector )
            {
                if ( collector == null ) throw new ArgumentNullException( nameof( collector ) );

                this.collector = collector;
                if ( canAddMoneyNote() ) this.collector.AddMoneyNote( this.moneyNote );

                return this;
            }

            public MoneyHandler Build()
            {
                return new MoneyHandler( this );
            }

            private bool canAddMoneyNote()
            {
                if ( this.collector == null ) return false;
                if ( this.moneyNote == null ) return false;
                if ( collector.GetMoneyNote( this.moneyNote.Type ) != null ) return false;

                return true;
            }
        }

        public void DispatchMoney( double requestAmount )
        {
            int numberOfNotes = (int)requestAmount / _moneyNote.MoneyFix;
            double pendingAmount = (double)requestAmount % _moneyNote.MoneyFix;

            _moneyNote.Count = numberOfNotes;

            if ( pendingAmount > 0 )
            {
                _nextHandler.DispatchMoney( pendingAmount );
            }
        }
    }
}
