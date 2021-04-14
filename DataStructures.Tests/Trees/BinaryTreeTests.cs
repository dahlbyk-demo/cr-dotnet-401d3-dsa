using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Trees;
using Xunit;

namespace DataStructures.Tests.Trees
{
    public class BinaryTreeTests
    {
        [Fact]
        public void BreadthFirst_returns_empty_for_empty_Tree()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            var result = tree.BreadthFirst();

            // Assert
            Assert.Empty(result);
        }
    }
}
