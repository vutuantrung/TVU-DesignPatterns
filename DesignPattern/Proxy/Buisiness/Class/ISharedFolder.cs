using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Buisiness.Class
{
    public interface ISharedFolder
    {
        ISharedFolder SendSharedFolder();
        void SetAccessingPackageLevel();
        Package GetPackage();
    }
}
