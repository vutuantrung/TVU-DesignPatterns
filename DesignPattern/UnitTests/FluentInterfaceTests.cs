using FluentInterface.Class;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    class FluentInterfaceTests
    {
        [Test]
        public void test_client()
        {
            string firstName = "testFirstName";
            string lastName = "testLastName";
            string zipCode = "0354594";
            double myWallet = 16546.1654651;
            string town = "testTown";
            string street = "testStreet";
            int homeNumber = 151341;

            Client client = new Client.Builder()
                    .FirstName( firstName )
                    .LastName( lastName )
                    .ZipCode( zipCode )
                    .MyWallet( myWallet )
                    .Town( town )
                    .Street( street )
                    .HomeNumber( homeNumber )
                    .Build();

            Assert.That( client.FirstName == firstName );
            Assert.That( client.LastName == lastName );
            Assert.That( client.ZipCode == zipCode );
            Assert.That( client.MyWallet == myWallet );
            Assert.That( client.Town == town );
            Assert.That( client.Street == street );
            Assert.That( client.HomeNumber == homeNumber );

        }

        [Test]
        public void test_employee()
        {
            string fullName = "testFullName";
            string departement = "testDepartement";
            string address = "testAddress";
            DateTime dateOfBirth = new DateTime( 2008, 5, 1, 8, 30, 52 );

            Employee employee = new FluentEmployee()
                .Initialize()
                .SetFullName( fullName )
                .SetDateOfBirth( dateOfBirth )
                .SetDepartement( departement )
                .SetAddress( address )
                .Build();

            Assert.That( employee.FullName == fullName );
            Assert.That( employee.Departement == departement );
            Assert.That( employee.Address == address );
            Assert.That( employee.DateOfBirth == dateOfBirth );

        }
    }
}
