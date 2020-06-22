using Strategy.Travel.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Travel.StrategyTravel
{
    public class BusTravelStrategy : ITravelStrategy
    {
        Client _client;

        public BusTravelStrategy( Client client )
        {
            _client = client;
        }

        public void ToTheAirport()
        {
            _client.Paying( 300 );
        }
    }
}
