using Strategy.Compression.Class;
using Strategy.Compression.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Compression.StrategyCompression
{
    public class ZIPCompression : ICompression
    {
        public void CompressFolder( File file )
        {
            file.Comporession = CompressionType.Zip;
        }
    }
}
