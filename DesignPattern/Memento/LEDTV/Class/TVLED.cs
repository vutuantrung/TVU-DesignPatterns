using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.LEDTV.Class
{
    public class TVLED
    {
        public string Size { get; set; }

        public string Price { get; set; }

        public bool USBSupport { get; set; }

        public TVLED( string size, string price, bool usbSupport )
        {
            Size = size;
            Price = price;
            USBSupport = usbSupport;
        }
    }
}
