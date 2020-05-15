using Builder.Example1;
using Builder.Example1.Builder;
using Builder.Example1.Products;
using Builder.Example2;
using Builder.Example2.Builder;
using Builder.Example2.Enum;
using Builder.Example2.Product;
using Builder.Example3;
using Builder.Example3.Builder;
using Builder.Example3.Enum;
using Builder.Example3.Product;
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
            Assert.That( product.ListPart.Contains( ProductType1.PartA ) );
            #endregion

            #region Build full feature
            builder.Reset();

            director.BuildEssentialParts();

            product = builder.GetProduct();

            Assert.That( product.Count == 3 );
            Assert.That( product.ListPart.Contains( ProductType1.PartA ) );
            Assert.That( product.ListPart.Contains( ProductType1.PartB ) );
            Assert.That( product.ListPart.Contains( ProductType1.PartC ) );
            #endregion

            #region Build full feature for concrete
            builder.Reset();

            director.BuildEssentialParts();

            // Another build part
            builder.BuilderPartD();
            builder.BuilderPartE();

            product = builder.GetProduct();

            Assert.That( product.Count == 5 );
            Assert.That( product.ListPart.Contains( ProductType1.PartA ) );
            Assert.That( product.ListPart.Contains( ProductType1.PartB ) );
            Assert.That( product.ListPart.Contains( ProductType1.PartC ) );
            Assert.That( product.ListPart.Contains( ProductType1.PartE ) );
            Assert.That( product.ListPart.Contains( ProductType1.PartD ) );
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
            Assert.That( product.ListPart.Contains( ProductType2.PartA ) );
            #endregion

            #region Build full feature
            builder.Reset();

            director.BuildEssentialParts();

            product = builder.GetProduct();

            Assert.That( product.Count == 3 );
            Assert.That( product.ListPart.Contains( ProductType2.PartA ) );
            Assert.That( product.ListPart.Contains( ProductType2.PartB ) );
            Assert.That( product.ListPart.Contains( ProductType2.PartC ) );
            Assert.That( !product.ListPart.Contains( ProductType2.PartD ) );
            #endregion

            #region Build full feature for concrete
            builder.Reset();

            director.BuildEssentialParts();

            // Another build part
            builder.BuilderPartD();

            product = builder.GetProduct();

            Assert.That( product.Count == 4 );
            Assert.That( product.ListPart.Contains( ProductType2.PartA ) );
            Assert.That( product.ListPart.Contains( ProductType2.PartB ) );
            Assert.That( product.ListPart.Contains( ProductType2.PartC ) );
            Assert.That( product.ListPart.Contains( ProductType2.PartD ) );
            #endregion
        }

        [Test]
        public void builder_test_report()
        {
            Report report;
            ReportDirector director = new ReportDirector();

            #region Excel
            {
                ExcelReportBuilder builder = new ExcelReportBuilder();
                report = director.CreateReport( builder );

                Assert.That( report.ReportType == ReportType.Excel );
                Assert.That( report.ReportHeader == HeaderType.ExcelHeader );
                Assert.That( report.ReportContent == ContentType.ExcelContent );
                Assert.That( report.ReportFooter == FooterType.ExcelFooter );
            }
            #endregion

            #region PDF
            {
                PDFReportBuilder builder = new PDFReportBuilder();
                report = director.CreateReport( builder );

                Assert.That( report.ReportType == ReportType.PDF );
                Assert.That( report.ReportHeader == HeaderType.PDFHeader );
                Assert.That( report.ReportContent == ContentType.PDFContent );
                Assert.That( report.ReportFooter == FooterType.PDFFooter );
            }
            #endregion

            #region Word
            {
                WordReportBuilder builder = new WordReportBuilder();
                report = director.CreateReport( builder );

                Assert.That( report.ReportType == ReportType.Word );
                Assert.That( report.ReportHeader == HeaderType.WordHeader );
                Assert.That( report.ReportContent == ContentType.WordContent );
                Assert.That( report.ReportFooter == FooterType.WordFooter );
            }
            #endregion

            #region Powerpoint
            {
                PowerPointReportBuilder builder = new PowerPointReportBuilder();
                report = director.CreateReport( builder );

                Assert.That( report.ReportType == ReportType.PowerPoint );
                Assert.That( report.ReportHeader == HeaderType.PowerPointHeader );
                Assert.That( report.ReportContent == ContentType.PowerPointContent );
                Assert.That( report.ReportFooter == FooterType.PowerPointFooter );
            }
            #endregion
        }

        [Test]
        public void builder_test_beverage()
        {
            BeverageRecipe recipe;
            BeverageDirector director = new BeverageDirector();

            #region Tea
            {
                TeaBeverageBuilder builder = new TeaBeverageBuilder();
                recipe = director.MakeBeverageRecipe( builder );

                Assert.That( recipe.BeverageType == Beverage.Tea );
                Assert.That( recipe.Water == 40 );
                Assert.That( recipe.Milk == 50 );
                Assert.That( recipe.Sugar == 10 );
                Assert.That( recipe.PowderQuantity == 15 );
            }
            #endregion

            #region Coffee
            {
                CoffeeBeverageBuilder builder = new CoffeeBeverageBuilder();
                recipe = director.MakeBeverageRecipe( builder );

                Assert.That( recipe.BeverageType == Beverage.Coffee );
                Assert.That( recipe.Water == 50 );
                Assert.That( recipe.Milk == 60 );
                Assert.That( recipe.Sugar == 15 );
                Assert.That( recipe.PowderQuantity == 20 );
            }
            #endregion

        }
    }
}
