using Strategy.Compression.StrategyCompression;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Compression.Class
{
    // This is a class which maintains a reference to a Strategy object, and then uses that reference to call the algorithm defined by a particular ConcreteStrategy
    public class CompressionContext
    {
        ICompression _compression;

        public CompressionContext( ICompression compression )
        {
            _compression = compression;
        }

        public void SetStrategy( ICompression compression )
        {
            _compression = compression;
        }

        public void CreateArchive( File file )
        {
            _compression.CompressFolder( file );
        }
    }
}
