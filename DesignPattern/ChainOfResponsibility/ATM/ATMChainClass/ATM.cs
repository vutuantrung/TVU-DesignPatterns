using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.MoneyAmountHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.ATMChainClass
{
    public class ATM
    {
        ICollector _moneyCollector = new MoneyCollector();

        private TwoThousandHandler _twoThousandHandler;
        private OneThousandHandler _oneThousandHandler;
        private FiveHundredHandler _fiveHundredHandler;
        private OneHundredHandler _oneHundredHandler;
        private FiftyHandler _fiftyHandler;
        private TenHandler _tenHandler;
        private OneHandler _oneHandler;
        
        public ATM()
        {
            _twoThousandHandler = new TwoThousandHandler(); _twoThousandHandler.SetCollector( _moneyCollector );
            _oneThousandHandler = new OneThousandHandler(); _oneThousandHandler.SetCollector( _moneyCollector );
            _fiveHundredHandler = new FiveHundredHandler(); _fiveHundredHandler.SetCollector( _moneyCollector );
            _oneHundredHandler = new OneHundredHandler(); _oneHundredHandler.SetCollector( _moneyCollector );
            _fiftyHandler = new FiftyHandler(); _fiftyHandler.SetCollector( _moneyCollector );
            _tenHandler = new TenHandler(); _tenHandler.SetCollector( _moneyCollector );
            _oneHandler = new OneHandler(); _oneHandler.SetCollector( _moneyCollector );

            _twoThousandHandler.SetNextHandler( _oneThousandHandler );
            _oneThousandHandler.SetNextHandler( _fiveHundredHandler );
            _fiveHundredHandler.SetNextHandler( _oneHundredHandler );
            _oneHundredHandler.SetNextHandler( _fiftyHandler );
            _fiftyHandler.SetNextHandler( _tenHandler );
            _tenHandler.SetNextHandler( _oneHandler );
            _oneHandler.SetNextHandler( null );
        }

        public void WithDrawMoney(double requestedAmount )
        {
            _twoThousandHandler.DispatchMoney( requestedAmount );
        }

        public ICollector GetListMoneyNote() => _moneyCollector;
    }
}
