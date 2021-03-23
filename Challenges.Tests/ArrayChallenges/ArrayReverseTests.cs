using Challenges.ArrayChallenges;
using Xunit;

namespace Challenges.Tests.ArrayChallenges
{
    public class ArrayReverseTests
    {
        [Fact]
        public void Reverse_returns_empty_array_given_empty_array()
        {
            // Arrange
            int[] array = new int[0];

            // Act
            int[] result = ArrayReverse.Reverse(array);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Reverse_return_reversed_array_with_odd_count()
        {
            // Arrange
            int[] array = new[] { 1, 2, 3 };

            // Act
            int[] result = ArrayReverse.Reverse(array);

            // Assert
            Assert.Equal(3, result.Length);

            Assert.Equal(3, result[0]);
            Assert.Equal(2, result[1]);
            Assert.Equal(1, result[2]);
        }

        [Fact]
        public void Reverse_return_reversed_array_with_even_count()
        {
            // Arrange
            int[] array = new[] { 1, 2, 3, 4 };

            // Act
            int[] result = ArrayReverse.Reverse(array);

            // Assert

            // Instead of checking individual values, let xUnit do it
            int[] expected = new[] { 4, 3, 2, 1 };
            Assert.Equal(expected, result);
        }
    }
}
