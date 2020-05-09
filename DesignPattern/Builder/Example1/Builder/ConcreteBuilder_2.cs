using Builder.Example1.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Builder
{
    public class ConcreteBuilder_2 : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder_2()
        {
            _product = new Product();
        }

        public void BuilderPartA()
        {
            _product.Add( EnumProduct_2.PartA );
        }

        public void BuilderPartB()
        {
            _product.Add( EnumProduct_2.PartB );
        }

        public void BuilderPartC()
        {
            _product.Add( EnumProduct_2.PartC );
        }

        public void BuilderPartD()
        {
            _product.Add( EnumProduct_2.PartD );
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
