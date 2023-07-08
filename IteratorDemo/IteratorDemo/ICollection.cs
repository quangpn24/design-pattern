using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
     public interface ICollection
    {
        public Iterator CreateDepthFirstIterator();
        public Iterator CreateBreadthFirstIterator();
    }
}
