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
