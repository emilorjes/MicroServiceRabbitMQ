using CSharpFundamentals;

namespace UnitTests
{
    public class BookTests
    {
        [Fact]
        public void CalculateMultiplicationOfTwoNumbers()
        {
            // Arrange
            int x = 5;
            int y = 2;
            int expected = 10;

            // Act
            int actual = x * y;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // Arrange
            Book book = new("Emils Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // Act
            Statistics result = book.GetStatistics();

            // Assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}