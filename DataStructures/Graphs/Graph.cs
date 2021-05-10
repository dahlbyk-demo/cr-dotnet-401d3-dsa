using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    public class Graph<TValue, TEdge>
    {
        private readonly Dictionary<TValue, Node> nodes = new();

        public void AddNode(TValue value)
        {
            var node = new Node { Value = value };
            nodes.Add(value, node);
        }

        /// <summary>
        /// Add directed edge from <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        public void AddEdge(TValue from, TValue to, TEdge data = default)
        {
            var fromNode = nodes[from];
            var toNode = nodes[to];

            fromNode.Edges.Add(new Edge
            {
                From = fromNode,
                To = toNode,
            });
        }

        public IEnumerable<Node> Nodes => nodes.Values;

        public IEnumerable<Edge> GetNeighbors(TValue value)
        {
            var fromNode = nodes[value];

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
