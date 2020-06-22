using Strategy.Travel.Class;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Strategy.Travel.StrategyTravel
{
    public class AutoTravelStrategy : ITravelStrategy
    {
        Client _client;

        public AutoTravelStrategy( Client client )
        {
            _client = client;
        }

        public void ToTheAirport()
        {
            _client.Paying( 200 );
        }
    }
}
