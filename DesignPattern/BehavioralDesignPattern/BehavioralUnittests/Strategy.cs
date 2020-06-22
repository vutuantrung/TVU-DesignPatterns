using NUnit.Framework;
using Strategy.Compression.Class;
using Strategy.Compression.Enum;
using Strategy.Compression.StrategyCompression;
using Strategy.Shopping.Class;
using Strategy.Shopping.StrategyShopping;
using Strategy.Travel.Class;
using Strategy.Travel.StrategyTravel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Strategy
    {
        [Test]
        public void Test_Compression()
        {
            File file = new File { Comporession = CompressionType.None, FileName = "testingCompressionFile" };

            ZIPCompression zipCompression = new ZIPCompression();
            CompressionContext context = new CompressionContext( zipCompression );

            context.CreateArchive( file );

            Assert.That( file.Comporession, Is.EqualTo( CompressionType.Zip ) );

            RARCompression rarCompression = new RARCompression();
            context.SetStrategy( rarCompression );

            context.CreateArchive( file );

            Assert.That( file.Comporession, Is.EqualTo( CompressionType.Rar ) );
        }

        [Test]
        public void Test_Travel()
        {
            {
                Client client = new Client( 1000 );
                AutoTravelStrategy strategy = new AutoTravelStrategy( client );
                strategy.ToTheAirport();

                Assert.That( client.Money, Is.EqualTo( 800 ) );
            }

            {
                Client client = new Client( 1000 );
                BusTravelStrategy strategy = new BusTravelStrategy( client );
                strategy.ToTheAirport();

                Assert.That( client.Money, Is.EqualTo( 700 ) );
            }

            {
                Client client = new Client( 1000 );
                TaxiTravelStrategy strategy = new TaxiTravelStrategy( client );
                strategy.ToTheAirport();

                Assert.That( client.Money, Is.EqualTo( 750 ) );
            }

            {
                Client client = new Client( 1000 );
                TrainTravelStrategy strategy = new TrainTravelStrategy( client );
                strategy.ToTheAirport();

                Assert.That( client.Money, Is.EqualTo( 650 ) );
            }
        }

        [Test]
        public void Test_Payment()
        {
            IPaymentStrategy paymentStrategy = new DebitCardPaymentStrategy();
            PaymentContext paymentContext = new PaymentContext( paymentStrategy );
            paymentContext.Pay( 135.1 );

            paymentStrategy = new CashCardPaymentStrategy();
            paymentContext.SetPaymentStrategy( paymentStrategy );
            paymentContext.Pay( 57.1 );

            paymentStrategy = new CreditCardPaymentStrategy();
            paymentContext.SetPaymentStrategy( paymentStrategy );
            paymentContext.Pay( 45.96 );
        }

    }
}
