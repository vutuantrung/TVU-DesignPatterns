using Memento.LEDTV.Caretaker;
using Memento.LEDTV.Class;
using Memento.LEDTV.Memento;
using Memento.LEDTV.Originator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Memento
    {
        [Test]
        public void Test_TVLED()
        {
            CaretakerLEDTV storeRoom = new CaretakerLEDTV();

            TVLED tvLED27 = new TVLED( "27inch", "560.50e", false );

            OriginatorLEDTV originator = new OriginatorLEDTV();
            originator.TVLED = tvLED27;

            // New LEDTV 35 inch
            TVLED tvLED35 = new TVLED( "35inch", "845.00e", false );
            // Create new memento
            MementoLEDTV mementoLEDTV27 = originator.CreateMemento();
            // Stored memento into storeroom
            storeRoom.AddMemento( mementoLEDTV27 );
            // Set new TVLED
            originator.TVLED = tvLED35;

            // New LEDTV 50 inch
            TVLED tvLED50 = new TVLED( "50inch", "1200.50e", true );
            // Create new memento
            MementoLEDTV mementoLEDTV35 = originator.CreateMemento();
            // Stored memento into storeroom
            storeRoom.AddMemento( mementoLEDTV35 );
            // Set new TVLED
            originator.TVLED = tvLED50;
        }
    }
}
