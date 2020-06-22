using Strategy.Compression.Class;
using Strategy.Compression.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Compression.StrategyCompression
{
    // This class implements the algorithm defined by the Strategy (ICompression) interface.
    public class RARCompression : ICompression
    {
        public void CompressFolder( File file )
        {
            file.Comporession = CompressionType.Rar;
        }
    }
}
