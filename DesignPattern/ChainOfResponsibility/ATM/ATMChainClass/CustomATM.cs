using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using ChainOfResponsibility.ATM.MoneyAmountHandler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ATM.ATMChainClass
{
    public class CustomATM
    {
        ICollector _moneyCollector = new MoneyCollector();

        private MoneyHandler _twoThousandHandler;
        private MoneyHandler _oneThousandHandler;
        private MoneyHandler _fiveHundredHandler;
        private MoneyHandler _oneHundredHandler;
        private MoneyHandler _fiftyHandler;
        private MoneyHandler _tenHandler;
        private MoneyHandler _oneHandler;

        public CustomATM()
        {
            _oneHandler = new MoneyHandler.Builder().SetNextHandler( null )
                                                    .SetMoneyNote( MoneyNoteDenomination.One, 1 )
                                                    .SetCollector( _moneyCollector )
                                                    .Build();

            _tenHandler = new MoneyHandler.Builder().SetNextHandler( _oneHandler )
                                                    .SetMoneyNote( MoneyNoteDenomination.Ten, 10 )
                                                    .SetCollector( _moneyCollector )
                                                    .Build();

            _fiftyHandler = new MoneyHandler.Builder().SetNextHandler( _tenHandler )
                                                    .SetMoneyNote( MoneyNoteDenomination.Fifty, 50 )
                                                    .SetCollector( _moneyCollector )
                                                    .Build();

            _oneHundredHandler = new MoneyHandler.Builder().SetNextHandler( _fiftyHandler )
                                                           .SetMoneyNote( MoneyNoteDenomination.OneHundred, 100 )
                                                           .SetCollector( _moneyCollector )
                                                           .Build();

            _fiveHundredHandler = new MoneyHandler.Builder().SetNextHandler( _oneHundredHandler )
                                                            .SetMoneyNote( MoneyNoteDenomination.FiveHundred, 500 )
                                                            .SetCollector( _moneyCollector )
                                                            .Build();

            _oneThousandHandler = new MoneyHandler.Builder().SetNextHandler( _fiveHundredHandler )
                                                            .SetMoneyNote( MoneyNoteDenomination.OneThousand, 1000 )
                                                            .SetCollector( _moneyCollector )
                                                            .Build();

            _twoThousandHandler = new MoneyHandler.Builder().SetNextHandler( _oneThousandHandler )
                                                            .SetMoneyNote( MoneyNoteDenomination.TwoThousand, 2000 )
                                                            .SetCollector( _moneyCollector )
                                                            .Build();
        }

        public void WithDrawMoney( double requestedAmount )
        {
            _twoThousandHandler.DispatchMoney( requestedAmount );
        }

        public ICollector GetListMoneyNote() => _moneyCollector;
    }
}
