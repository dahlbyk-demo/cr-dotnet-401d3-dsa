using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    public class Graph<TValue, TEdge>
    {
        private readonly List<Node> nodes = new List<Node>();

        public void AddNode(TValue value)
        {
            var node = new Node { Value = value };
            nodes.Add(node);
        }

        /// <summary>
        /// Add directed edge from <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        public void AddEdge(TValue from, TValue to, TEdge data = default)
        {
        }

        public IEnumerable<Node> Nodes => nodes;

        public IEnumerable<Edge> GetNeighbors(TValue value)
        {
            throw new NotImplementedException();
        }

        public int Count => nodes.Count;

        public class Node
        {
            public TValue Value { get; set; }
        }

        public class Edge
        {
        }
    }
}
