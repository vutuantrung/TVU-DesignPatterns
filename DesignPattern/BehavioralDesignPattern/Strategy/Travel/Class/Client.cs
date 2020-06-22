using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Travel.Class
{
    public class Client
    {
        private int _money;

        public int Money => _money;

        public Client( int money )
        {
            _money = money;
        }

        public void Paying( int money )
        {
            if ( money > _money ) throw new InvalidOperationException( "Can not pay." );
            _money -= money;
        }
    }
}
