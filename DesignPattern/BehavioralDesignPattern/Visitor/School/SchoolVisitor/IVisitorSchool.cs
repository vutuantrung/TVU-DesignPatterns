using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.SchoolElement;

namespace Visitor.School.SchoolVisitor
{
    // This is an interface and it declares the Visit operation for each element in the object structure (i.e. for concrete visitors).
    public interface IVisitorSchool
    {
        void Visit( IElementSchool element );
    }
}
