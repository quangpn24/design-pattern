using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    public interface Iterator
    {
        Node NextNode();
        bool HasNext();
        Node CurrentNode();
    }
}
