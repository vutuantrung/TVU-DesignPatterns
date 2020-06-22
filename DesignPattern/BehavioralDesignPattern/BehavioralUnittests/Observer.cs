using NUnit.Framework;
using Observer.Product.Enum;
using Observer.Product.ProductObserver;
using Observer.Product.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Observer
    {
        [Test]
        public void Test_product()
        {
            var mobileProduct = new Subject( ProductType.MobilePhone, 565.50, Availability.OutOfStock );
            var latopProduct = new Subject( ProductType.Laptop, 1250.30, Availability.OutOfStock );

            var client1 = new ProductObserver( "Anurag", mobileProduct );
            var client2 = new ProductObserver( "Pranaya", mobileProduct );
            var client3 = new ProductObserver( "Priyanka", mobileProduct );

            mobileProduct.SetAvailability( Availability.Available );

            Assert.That( client1.MessageReceived == "We are happy to inform you that your product is now avaible." );
            Assert.That( client2.MessageReceived == "We are happy to inform you that your product is now avaible." );
            Assert.That( client3.MessageReceived == "We are happy to inform you that your product is now avaible." );

            mobileProduct.SetAvailability( Availability.OutOfStock );

            Assert.That( client1.MessageReceived == "We are very sorry to inform you that our product is now unavaible." );
            Assert.That( client2.MessageReceived == "We are very sorry to inform you that our product is now unavaible." );
            Assert.That( client3.MessageReceived == "We are very sorry to inform you that our product is now unavaible." );

            var client4 = new ProductObserver( "Torung", latopProduct );
            var client5 = new ProductObserver( "John", latopProduct );

            latopProduct.SetPromotion( 200.00 );

            Assert.That( client4.MessageReceived == $"Ours products is now in promotion with a new price { latopProduct.ProductPrice }" );
            Assert.That( client5.MessageReceived == $"Ours products is now in promotion with a new price { latopProduct.ProductPrice }" );
        }
    }
}
