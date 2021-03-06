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
            if (Root != null)
                breadth.Enqueue(Root);

            //while breadth.peek()
            //  node front = breadth.dequeue()
            while (breadth.TryDequeue(out Node front))
            {
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

        public IEnumerable<int> InOrder() => InOrder(Root);

        private IEnumerable<int> InOrder(Node root)
        {
            if (root == null)
                yield break;

            //if root.left is not NULL
            if (root.Left != null)
                // inOrder(root.left)
                foreach (var leftNode in InOrder(root.Left))
                    yield return leftNode;

            //OUTPUT < --root.value
            yield return root.Value;

            //if root.right is not NULL
            if (root.Right != null)
                // inOrder(root.right)
                foreach (var rightNode in InOrder(root.Right))
                    yield return rightNode;

            yield break;
        }

        // TODO: PostOrder, InOrder

        // Not tree related
        public static IEnumerable<int> CountForever(int start)
        {
            while (true)
                yield return start++;
        }

        public static IEnumerable<int> RandomValues()
        {
            var random = new Random();
            while (true)
                yield return random.Next();
        }
    }

    public class Node
    {
        // Stretch goal: make this generic
        public int Value { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
