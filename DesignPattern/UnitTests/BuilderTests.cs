using Builder.Example1;
using Builder.Example1.Builder;
using Builder.Example1.Products;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestFixture]
    public class BuilderTests
    {
        [Test]
        public void builder_test_1()
        {
            ConcreteBuilder_1 builder = new ConcreteBuilder_1();

            Director director = new Director();
            // Add reference builder inton director
            director.Builder = builder;

            #region Build Build minimal
            director.BuildMinimalParts();

            Product product = builder.GetProduct();

            Assert.That( product.Count == 1 );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartA ));
            #endregion

            #region Build full feature
            builder.Reset();

            director.BuildEssentialParts();

            product = builder.GetProduct();

            Assert.That( product.Count == 3 );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartA ) );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartB ) );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartC ) );
            #endregion

            #region Build full feature for concrete
            builder.Reset();

            director.BuildEssentialParts();

            // Another build part
            builder.BuilderPartD();
            builder.BuilderPartE();

            product = builder.GetProduct();

            Assert.That( product.Count == 5 );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartA ) );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartB ) );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartC ) );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartE ) );
            Assert.That( product.ListPart.Contains( EnumProduct_1.PartD ) );
            #endregion
        }

        [Test]
        public void builder_test_2()
        {
            ConcreteBuilder_2 builder = new ConcreteBuilder_2();

            Director director = new Director();
            // Add reference builder inton director
            director.Builder = builder;

            #region Build Build minimal
            director.BuildMinimalParts();

            Product product = builder.GetProduct();

            Assert.That( product.Count == 1 );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartA ) );
            #endregion

            #region Build full feature
            builder.Reset();

            director.BuildEssentialParts();

            product = builder.GetProduct();

            Assert.That( product.Count == 3 );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartA ) );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartB ) );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartC ) );
            Assert.That( !product.ListPart.Contains( EnumProduct_2.PartD ) );
            #endregion

            #region Build full feature for concrete
            builder.Reset();

            director.BuildEssentialParts();

            // Another build part
            builder.BuilderPartD();

            product = builder.GetProduct();

            Assert.That( product.Count == 4 );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartA ) );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartB ) );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartC ) );
            Assert.That( product.ListPart.Contains( EnumProduct_2.PartD ) );
            #endregion
        }
    }
}
