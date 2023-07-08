using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Element
{
    // Lớp gốc cho các lớp học sinh
    abstract class Student
    {
        public string Name { get; }
        public int Age { get; }

        protected Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Accept(Visitors visitor);
    }
}
