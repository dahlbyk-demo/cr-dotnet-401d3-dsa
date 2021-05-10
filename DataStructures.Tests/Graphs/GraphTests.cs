using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Graphs;
using Xunit;

namespace DataStructures.Tests.Graphs
{
    public class GraphTests
    {
        [Fact]
        public void Starts_empty()
        {
            // Arrange / Act
            var graph = new Graph<string, int>();

            // Assert
            Assert.Empty(graph.Nodes);
            Assert.Equal(0, graph.Count);
        }

        [Fact]
        public void AddNode_adds_nodes()
        {
            // Arrange
            var graph = new Graph<string, int>();

            // Act
            graph.AddNode("A");

            // Assert
            Assert.Contains(graph.Nodes, n => n.Value == "A");
            Assert.Equal(1, graph.Count);
        }
    }
}
