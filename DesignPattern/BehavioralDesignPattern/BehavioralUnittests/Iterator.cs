﻿using Iterator.EmployeeIterator.AggregateClass;
using Iterator.EmployeeIterator.Class;
using Iterator.EmployeeIterator.IteratorClass;
using Iterator.Words.CollectionClass;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Iterator
    {
        [Test]
        public void Test_employee_iteartor_list()
        {
            ICollectionEmployee collection = new CollectionList();

            collection.AddEmployee( new Employee( name: "Anurag", id: 100 ) );
            collection.AddEmployee( new Employee( name: "Pranaya", id: 101 ) );
            collection.AddEmployee( new Employee( name: "Santosh", id: 102 ) );
            collection.AddEmployee( new Employee( name: "Priyanka", id: 103 ) );
            collection.AddEmployee( new Employee( name: "Abinash", id: 104 ) );
            collection.AddEmployee( new Employee( name: "Preety", id: 105 ) );
            collection.AddEmployee( new Employee( name: "Kappaa", id: 106 ) );

            Assert.That( collection.Count() == 7 );

            IIteratorEmployee iterator = collection.CreateIterator();

            Employee employee = null;
            {
                employee = iterator.First();

                Assert.That( employee.Name, Is.EqualTo( "Anurag" ) );
                Assert.That( employee.ID, Is.EqualTo( 100 ) );
            }

            {
                employee = iterator.Next();
                Assert.That( employee.Name, Is.EqualTo( "Pranaya" ) );
                Assert.That( employee.ID, Is.EqualTo( 101 ) );

                employee = iterator.Next();
                Assert.That( employee.Name, Is.EqualTo( "Santosh" ) );
                Assert.That( employee.ID, Is.EqualTo( 102 ) );

                employee = iterator.Next();
                employee = iterator.Next();
                employee = iterator.Next();
                Assert.That( employee.Name, Is.EqualTo( "Preety" ) );
                Assert.That( employee.ID, Is.EqualTo( 105 ) );
            }

            {
                employee = iterator.First();

                Assert.That( employee.Name, Is.EqualTo( "Anurag" ) );
                Assert.That( employee.ID, Is.EqualTo( 100 ) );
            }
        }

        [Test]
        public void Test_employee_iteartor_array()
        {
            ICollectionEmployee collection = new CollectionArray();

            collection.AddEmployee( new Employee( name: "Anurag", id: 100 ) );
            collection.AddEmployee( new Employee( name: "Pranaya", id: 101 ) );
            collection.AddEmployee( new Employee( name: "Santosh", id: 102 ) );
            collection.AddEmployee( new Employee( name: "Priyanka", id: 103 ) );
            collection.AddEmployee( new Employee( name: "Abinash", id: 104 ) );
            collection.AddEmployee( new Employee( name: "Preety", id: 105 ) );
            collection.AddEmployee( new Employee( name: "Kappaa", id: 106 ) );

            Assert.That( collection.Count() == 7 );

            IIteratorEmployee iterator = collection.CreateIterator();

            Employee employee = null;
            {
                employee = iterator.First();

                Assert.That( employee.Name, Is.EqualTo( "Anurag" ) );
                Assert.That( employee.ID, Is.EqualTo( 100 ) );
            }

            {
                employee = iterator.Next();
                Assert.That( employee.Name, Is.EqualTo( "Pranaya" ) );
                Assert.That( employee.ID, Is.EqualTo( 101 ) );

                employee = iterator.Next();
                Assert.That( employee.Name, Is.EqualTo( "Santosh" ) );
                Assert.That( employee.ID, Is.EqualTo( 102 ) );

                employee = iterator.Next();
                employee = iterator.Next();
                employee = iterator.Next();
                Assert.That( employee.Name, Is.EqualTo( "Preety" ) );
                Assert.That( employee.ID, Is.EqualTo( 105 ) );
            }

            {
                employee = iterator.First();

                Assert.That( employee.Name, Is.EqualTo( "Anurag" ) );
                Assert.That( employee.ID, Is.EqualTo( 100 ) );
            }
        }

        [Test]
        public void Test_words()
        {
            var collection = new WordsCollection();

            collection.AddItem( "Tuan" );
            collection.AddItem( "Hello" );
            collection.AddItem( "First" );

            Assert.That( collection.GetItems().Count == 3 );

            {
                var iterator = collection.GetEnumerator();

                Assert.That( iterator.Current, Is.EqualTo( "Tuan" ) );

                iterator.MoveNext(); Assert.That( iterator.Current, Is.EqualTo( "Hello" ) );
                iterator.MoveNext(); Assert.That( iterator.Current, Is.EqualTo( "First" ) );

                iterator.Reset(); Assert.That( iterator.Current, Is.EqualTo( "Tuan" ) );
                iterator.MoveNext();
                iterator.MoveNext();
                Assert.That( iterator.Current, Is.EqualTo( "First" ) );
            }

            collection.ReserveDirection();
            {
                var iterator = collection.GetEnumerator();

                Assert.That( iterator.Current, Is.EqualTo( "First" ) );

                iterator.MoveNext(); Assert.That( iterator.Current, Is.EqualTo( "Hello" ) );
                iterator.MoveNext(); Assert.That( iterator.Current, Is.EqualTo( "Tuan" ) );

                iterator.Reset(); Assert.That( iterator.Current, Is.EqualTo( "First" ) );
                iterator.MoveNext();
                iterator.MoveNext();
                Assert.That( iterator.Current, Is.EqualTo( "Tuan" ) );
            }
           
        }

    }
}