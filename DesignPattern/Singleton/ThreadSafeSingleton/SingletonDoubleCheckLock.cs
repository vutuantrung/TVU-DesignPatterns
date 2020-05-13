using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ThreadSafeSingleton
{
    //SingletonDoubleCheckLock
    // Double check locking
    public sealed class SingletonDoubleCheckLock : ISingletonDemo
    {
        private static int _counter = 0;

        private static readonly object _lock = new object();

        private static SingletonDoubleCheckLock _instance;

        public static SingletonDoubleCheckLock GetInstance
        {
            // Now, imagine that the program has just been launched. 
            // Since there's no Singleton instance yet, multiple threads can simultaneously pass the previous conditional and reach this point almost at the same time.
            // The first of them will acquire lock and will proceed further, while the rest will wait here.
            get
            {
                if ( _instance == null )
                {
                    lock ( _lock )
                    {
                        // The first thread to acquire the lock, reaches this conditional, goes inside and creates the Singleton instance.
                        // Once it leaves the lock block, a thread that might have been waiting for the lock release may then enter this section.
                        // But since the Singleton field is already initialized, the thread won't create a new object.
                        if ( _instance == null )
                        {
                            _instance = new SingletonDoubleCheckLock();
                        }
                    }
                }
                return _instance;
            }
        }

        private SingletonDoubleCheckLock()
        {
            _counter++;
            Console.WriteLine( $"Counter: { _counter }" );
        }

        public void PrintInformation( string message )
        {
            Console.WriteLine( message );
        }
    }
}
