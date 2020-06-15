using System;
using System.Collections.Generic;
using System.Text;

namespace State.BankCard.Class
{
    public class Server
    {
        private string ownerNameCard;
        private string cardNumber;
        private string pinCard;

        private string _ownerNameDB;
        private string _cardNumberDB;
        private string _pinDB;

        private int _moneyDB;

        public bool ValidInformation( string pin )
        {
            return _pinDB == pin;
        }

        public bool GetMoney( int amountOfMoney )
        {
            if ( amountOfMoney > _moneyDB ) return false;
            return true;
        }

        public void ReadInformationFromCard( Card card )
        {
            if ( card.OnwerName != _ownerNameDB ) throw new ArgumentException( "Card with this name does not exist in DB." );
            if ( card.CardNumber != _cardNumberDB ) throw new ArgumentException( "Card with this number does not exist in DB." );
        }

        public Server( Builder builder )
        {
            _moneyDB = builder.moneyDB;
            _pinDB = builder.pinDB;
            _ownerNameDB = builder.ownerNameDB;
            _cardNumberDB = builder.cardNumberDB;
        }

        public class Builder
        {
            public string ownerNameDB;

            public string cardNumberDB;

            public int moneyDB;

            public string pinDB;

            public Builder SetMoneyDB( int money )
            {
                this.moneyDB = money;
                return this;
            }

            public Builder SetPinDB( string pin )
            {
                this.pinDB = pin;
                return this;
            }

            public Builder SetCardNumberDB( string number )
            {
                this.cardNumberDB = number;
                return this;
            }

            public Builder SetOwnerNameDB( string name )
            {
                this.ownerNameDB = name;
                return this;
            }

            public Server Build()
            {
                return new Server( this );
            }
        }
    }
}
