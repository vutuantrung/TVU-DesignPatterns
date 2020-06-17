using System;
using System.Collections.Generic;
using System.Text;
using Visitor.School.SchoolElement;

namespace Visitor.School.SchoolVisitor
{
    public interface IVisitorSchool
    {
        void Visit( IElementSchool element );
    }
}
