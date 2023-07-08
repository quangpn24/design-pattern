using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    public class DepthFirstIterator :Iterator
    {
        private Queue<Node> traversal;
        private Node current;
        private TreeCollection binaryTree;

        public DepthFirstIterator(TreeCollection collection)
        {
            traversal = new Queue<Node>();
            current = collection.Root;
            binaryTree = collection;
            Initialize(binaryTree.Root);
            traversal.Dequeue();
        }
        private void Initialize(Node root)
        {
            if (root == null) return;
            traversal.Enqueue(root);
            Initialize(root.Left);
            Initialize(root.Right);
        }
        public bool HasNext()
        {
            return traversal.Count > 0;
        }

        public Node NextNode()
        {
            if (!HasNext())
                throw new InvalidOperationException("No more elements in the traversal.");
            Node curr = traversal.Dequeue();
            current = curr;
            return curr;
        }
        public Node CurrentNode()
        {
            return current;
        }
    }
}
