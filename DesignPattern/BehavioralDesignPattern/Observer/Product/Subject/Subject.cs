using Observer.Product.Enum;
using Observer.Product.ProductObserver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Product.Subject
{
    public class Subject : ISubject
    {
        private List<IProductObserver> _observers = new List<IProductObserver>();

        private ProductType _productType;

        private double _productPrice;

        private Availability _availability;

        public Subject( ProductType productType, double productPrice, Availability availability )
        {
            _productType = productType;
            _productPrice = productPrice;
            _availability = availability;
        }

        public Availability Availability => _availability;

        public ProductType ProductName => _productType;

        public double ProductPrice => _productPrice;

        public void SetAvailability( Availability availability )
        {
            _availability = availability;
            NotifyObservers( ObserverType.Availability );
        }

        public void SetPromotion( double promotionPrice )
        {
            _productPrice -= promotionPrice;
            NotifyObservers( ObserverType.Promotion );
        }

        public void NotifyObservers( ObserverType observerType )
        {
            if( observerType == ObserverType.Availability )
            {
                foreach ( IProductObserver observer in _observers )
                {
                    observer.UpdateAvailability( _availability );
                }
            }
            else
            {
                foreach ( IProductObserver observer in _observers )
                {
                    observer.UpdatePromotion( _productPrice );
                }
            }
        }

        public void RegisterObserver( IProductObserver observer )
        {
            if ( observer == null ) throw new ArgumentNullException( nameof( observer ) );
            _observers.Add( observer );
        }

        public void RemoveObserver( IProductObserver observer )
        {
            if ( observer == null ) throw new ArgumentNullException( nameof( observer ) );
            _observers.Remove( observer );
        }
    }
}
