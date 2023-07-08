using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    public class TreeCollection : ICollection
    {
        public Node Root { get; set; }
        public TreeCollection(Node r)
        {
            this.Root = r;
        }

        public Iterator CreateDepthFirstIterator()
        {
            return new DepthFirstIterator(this);
        }
        public Iterator CreateBreadthFirstIterator()
        {
            return new BreadthFirstIterator(this);
        }
    }
}
