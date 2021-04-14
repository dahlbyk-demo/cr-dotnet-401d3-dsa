﻿using System;
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

        [Fact]
        public void BreadthFirst_returns_root_for_Tree_with_one_thing()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new Node { Value = 5 };

            // Act
            var result = tree.BreadthFirst();

            // Assert
            Assert.Equal(new[] { 5 }, result);
        }

        [Fact]
        public void BreadthFirst_works_for_big_tree()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new Node { Value = 2 };
            tree.Root.Left = new Node { Value = 7 };
            tree.Root.Left.Left = new Node { Value = 2 };
            tree.Root.Left.Right = new Node
            {
                Value = 6,
                Left = new Node { Value = 5 },
                Right = new Node { Value = 11 },
            };
            tree.Root.Right = new Node
            {
                Value = 5,
                Right = new Node
                {
                    Value = 9,
                    Left = new Node
                    {
                        Value = 4
                    }
                }
            };

            // Act
            var result = tree.BreadthFirst();

            // Assert
            Assert.Equal(new[] { 2, 7, 5, 2, 6, 9, 5, 11, 4 }, result);
        }
    }
}