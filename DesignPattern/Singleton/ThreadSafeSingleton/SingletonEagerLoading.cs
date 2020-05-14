using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ThreadSafeSingleton
{
    // The Eager loading in singleton design pattern is nothing a process in which we need to initialize the singleton object at the time of application start-up 
    // rather than on-demand and keep it ready in memory to be used in the future.
    // The advantage of using Eager Loading in the Singleton design pattern is that the CLR (Common Language Runtime) will take care of object initialization and thread-safety.
    // That means we will not require to write any code explicitly for handling the thread-safety for a multithreaded environment.
    public sealed class SingletonEagerLoading : ISingletonDemo
    {
        private static int _counter = 0;

        private SingletonEagerLoading()
        {
            _counter++;
            Console.WriteLine( $"Counter: { _counter }" );
        }

        // This line will create the instance at the time of application startup.
        private static readonly SingletonEagerLoading _singletonInstance = new SingletonEagerLoading();

        public static SingletonEagerLoading GetInstance
        {
            get
            {
                return _singletonInstance;
            }
        }

        public void PrintInformation( string message )
        {
            Console.WriteLine( message );
        }
    }
}
