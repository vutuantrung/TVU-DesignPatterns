using Builder.Example1.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMinimalParts()
        {
            _builder.BuilderPartA();
        }

        public void BuildEssentialParts()
        {
            _builder.BuilderPartA();
            _builder.BuilderPartB();
            _builder.BuilderPartC();
        }
    }
}
