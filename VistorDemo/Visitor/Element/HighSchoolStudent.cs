using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Element
{
    // Lớp học sinh trung học phổ thông
    class HighSchoolStudent : Student
    {
        public HighSchoolStudent(string name, int age) : base(name, age)
        {
        }

        public override void Accept(Visitors visitor)
        {
            visitor.Visit(this);
        }
    }
}
