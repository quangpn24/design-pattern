using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IteratorDemo
{
    public class BreadthFirstIterator : Iterator
    {
        private Queue<Node> traversal;
        private Queue<Node> queueBFT = new Queue<Node>();
        private Node current;
        private TreeCollection binaryTree;

        public BreadthFirstIterator(TreeCollection collection)
        {
            traversal = new Queue<Node>();
            current = collection.Root;
            this.binaryTree = collection;
            InitializeStack(this.binaryTree.Root);
        }
        private void InitializeStack(Node root)
        {
            if (root == null) return;
            queueBFT.Enqueue(root);
            while (queueBFT.Count > 0)
            {
               var node =  queueBFT.Dequeue();
               if (node.Left != null)
               {
                    queueBFT.Enqueue(node.Left);
                    traversal.Enqueue(node.Left);
               }
               if (node.Right != null)
               {
                    queueBFT.Enqueue(node.Right);
                    traversal.Enqueue(node.Right);
               }
            }
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
