using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    public class Graph<TValue, TEdge>
    {
        // Generic-friendly way to check equality
        private readonly IEqualityComparer<TValue> comparer = EqualityComparer<TValue>.Default;

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
            var fromNode = nodes.First(n => comparer.Equals(n.Value, from));
            var toNode = nodes.First(n => comparer.Equals(n.Value, to));

            fromNode.Edges.Add(new Edge
            {
                From = fromNode,
                To = toNode,
            });
        }

        public IEnumerable<Node> Nodes => nodes;

        public IEnumerable<Edge> GetNeighbors(TValue value)
        {
            var fromNode = nodes.First(n => comparer.Equals(n.Value, value));

            return fromNode.Edges;
        }

        public int Count => nodes.Count;

        public class Node
        {
            public TValue Value { get; set; }
            public List<Edge> Edges { get; } = new List<Edge>();
        }

        public class Edge
        {
            public Node From { get; set; }
            public Node To { get; set; }
        }
    }
}
