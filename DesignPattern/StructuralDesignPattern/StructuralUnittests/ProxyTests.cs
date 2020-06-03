using NUnit.Framework;
using Proxy.Buisiness.Class;
using Proxy.Buisiness.Enum;
using Proxy.Buisiness.Proxy;
using Proxy.Demo;
using Proxy.Demo.Class;
using Proxy.Demo.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralUnittests
{
    [TestFixture]
    class ProxyTests
    {
        [Test]
        public void Test_business()
        {
            {
                Employee person = new Employee( "userTest", "password", EmployeeType.Manager );
                SharedFolderProxy proxy = new SharedFolderProxy( person );
                proxy.SetAccessingPackageLevel();
                proxy.PerformOperation();

                Assert.That( person.Username, Is.EqualTo( "userTest" ) );
                Assert.That( person.Password, Is.EqualTo( "password" ) );
                Assert.That( person.GetPackage().CanRead && person.GetPackage().CanWrite );
            }

            {
                Employee person = new Employee( "userTest", "password", EmployeeType.CEO );
                SharedFolderProxy proxy = new SharedFolderProxy( person );
                proxy.SetAccessingPackageLevel();
                proxy.PerformOperation();

                Assert.That( person.Username, Is.EqualTo( "userTest" ) );
                Assert.That( person.Password, Is.EqualTo( "password" ) );
                Assert.That( person.GetPackage().CanRead && person.GetPackage().CanWrite );
            }

            {
                Employee person = new Employee( "userTest", "password", EmployeeType.Developer );
                SharedFolderProxy proxy = new SharedFolderProxy( person );
                proxy.SetAccessingPackageLevel();
                proxy.PerformOperation();

                Assert.That( person.Username, Is.EqualTo( "userTest" ) );
                Assert.That( person.Password, Is.EqualTo( "password" ) );
                Assert.That( !person.GetPackage().CanRead && person.GetPackage().CanWrite );
            }

            {
                Employee person = new Employee( "userTest", "password", EmployeeType.Staff );
                SharedFolderProxy proxy = new SharedFolderProxy( person );
                proxy.SetAccessingPackageLevel();
                proxy.PerformOperation();

                Assert.That( person.Username, Is.EqualTo( "userTest" ) );
                Assert.That( person.Password, Is.EqualTo( "password" ) );
                Assert.That( person.GetPackage().CanRead && !person.GetPackage().CanWrite );
            }

            {
                Employee person = new Employee( "userTest", "password", EmployeeType.Visiter );
                SharedFolderProxy proxy = new SharedFolderProxy( person );
                proxy.SetAccessingPackageLevel();
                proxy.PerformOperation();

                Assert.That( person.Username, Is.EqualTo( "userTest" ) );
                Assert.That( person.Password, Is.EqualTo( "password" ) );
                Assert.That( person.GetPackage(), Is.EqualTo( null ) );
            }
        }

        [Test]
        public void Test_demo()
        {
            // Test iwth real subject
            DemoClient client = new DemoClient();
            RealSubject realSubject = new RealSubject();
            client.ClientCode( realSubject );

            // Test with proxy
            DemoProxy proxy = new DemoProxy( realSubject );
            client.ClientCode( proxy );
        }
    }
}
