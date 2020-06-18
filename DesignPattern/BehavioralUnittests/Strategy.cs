using NUnit.Framework;
using Strategy.Compression.Class;
using Strategy.Compression.Enum;
using Strategy.Compression.StrategyCompression;
using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralUnittests
{
    [TestFixture]
    class Strategy
    {
        [Test]
        public void Test_Compression()
        {
            File file = new File { Comporession = CompressionType.None, FileName = "testingCompressionFile" };

            ZIPCompression zipCompression = new ZIPCompression();
            CompressionContext context = new CompressionContext( zipCompression );

            context.CreateArchive( file );

            Assert.That( file.Comporession, Is.EqualTo( CompressionType.Zip ) );

            RARCompression rarCompression = new RARCompression();
            context.SetStrategy( rarCompression );

            context.CreateArchive( file );

            Assert.That( file.Comporession, Is.EqualTo( CompressionType.Rar ) );
        }
    }
}
