using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.VirtualProxy.Class
{
    public class RealImage : IImage
    {
        private string _filename;

        public RealImage(string fileName )
        {
            _filename = fileName;
            LoadImageFromDisk();
        }

        public void DisplayImage()
        {
            Console.WriteLine( $"Displaying image: { _filename }." );
        }

        public void LoadImageFromDisk()
        {
            Console.WriteLine( $"Loading image { _filename }." );
        }
    }
}
