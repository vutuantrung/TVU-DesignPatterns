using System;
using System.Collections.Generic;
using System.Text;

namespace FluentInterface.Class
{
    public class Client
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ZipCode { get; set; }

        public double _myWallet;

        public double MyWallet
        {
            get
            {
                return _myWallet;
            }
            set
            {
                _myWallet = value;
            }
        }

        public string Town { get; set; }

        public string Street { get; set; }

        public int HomeNumber { get; set; }

        public Client( Builder builder )
        {
            FirstName = builder.firstName;
            LastName = builder.lastName;
            ZipCode = builder.zipCode;
            _myWallet = builder.myWallet;
            Town = builder.town;
            Street = builder.street;
            HomeNumber = builder.homeNumber;
        }

        public class Builder
        {
            public string firstName;

            public string lastName;

            public string zipCode;

            public double myWallet;

            public string town;

            public string street;

            public int homeNumber;

            public Builder FirstName( string firstName )
            {
                this.firstName = firstName;
                return this;
            }

            public Builder LastName( string lastName )
            {
                this.lastName = lastName;
                return this;
            }

            public Builder ZipCode( string zipCode )
            {
                this.zipCode = zipCode;
                return this;
            }

            public Builder MyWallet( double myWallet )
            {
                this.myWallet = myWallet;
                return this;
            }

            public Builder Town( string town )
            {
                this.town = town;
                return this;
            }

            public Builder Street( string street )
            {
                this.street = street;
                return this;
            }

            public Builder HomeNumber( int homeNumber )
            {
                this.homeNumber = homeNumber;
                return this;
            }

            public Client Build()
            {
                return new Client( this );
            }
        }
    }
}
