using Proxy.Buisiness.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Buisiness.Class
{
    public class SharedFolder : ISharedFolder
    {
        private Package _package;

        public SharedFolder( Package package )
        {
            _package = package;
        }

        public Package GetPackage()
        {
            return _package;
        }

        public ISharedFolder SendSharedFolder()
        {
            return this;
        }

        public void SetAccessingPackageLevel()
        {
            throw new NotImplementedException();
        }

        public class Builder
        {

        }
    }
}
