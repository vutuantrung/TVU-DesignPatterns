using Proxy.VirtualProxy.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.VirtualProxy.Proxy
{
    public class ProxyImage : IImage
    {
        private IImage _realImage = null;

        private string _filename;

        public ProxyImage( string fileName )
        {
            _filename = fileName;
        }

        public void DisplayImage()
        {
            if ( _realImage == null )
            {
                _realImage = new RealImage( _filename );
            }

            _realImage.DisplayImage();
        }
    }
}
