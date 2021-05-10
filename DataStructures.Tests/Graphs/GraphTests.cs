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

        [Fact]
        public void AddEdge_adds_directed_edge_we_can_see_with_GetNeighbors()
        {
            // Arrange
            var graph = new Graph<string, int>();
            graph.AddNode("A");
            graph.AddNode("B");

            // Act
            graph.AddEdge("A", "B");

            // Assert
            var neighborsA = graph.GetNeighbors("A");

            var aToB = neighborsA.Single();
            Assert.Equal("A", aToB.From.Value);
            Assert.Equal("B", aToB.To.Value);

            var neighborsB = graph.GetNeighbors("B");
            Assert.Empty(neighborsB);
        }

        // TODO: Edge data (aka weight)
        // TODO: Value not found?
    }
}
