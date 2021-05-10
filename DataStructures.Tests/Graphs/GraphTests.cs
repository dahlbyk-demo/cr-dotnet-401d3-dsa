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
    }
}
