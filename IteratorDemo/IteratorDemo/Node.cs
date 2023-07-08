using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    public class Node
    {
        public int Val {get;set;}
        public Node? Left { get;set;}
        public Node? Right { get;set;}
        public Node(int data)
        {
            Val = data;
            Left = null;
            Right = null;
        }
        public Node(int data, Node l, Node r)
        {
            Val = data;
            Left = l;
            Right = r;
        }
    }
}
