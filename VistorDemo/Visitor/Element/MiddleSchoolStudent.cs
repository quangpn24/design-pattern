using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Element
{
    // Lớp học sinh trung học cơ sở
    class MiddleSchoolStudent : Student
    {
        public MiddleSchoolStudent(string name, int age) : base(name, age)
        {
        }

        public override void Accept(Visitors visitor)
        {
            visitor.Visit(this);
        }
    }
}
