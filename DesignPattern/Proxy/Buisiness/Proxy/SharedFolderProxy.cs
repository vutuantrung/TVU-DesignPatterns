using Proxy.Buisiness.Class;
using Proxy.Buisiness.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Buisiness.Proxy
{
    public class SharedFolderProxy : ISharedFolder
    {
        private Employee _employee;

        private Package _package;

        public SharedFolderProxy( Employee employee )
        {
            _employee = employee;
        }

        public ISharedFolder SendSharedFolder()
        {
            return new SharedFolder( _package );
        }

        public void SetAccessingPackageLevel()
        {
            if ( _employee.Role == EmployeeType.CEO || _employee.Role == EmployeeType.Manager )
            {
                _package = new Package( PackageType.CanReadAndWrite );
            }
            else if ( _employee.Role == EmployeeType.Developer )
            {
                _package = new Package( PackageType.CanWrite );
            }
            else if( _employee.Role == EmployeeType.Staff )
            {
                _package = new Package( PackageType.CanRead );
            }
            else
            {
                _package = null;
            }
        }

        public void PerformOperation()
        {
            _employee.ReceiveSharedFolder( SendSharedFolder() );
        }

        public Package GetPackage()
        {
            return _package;
        }
    }
}
