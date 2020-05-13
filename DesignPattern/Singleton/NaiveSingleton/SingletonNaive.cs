using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NaiveSingleton
{
    public class SingletonNaive : ISingletonDemo
    {
        // The Singleton's constructor should always be private to prevent direct construction calls with the `new` operator.
        private SingletonNaive()
        {

        }

        private static SingletonNaive _instance;

        public static SingletonNaive GetInstance()
        {
            if ( _instance == null )
            {
                _instance = new SingletonNaive();
            }

            return _instance;
        }

        public void PrintInformation( string message )
        {
            Console.WriteLine( message );
        }
    }
}
