using Strategy.Compression.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Compression.StrategyCompression
{
    // The Strategy declares an interface that is going to be implemented by all supported algorithms.
    public interface ICompression
    {
        void CompressFolder( File file );
    }
}
