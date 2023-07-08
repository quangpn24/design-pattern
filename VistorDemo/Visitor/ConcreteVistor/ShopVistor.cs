using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Element;

namespace Visitor.ConcreteVistor
{
    // Visitor mua bán đồng phục, balo
    class ShopVisitor : Visitors
    {
        public override void Visit(KindergartenStudent student)
        {
            Console.WriteLine($"Mua đồng phục, balo cho học sinh mẫu giáo {student.Name}");
            // Thực hiện các thao tác mua đồng phục, balo cho học sinh mẫu giáo
        }

        public override void Visit(ElementaryStudent student)
        {
            Console.WriteLine($"Mua đồng phục, balo cho học sinh tiểu học {student.Name}");
            // Thực hiện các thao tác mua đồng phục, balo cho học sinh tiểu học
        }

        public override void Visit(MiddleSchoolStudent student)
        {
            Console.WriteLine($"Mua đồng phục, balo cho học sinh trung học cơ sở {student.Name}");
            // Thực hiện các thao tác mua đồng phục, balo cho học sinh trung học cơ sở
        }

        public override void Visit(HighSchoolStudent student)
        {
            Console.WriteLine($"Mua đồng phục, balo cho học sinh trung học phổ thông {student.Name}");
            // Thực hiện các thao tác mua đồng phục, balo cho học sinh trung học phổ thông
        }
    }
}
