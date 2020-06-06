using Proxy.Buisiness.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Buisiness.Class
{
    public class Employee
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public EmployeeType Role { get; set; }

        private Package _package;

        public Employee( string username, string password, EmployeeType role )
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public void ReceiveSharedFolder( ISharedFolder sharedFolder )
        {
            _package = sharedFolder.GetPackage();
        }

        public Package GetPackage()
        {
            return _package;
        }
    }
}
