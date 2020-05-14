using Singleton.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.NaiveSingleton
{
    public sealed class SingletonCounter : ISingletonDemo
    {
        private static int _counter = 0;

        private static SingletonCounter instance = null;

        // Using Lazy Initialization
        public static SingletonCounter GetInstance
        {
            get
            {
                if ( instance == null )
                {
                    instance = new SingletonCounter();
                }

                return instance;
            }
        }

        public void PrintInformation( string message )
        {
            Console.WriteLine( message );
        }

        private SingletonCounter()
        {
            _counter++;
            Console.WriteLine( $"Counter: { _counter }" );
        }
    }
}
