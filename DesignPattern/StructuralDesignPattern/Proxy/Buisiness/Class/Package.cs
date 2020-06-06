using Proxy.Buisiness.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Buisiness.Class
{
    public class Package
    {
        public bool CanRead { get; set; }

        public bool CanWrite { get; set; }

        public Package( PackageType package )
        {
            if ( package == PackageType.CanRead )
            {
                CanRead = true;
                CanWrite = false;
            }
            else if ( package == PackageType.CanWrite )
            {
                CanRead = false;
                CanWrite = true;
            }
            else
            {
                CanRead = true;
                CanWrite = true;
            }
        }
    }
}
