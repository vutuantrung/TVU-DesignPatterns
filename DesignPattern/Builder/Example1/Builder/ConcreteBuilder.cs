using System;
using Builder.Example1.Products;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder() 
        {
            _product = new Product();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuilderPartA()
        {
            _product.Add( "Part A1" );
        }

        public void BuilderPartB()
        {
            _product.Add( "Part B1" );
        }

        public void BuilderPartC()
        {
            _product.Add( "Part C1" );
        }

        public Product GetProduct()
        {
            Product result = _product;

            this.Reset();

            return result;
        }
    }
}
