using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Element;

namespace Visitor
{
    abstract class Visitors
    {
        public abstract void Visit(KindergartenStudent student);
        public abstract void Visit(ElementaryStudent student);
        public abstract void Visit(MiddleSchoolStudent student);
        public abstract void Visit(HighSchoolStudent student);
    }
}
