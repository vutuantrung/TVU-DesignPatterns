using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.ThreadSafeSingleton
{
    // The Lazy or Deferred Loading is a design pattern or you can say its a concept which is commonly used to delay the initialization of an object until the point at which it is needed.
    // So the main objective of Lazy loading is to load the object on-demand or you can say object when needed.
    // The most important point that you need to keep in mind is that, you need to use the Lazy loading when the cost of the object creation is very high as well as the use of that object is very rare.
    // The lazy loading improves the performance of an application if it is used properly. We can use the Lazy keyword to make the singleton instance as lazy loading. 
    public sealed class SingletonLazyLoading : ISingletonDemo
    {
        private static int _counter = 0;

        private SingletonLazyLoading()
        {
            _counter++;
            Console.WriteLine( $"Counter: { _counter }" );
        }

        private static readonly Lazy<SingletonLazyLoading> InstanceLock = new Lazy<SingletonLazyLoading>( () => new SingletonLazyLoading() );

        public static SingletonLazyLoading GetInstance
        {
            get
            {
                return InstanceLock.Value;
            }
        }

        public void PrintInformation( string message )
        {
            Console.WriteLine( message );
        }
    }
}
