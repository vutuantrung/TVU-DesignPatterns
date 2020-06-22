using ChainOfResponsibility.ATM.ATMChainClass;
using ChainOfResponsibility.ATM.Collector;
using ChainOfResponsibility.ATM.Enum;
using ChainOfResponsibility.Reporting.Class;
using ChainOfResponsibility.Reporting.Enum;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class ChainOfResponsibility
    {
        [Test]
        public void Test_ATM()
        {
            ATM atm = new ATM();

            {
                atm.WithDrawMoney( 2569.00 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );
                Assert.That( moneyNoteList.GetNumberNote(), Is.EqualTo( 13 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 1 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 0 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 0 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 1 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 1 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 9 ) );
            }

            {
                atm.WithDrawMoney( 5946 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );
                Assert.That( moneyNoteList.GetNumberNote(), Is.EqualTo( 18 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 2 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 1 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 4 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 0 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 4 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 6 ) );
            }

            {
                atm.WithDrawMoney( 12698 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );
                Assert.That( moneyNoteList.GetNumberNote(), Is.EqualTo( 21 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 6 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 0 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 1 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 4 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 8 ) );
            }
        }

        [Test]
        public void Test_ATM_money_handler()
        {
            CustomATM atm = new CustomATM();

            {
                atm.WithDrawMoney( 2569.00 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );
                Assert.That( moneyNoteList.GetNumberNote(), Is.EqualTo( 13 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 1 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 0 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 0 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 1 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 1 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 9 ) );
            }

            {
                atm.WithDrawMoney( 5946 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );
                Assert.That( moneyNoteList.GetNumberNote(), Is.EqualTo( 18 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 2 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 1 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 4 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 0 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 4 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 6 ) );
            }

            {
                atm.WithDrawMoney( 12698 );
                var moneyNoteList = atm.GetListMoneyNote();

                Assert.That( moneyNoteList.GetMoneyNoteList().Count, Is.EqualTo( 7 ) );
                Assert.That( moneyNoteList.GetNumberNote(), Is.EqualTo( 21 ) );

                var collection = atm.GetListMoneyNote();

                MoneyNote twoThousand = collection.GetMoneyNote( MoneyNoteDenomination.TwoThousand );
                Assert.That( twoThousand.Count, Is.EqualTo( 6 ) );

                MoneyNote oneThousand = collection.GetMoneyNote( MoneyNoteDenomination.OneThousand );
                Assert.That( oneThousand.Count, Is.EqualTo( 0 ) );

                MoneyNote fiveHundred = collection.GetMoneyNote( MoneyNoteDenomination.FiveHundred );
                Assert.That( fiveHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote oneHundred = collection.GetMoneyNote( MoneyNoteDenomination.OneHundred );
                Assert.That( oneHundred.Count, Is.EqualTo( 1 ) );

                MoneyNote fifty = collection.GetMoneyNote( MoneyNoteDenomination.Fifty );
                Assert.That( fifty.Count, Is.EqualTo( 1 ) );

                MoneyNote ten = collection.GetMoneyNote( MoneyNoteDenomination.Ten );
                Assert.That( ten.Count, Is.EqualTo( 4 ) );

                MoneyNote one = collection.GetMoneyNote( MoneyNoteDenomination.One );
                Assert.That( one.Count, Is.EqualTo( 8 ) );
            }
        }

        [Test]
        public void Test_reporting()
        {
            LeavingRecording recordA = new LeavingRecording { EmployeeName = "Mr.A", IsApproved = false, NumberOfDaysLeave = 9, SectionDecided = SectionType.Developer };
            LeavingRecording recordB = new LeavingRecording { EmployeeName = "Mss.B", IsApproved = false, NumberOfDaysLeave = 12, SectionDecided = SectionType.Developer };
            LeavingRecording recordC = new LeavingRecording { EmployeeName = "Mr.C", IsApproved = false, NumberOfDaysLeave = 30, SectionDecided = SectionType.Developer };
            LeavingRecording recordD = new LeavingRecording { EmployeeName = "Mrs.D", IsApproved = false, NumberOfDaysLeave = 50, SectionDecided = SectionType.Developer };
            LeavingRecording recordE = new LeavingRecording { EmployeeName = "Mss.E", IsApproved = false, NumberOfDaysLeave = 44, SectionDecided = SectionType.Developer };

            ReportingSection reportingSection = new ReportingSection();

            reportingSection.ApproveLeavingRecord( recordA );
            reportingSection.ApproveLeavingRecord( recordB );
            reportingSection.ApproveLeavingRecord( recordC );
            reportingSection.ApproveLeavingRecord( recordD );
            reportingSection.ApproveLeavingRecord( recordE );

            Assert.That( recordA.IsApproved, Is.EqualTo( true ) );
            Assert.That( recordA.SectionDecided, Is.EqualTo( SectionType.TeamLeader ) );

            Assert.That( recordB.IsApproved, Is.EqualTo( true ) );
            Assert.That( recordB.SectionDecided, Is.EqualTo( SectionType.ProjectLeader ) );

            Assert.That( recordC.IsApproved, Is.EqualTo( true ) );
            Assert.That( recordC.SectionDecided, Is.EqualTo( SectionType.HR ) );

            Assert.That( recordD.IsApproved, Is.EqualTo( false ) );
            Assert.That( recordD.SectionDecided, Is.EqualTo( SectionType.HR ) );

            Assert.That( recordE.IsApproved, Is.EqualTo( false ) );
            Assert.That( recordE.SectionDecided, Is.EqualTo( SectionType.HR ) );
        }
    }
}
