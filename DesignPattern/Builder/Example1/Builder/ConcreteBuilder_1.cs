using System;
using Builder.Example1.Products;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Builder
{
    public class ConcreteBuilder_1 : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder_1()
        {
            _product = new Product();
        }

        public void BuilderPartA()
        {
            _product.Add( EnumProduct_1.PartA );
        }

        public void BuilderPartB()
        {
            _product.Add( EnumProduct_1.PartB );
        }

        public void BuilderPartC()
        {
            _product.Add( EnumProduct_1.PartC );
        }

        public void BuilderPartD()
        {
            _product.Add( EnumProduct_1.PartD );
        }

        public void BuilderPartE()
        {
            _product.Add( EnumProduct_1.PartE );
        }

        public void Reset()
        {
            _product = new Product();
        }

        public Product GetProduct()
        {
            Product result = _product;

            this.Reset();

            return result;
        }
    }
}
