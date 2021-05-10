using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graphs
{
    public class Graph<TValue, TEdge>
    {
        public void AddNode(TValue value)
        {
        }

        /// <summary>
        /// Add directed edge from <paramref name="from"/> to <paramref name="to"/>.
        /// </summary>
        public void AddEdge(TValue from, TValue to, TEdge data = default)
        {
        }

        public IEnumerable<Node> Nodes => Enumerable.Empty<Node>();

        public IEnumerable<Edge> GetNeighbors(TValue value)
        {
            throw new NotImplementedException();
        }

        public int Count => 0;

        public class Node
        {
        }

        public class Edge
        {
        }
    }
}
