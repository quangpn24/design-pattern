using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFlyWeight
{
    public interface IFont
    {
        void SetFont(string name, int size, bool bold, bool italic);
        void Display(string text);
    }

}
