using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Element;

namespace Visitor.ConcreteVistor
{
    // Visitor khám sức khỏe
    class HealthCheckVisitor : Visitors
    {
        public override void Visit(KindergartenStudent student)
        {
            Console.WriteLine($"Khám sức khỏe cho học sinh mẫu giáo {student.Name}");
            // Thực hiện các thao tác khám sức khỏe đối với học sinh mẫu giáo
        }

        public override void Visit(ElementaryStudent student)
        {
            Console.WriteLine($"Khám sức khỏe cho học sinh tiểu học {student.Name}");
            // Thực hiện các thao tác khám sức khỏe đối với học sinh tiểu học
        }

        public override void Visit(MiddleSchoolStudent student)
        {
            Console.WriteLine($"Khám sức khỏe cho học sinh trung học cơ sở {student.Name}");
            // Thực hiện các thao tác khám sức khỏe đối với học sinh trung học cơ sở
        }

        public override void Visit(HighSchoolStudent student)
        {
            Console.WriteLine($"Khám sức khỏe cho học sinh trung học phổ thông {student.Name}");
            // Thực hiện các thao tác khám sức khỏe đối với học sinh trung học phổ thông
        }
    }
}
