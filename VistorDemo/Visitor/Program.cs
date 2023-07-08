using System;
using System.Text;
using Visitor;
using Visitor.ConcreteVistor;
using Visitor.Element;

// Sử dụng các lớp và Visitor
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Khởi tạo các đối tượng học sinh
        Student kindergartenStudent = new KindergartenStudent("Học sinh mẫu giáo 1", 5);
        Student elementaryStudent = new ElementaryStudent("Học sinh tiểu học 1", 8);
        Student middleSchoolStudent = new MiddleSchoolStudent("Học sinh trung học cơ sở 1", 12);
        Student highSchoolStudent = new HighSchoolStudent("Học sinh trung học phổ thông 1", 15);

        // Khởi tạo Visitor
        Visitors healthCheckVisitor = new HealthCheckVisitor();
        Visitors shopVisitor = new ShopVisitor();

        // Học sinh chấp nhận Visitor để thực hiện khám sức khỏe
        kindergartenStudent.Accept(healthCheckVisitor);
        elementaryStudent.Accept(healthCheckVisitor);
        middleSchoolStudent.Accept(healthCheckVisitor);
        highSchoolStudent.Accept(healthCheckVisitor);

        // Học sinh chấp nhận Visitor để thực hiện mua bán đồng phục, balo
        kindergartenStudent.Accept(shopVisitor);
        elementaryStudent.Accept(shopVisitor);
        middleSchoolStudent.Accept(shopVisitor);
        highSchoolStudent.Accept(shopVisitor);
    }
}
