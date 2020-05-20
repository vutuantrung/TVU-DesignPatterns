using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example1.Builder
{
    public interface IBuilder
    {
        void BuilderPartA();

        void BuilderPartB();

        void BuilderPartC();
    }
}
