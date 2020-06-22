using Strategy.Compression.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Compression.Class
{
    public class File
    {
        public CompressionType Comporession { get; set; }

        public string FileName { get; set; }
    }
}
