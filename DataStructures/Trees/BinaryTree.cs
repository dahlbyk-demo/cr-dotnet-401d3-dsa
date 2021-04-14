using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public IEnumerable<int> BreadthFirst()
        {
            //Queue breadth <-- new Queue()
            var breadth = new Queue<Node>();
            //breadth.enqueue(root)
            breadth.Enqueue(Root);

            //while breadth.peek()
            while (breadth.Count > 0)
            {
                //  node front = breadth.dequeue()
                var front = breadth.Dequeue();

                // If front isn't actually a node, skip it
                if (front == null) continue;

                //  OUTPUT <-- front.value
                yield return front.Value;

                //  if front.left is not NULL
                if (front.Left != null)
                    //    breadth.enqueue(front.left)
                    breadth.Enqueue(front.Left);

                //  if front.right is not NULL
                if (front.Right != null)
                    //    breadth.enqueue(front.right)
                    breadth.Enqueue(front.Right);
            }

            // yield break; // No longer needed, but helpful at the start
        }

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrder(Root, result);
            return result;
        }

        private void PreOrder(Node node, List<int> result)
        {
            // Stretch goal: use yield return instead
            result.Add(node.Value);

            if (node.Left != null)
                PreOrder(node.Left, result);

            if (node.Right != null)
                PreOrder(node.Right, result);
        }

        // TODO: PostOrder, InOrder
    }

    public class Node
    {
        // Stretch goal: make this generic
        public int Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
