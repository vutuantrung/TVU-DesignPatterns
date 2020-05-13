using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NaiveSingleton
{
    public sealed class SingletonNaive : ISingletonDemo
    {
        private static int _counter = 0;

        private static SingletonNaive _instance = null;

        // The Singleton's constructor should always be private to prevent direct construction calls with the `new` operator.
        private SingletonNaive()
        {
            _counter++;
            Console.WriteLine( $"Counter: { _counter }" );
        }

        public static SingletonNaive GetInstance
        {
            get
            {
                if ( _instance == null )
                {
                    _instance = new SingletonNaive();
                }
                return _instance;
            }

        }

        public void PrintInformation( string message )
        {
            Console.WriteLine( message );
        }
    }
}
