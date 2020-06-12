using Observer.Product.Enum;
using Observer.Product.ProductObserver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Product.Subject
{
    public interface ISubject
    {
        void RegisterObserver( IProductObserver observer );
        void RemoveObserver( IProductObserver observer );
        void NotifyObservers( ObserverType observerType );
    }
}
