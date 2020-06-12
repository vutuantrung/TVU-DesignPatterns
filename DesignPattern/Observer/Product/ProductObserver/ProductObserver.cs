using Observer.Product.Enum;
using Observer.Product.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Product.ProductObserver
{
    public class ProductObserver : IProductObserver
    {
        public string MessageReceived { get; set; }

        public Availability Availability { get; set; }

        public string Username { get; set; }

        public ProductObserver( string userName, ISubject subject )
        {
            Username = userName;
            subject.RegisterObserver( this );
        }

        public void UpdateAvailability( Availability availability )
        {
            if ( availability == Availability.Available )
            {
                DisplayMessage( "We are happy to inform you that your product is now avaible." );
            }
            else
            {
                DisplayMessage( "We are very sorry to inform you that our product is now unavaible." );
            }
        }

        public void UpdatePromotion( double promotionPrice )
        {
            DisplayMessage( $"Ours products is now in promotion with a new price { promotionPrice }" );
        }

        public void DisplayMessage( string message )
        {
            MessageReceived = message;
            Console.WriteLine( message );
        }
    }
}
