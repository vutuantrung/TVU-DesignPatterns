using NUnit.Framework;
using Singleton;
using Singleton.Enum;
using Singleton.NaiveSingleton;
using Singleton.ThreadSafeSingleton;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    class SingletonTests
    {
        [Test]
        public void test_singleton_double_check_lock()
        {
            var watch = Stopwatch.StartNew();

            Parallel.Invoke(
                () => PrintPersonInformation( SingletonDoubleCheckLock.GetInstance, Person.Teacher ),
                () => PrintPersonInformation( SingletonDoubleCheckLock.GetInstance, Person.Student )
                );

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine( $"Elapsed time: { elapsedMs }." );
        }


        [Test]
        public void test_singleton_single_check_lock()
        {
            var watch = Stopwatch.StartNew();

            Parallel.Invoke(
                () => PrintPersonInformation( SingletonSingleCheckLock.GetInstance, Person.Teacher ),
                () => PrintPersonInformation( SingletonSingleCheckLock.GetInstance, Person.Student )
                );

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine( $"Elapsed time: { elapsedMs }." );
        }


        [Test]
        public void test_counter_singleton()
        {
            var watch = Stopwatch.StartNew();

            Parallel.Invoke(
                () => PrintPersonInformation( SingletonCounter.GetInstance, Person.Teacher ),
                () => PrintPersonInformation( SingletonCounter.GetInstance, Person.Student )
                );

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine( $"Elapsed time: { elapsedMs }." );
        }


        static void PrintPersonInformation( ISingletonDemo singleton, Person person )
        {
            singleton.PrintInformation( $"From { person.ToString() }." );
        }
    }
}
