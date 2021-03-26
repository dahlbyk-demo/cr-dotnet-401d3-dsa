using DataStructures.LinkedLists;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class LinkedListTests
    {
        [Fact]
        public void Empty_list_has_null_Head()
        {
            // Arrange/Act
            LinkedList list = new LinkedList();

            // Assert
            Assert.Null(list.Head);
        }

        [Fact]
        public void Insert_works_for_empty_list()
        {
            // Arrange
            LinkedList list = new LinkedList();

            int value = 5;

            // Act
            list.Insert(value);

            // Assert
            // no longer empty
            Assert.NotNull(list.Head);

            // first node has expected value
            Assert.Equal(value, list.Head.Value);

            // first node Next is null
            Assert.Null(list.Head.Next);
        }

        [Fact(Skip = "Homework")]
        public void Insert_works_for_list_that_is_not_empty()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(5);

            int value = 3;

            // Act
            list.Insert(3);

            // Assert
            Assert.NotNull(list.Head);
            Assert.Equal(value, list.Head.Value);
            Assert.NotNull(list.Head.Next);
            Assert.Equal(5, list.Head.Next.Value);
        }

        [Theory(Skip = "Homework")]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        public void Include_works(int valueToFind, bool expected)
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Insert(2);
            list.Insert(3);

            // Act
            bool result = list.Include(valueToFind);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
