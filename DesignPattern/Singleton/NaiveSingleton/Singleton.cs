using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NaiveSingleton
{
    public class Singleton
    {
        // The Singleton's constructor should always be private to prevent direct construction calls with the `new` operator.
        private Singleton()
        {

        }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if ( _instance == null )
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }
}
